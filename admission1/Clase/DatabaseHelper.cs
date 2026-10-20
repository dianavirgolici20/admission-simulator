using Proiect_Final_Paw.Clase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Proiect_Final_Paw
{
    public class DatabaseHelper
    {
        private static readonly string CONNECTION_STRING =
            $"Data Source={Application.StartupPath}\\admitere.db;Version=3;";

        public DatabaseHelper()
        {
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            try
            {
                using (var conn = new SQLiteConnection(CONNECTION_STRING))
                {
                    conn.Open();

                    var cmd = new SQLiteCommand(@"
                        CREATE TABLE IF NOT EXISTS Candidati (
                            Id       TEXT PRIMARY KEY,
                            Nume     TEXT NOT NULL,
                            Prenume  TEXT NOT NULL,
                            CNP      TEXT NOT NULL UNIQUE,
                            MedieBac REAL NOT NULL,
                            NotaExamen REAL NOT NULL,
                            Medie    REAL NOT NULL,
                            Optiune1 TEXT,
                            Optiune2 TEXT,
                            Optiune3 TEXT,
                            Status   TEXT NOT NULL DEFAULT 'Nerepartizat',
                            SpecializareRepartizata TEXT
                        );

                        CREATE TABLE IF NOT EXISTS Specializari (
                            Id       TEXT PRIMARY KEY,
                            Nume     TEXT NOT NULL UNIQUE,
                            NrLocuri INTEGER NOT NULL
                        );
                    ", conn);
                    cmd.ExecuteNonQuery();

                    SeedSpecializari(conn);
                }
            }
            catch (SQLiteException ex)
            {
                throw new Exception("Eroare la initializarea bazei de date: " + ex.Message, ex);
            }
        }

        private void SeedSpecializari(SQLiteConnection conn)
        {
            var specializari = new List<(string Nume, int Locuri)>
            {
                ("Informatica Economica", 3),
                ("Cibernetica Economica", 2),
                ("Statistica",            2),
                ("Marketing",             2),
                ("Management",            1)
            };

            foreach (var s in specializari)
            {
                var cmd = new SQLiteCommand(@"
                    INSERT OR IGNORE INTO Specializari (Id, Nume, NrLocuri)
                    VALUES (@Id, @Nume, @NrLocuri)", conn);
                cmd.Parameters.AddWithValue("@Id", Guid.NewGuid().ToString());
                cmd.Parameters.AddWithValue("@Nume", s.Nume);
                cmd.Parameters.AddWithValue("@NrLocuri", s.Locuri);
                cmd.ExecuteNonQuery();
            }
        }

        public void SalveazaCandidatiDinGrid(DataGridView dgv)
        {
            try
            {
                using (var conn = new SQLiteConnection(CONNECTION_STRING))
                {
                    conn.Open();

                   
                    new SQLiteCommand("DELETE FROM Candidati", conn).ExecuteNonQuery();

                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.Cells[0].Value == null) continue;

                        var cmd = new SQLiteCommand(@"
                            INSERT INTO Candidati 
                                (Id, Nume, Prenume, CNP, MedieBac, NotaExamen, Medie,
                                 Optiune1, Optiune2, Optiune3, Status)
                            VALUES 
                                (@Id, @Nume, @Prenume, @CNP, @MedieBac, @NotaExamen, @Medie,
                                 @Opt1, @Opt2, @Opt3, 'Nerepartizat')", conn);

                        cmd.Parameters.AddWithValue("@Id", Guid.NewGuid().ToString());
                        cmd.Parameters.AddWithValue("@Nume", row.Cells[0].Value.ToString());
                        cmd.Parameters.AddWithValue("@Prenume", row.Cells[1].Value.ToString());
                        cmd.Parameters.AddWithValue("@CNP", row.Cells[2].Value.ToString());
                        cmd.Parameters.AddWithValue("@MedieBac", Convert.ToDouble(row.Cells[3].Value));
                        cmd.Parameters.AddWithValue("@NotaExamen", Convert.ToDouble(row.Cells[4].Value));
                        cmd.Parameters.AddWithValue("@Medie", Convert.ToDouble(row.Cells[5].Value));
                        cmd.Parameters.AddWithValue("@Opt1", row.Cells[6].Value?.ToString() ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Opt2", row.Cells[7].Value?.ToString() ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Opt3", row.Cells[8].Value?.ToString() ?? (object)DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException ex)
            {
                throw new Exception("Eroare la salvarea candidatilor: " + ex.Message, ex);
            }
        }

        
        public void RuleazaAdmiterea()
        {
            try
            {
                using (var conn = new SQLiteConnection(CONNECTION_STRING))
                {
                    conn.Open();

                    
                    new SQLiteCommand(
                        "UPDATE Candidati SET Status='Nerepartizat', SpecializareRepartizata=NULL",
                        conn).ExecuteNonQuery();

                    
                    var locuri = new Dictionary<string, int>();
                    using (var r = new SQLiteCommand(
                        "SELECT Nume, NrLocuri FROM Specializari", conn).ExecuteReader())
                        while (r.Read())
                            locuri[r["Nume"].ToString()] = Convert.ToInt32(r["NrLocuri"]);

                    
                    var candidati = new List<(string Id, string O1, string O2, string O3)>();
                    using (var r = new SQLiteCommand(@"
                        SELECT Id, Optiune1, Optiune2, Optiune3
                        FROM Candidati
                        ORDER BY Medie DESC", conn).ExecuteReader())
                        while (r.Read())
                            candidati.Add((
                                r["Id"].ToString(),
                                r["Optiune1"] == DBNull.Value ? null : r["Optiune1"].ToString(),
                                r["Optiune2"] == DBNull.Value ? null : r["Optiune2"].ToString(),
                                r["Optiune3"] == DBNull.Value ? null : r["Optiune3"].ToString()
                            ));

                    
                    foreach (var c in candidati)
                    {
                        string[] optiuni = { c.O1, c.O2, c.O3 };
                        string repartizat = null;

                        foreach (var opt in optiuni)
                        {
                            if (opt != null && locuri.ContainsKey(opt) && locuri[opt] > 0)
                            {
                                repartizat = opt;
                                locuri[opt]--;
                                break;
                            }
                        }

                        SQLiteCommand cmdU;
                        if (repartizat != null)
                        {
                            cmdU = new SQLiteCommand(@"
                                UPDATE Candidati 
                                SET Status='Admis', SpecializareRepartizata=@Spec
                                WHERE Id=@Id", conn);
                            cmdU.Parameters.AddWithValue("@Spec", repartizat);
                        }
                        else
                        {
                            cmdU = new SQLiteCommand(
                                "UPDATE Candidati SET Status='Respins' WHERE Id=@Id", conn);
                        }
                        cmdU.Parameters.AddWithValue("@Id", c.Id);
                        cmdU.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException ex)
            {
                throw new Exception("Eroare la repartizare: " + ex.Message, ex);
            }
        }

    
        public DataTable GetAdmisiPerSpecializare(string specializare)
        {
            try
            {
                using (var conn = new SQLiteConnection(CONNECTION_STRING))
                {
                    conn.Open();
                    var cmd = new SQLiteCommand(@"
                        SELECT Nume, Prenume, CNP, ROUND(Medie, 2) AS Medie
                        FROM Candidati
                        WHERE Status = 'Admis'
                          AND SpecializareRepartizata = @Spec
                        ORDER BY Medie DESC", conn);
                    cmd.Parameters.AddWithValue("@Spec", specializare);
                    var dt = new DataTable();
                    new SQLiteDataAdapter(cmd).Fill(dt);
                    return dt;
                }
            }
            catch (SQLiteException ex)
            {
                throw new Exception("Eroare la citirea datelor: " + ex.Message, ex);
            }
        }

        public DataTable GetRespinsi()
        {
            try
            {
                using (var conn = new SQLiteConnection(CONNECTION_STRING))
                {
                    conn.Open();
                    var cmd = new SQLiteCommand(@"
                        SELECT Nume, Prenume, CNP, ROUND(Medie, 2) AS Medie
                        FROM Candidati
                        WHERE Status = 'Respins'
                        ORDER BY Medie DESC", conn);
                    var dt = new DataTable();
                    new SQLiteDataAdapter(cmd).Fill(dt);
                    return dt;
                }
            }
            catch (SQLiteException ex)
            {
                throw new Exception("Eroare la citirea datelor: " + ex.Message, ex);
            }
        }

        public DataTable GetToateRezultatele()
        {
            try
            {
                using (var conn = new SQLiteConnection(CONNECTION_STRING))
                {
                    conn.Open();
                    var cmd = new SQLiteCommand(@"
                        SELECT Nume, Prenume, CNP, 
                               ROUND(Medie, 2) AS Medie,
                               Status, 
                               SpecializareRepartizata AS Repartizat
                        FROM Candidati
                        ORDER BY Medie DESC", conn);
                    var dt = new DataTable();
                    new SQLiteDataAdapter(cmd).Fill(dt);
                    return dt;
                }
            }
            catch (SQLiteException ex)
            {
                throw new Exception("Eroare la citirea datelor: " + ex.Message, ex);
            }
        }

        public DataTable GetSpecializari()
        {
            try
            {
                using (var conn = new SQLiteConnection(CONNECTION_STRING))
                {
                    conn.Open();
                    var cmd = new SQLiteCommand("SELECT Nume, NrLocuri FROM Specializari", conn);
                    var dt = new DataTable();
                    new SQLiteDataAdapter(cmd).Fill(dt);
                    return dt;
                }
            }
            catch (SQLiteException ex)
            {
                throw new Exception("Eroare la citirea specializarilor: " + ex.Message, ex);
            }
        }

        public DataTable GetLocuriRamase()
        {
            try
            {
                using (var conn = new SQLiteConnection(CONNECTION_STRING))
                {
                    conn.Open();
                    var cmd = new SQLiteCommand(@"
                SELECT s.Nume, s.NrLocuri,
                       COUNT(c.Id) AS Ocupate,
                       s.NrLocuri - COUNT(c.Id) AS Ramase
                FROM Specializari s
                LEFT JOIN Candidati c 
                    ON c.SpecializareRepartizata = s.Nume 
                    AND c.Status = 'Admis'
                GROUP BY s.Nume, s.NrLocuri", conn);
                    var dt = new DataTable();
                    new SQLiteDataAdapter(cmd).Fill(dt);
                    return dt;
                }
            }
            catch (SQLiteException ex)
            {
                throw new Exception("Eroare la citirea locurilor: " + ex.Message, ex);
            }
        }
        public DataTable GetCandidati()
        {

            DataTable dt = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection(CONNECTION_STRING))
            {
                conn.Open();

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(
                    "SELECT * FROM Candidati",
                    conn
                );

                adapter.Fill(dt);
            }

            return dt;
        }
    }
    
}