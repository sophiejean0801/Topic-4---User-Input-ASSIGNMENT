namespace Topic_4___User_Input_ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User Input - Part 1
            Console.WriteLine("Hello! What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Nice to meet you, " + name + "! How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much do you make?");
            double wage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(wage + "! Hopefully that's per hour!");

            // User Input - Part 2
            Console.WriteLine("Hello! What's your name?");
            string name2 = Console.ReadLine();
            Console.WriteLine("Nice to meet you, " + name2 + "! How old are you?");
            int age2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You're " + age + "! What's your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("What grade are you" + name + "?"); // Grade 9-12
            int grade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's your student id number");
            int studentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's your school login?");
            string login = Console.ReadLine();
            Console.WriteLine("What's your average?"); // rounded to the nearest tenth
            int average = Convert.ToInt32(Console.ReadLine());
            // Summary
            Console.WriteLine("Summary");
            Console.WriteLine("Name: " + name2 + " " + lastName);
            Console.WriteLine("Age: " + age2);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Student ID: " + studentId);
            Console.WriteLine("Login: " + login);
            Console.WriteLine("Average: " + average);









            




        }
    }
}
