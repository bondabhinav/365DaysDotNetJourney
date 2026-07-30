namespace LearningDotNetDay1;

public class ReferenceTypeDemo
{
    public void ShowReferenceTypeBehavior()
    {
        Student student1 = new Student();

        student1.StudentId = 1;

        student1.StudentName = "Rahul";

        Student student2 = student1;
       
        student2.StudentName = "Aman";

        Console.WriteLine(
            $"Student 1 Name: {student1.StudentName}");

        Console.WriteLine(
            $"Student 2 Name: {student2.StudentName}");
    }
}