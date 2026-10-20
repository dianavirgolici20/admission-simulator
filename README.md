# Admission Simulator

A Windows Forms desktop application in C# that simulates a university admission process: candidate management, automatic allocation to study programs based on grades and preferences, statistics and result export.

## Features

- **Candidate management (CRUD):** add, edit, delete and view candidates, with input validation.
- **Automatic allocation:** candidates are ranked by admission grade (60% high-school GPA + 40% exam grade). Each one is assigned to the first of their 3 preferred programs that still has available seats; otherwise they are rejected.
- **SQLite database:** candidates and programs are stored locally. The database and the initial 5 programs are created automatically on first run.
- **Statistics:** chart of seats per program and remaining seats after allocation.
- **Import / export:** save and load candidates as TXT and binary files; export an individual candidate file as XML.
- **Printing:** print the admission results.
- **Data binding:** `BindingList<Candidat>` bound to a `DataGridView`.

## Screenshots

![Candidates](screenshots/candidati.png)
![Allocation](screenshots/repartizare.png)
![Chart](screenshots/grafic.png)

## Tech stack

- C#, .NET Framework 4.7.2, Windows Forms
- SQLite (`System.Data.SQLite`)
- OOP concepts: inheritance, interfaces (`ICloneable`, `IComparable<T>`, `IEnumerable<T>`, custom `IEvaluabil`), operator overloading, indexer

## Project structure

```
Clase/       Domain classes (Persoana, Candidat, Specializare, Dosar, Comisie) and DatabaseHelper
Formulare/   Forms: candidates, allocation, chart
Form1.cs     Main window and file import/export
```

## How to run

1. Install Visual Studio with the **.NET desktop development** workload.
2. Clone the repository and open `Proiect_Final_Paw.sln`.
3. Visual Studio restores the NuGet packages automatically.
4. Press **F5**.

## Author

Virgolici Diana-Maria
