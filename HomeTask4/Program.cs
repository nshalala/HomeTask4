using HomeTask4.Models;

Group P137 = new(3);

P137.AddStudent(new Student("Name1", "Surname1"));
P137.AddStudent(new Student("Name2", "Surname2"));
P137.AddStudent(new Student("Name3", "Surname3"));

Console.WriteLine(P137.GetStudents());

P137.AddStudent(new Student("Name4", "Surname4"));
