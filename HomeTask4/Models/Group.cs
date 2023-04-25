namespace HomeTask4.Models; 

internal class Group
{
    public string No { get; set; }
    public int Limit { get; set; }
    private Student[] Students { get; set; } = { };


    public Group(int limit)
    {
        Limit = limit;
    }

    public void AddStudent(Student student)
    {
        if(Students.Length < Limit)
        {
            Student[] newList = new Student[Students.Length+1];
            for (int i = 0; i < Students.Length; i++)
            {
                newList[i] = Students[i];
            }
            newList[Students.Length] = student; 
            Students = newList;
            return;
        }
        Console.WriteLine("You cannot add any other student. Group is already full!!");
    }

    public string GetStudents()
    {
        string res = "List of students:";
        foreach (var student in Students)
        {
            res += $"\n{student.Name} {student.Surname}";
        }
        return res;
    }
}
