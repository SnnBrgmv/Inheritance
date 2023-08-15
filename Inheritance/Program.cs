namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Vasif","Maharov",30);
            Student student = new Student("Ali", "Aliyev", 25);

            teacher.Explain();
            student.Learn();
            //Console.WriteLine(student.Name);
        }
    }
}