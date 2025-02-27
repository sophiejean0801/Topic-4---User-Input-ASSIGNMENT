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
            Console.WriteLine(wage.ToString("C") + "? Hopefully that's per hour!");

            // User Input - Part 2
            Console.WriteLine("Hello! What's your name?");
            string name2 = Console.ReadLine();
            Console.WriteLine("Nice to meet you, " + name2 + "! How old are you?");
            int age2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You're " + age + "! What's your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("What grade are you " + name + "?"); // Grade 9-12
            int grade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's your student id number");
            int studentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's your school login?");
            string login = Console.ReadLine();
            Console.WriteLine("What's your average?"); // rounded to the nearest tenth
            double average = Convert.ToDouble(Console.ReadLine());
            
            // Summary
            Console.WriteLine("Summary");
            Console.WriteLine("Name: " + name2 + " " + lastName);
            Console.WriteLine("Age: " + age2);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Student ID: " + studentId);
            Console.WriteLine("Login: " + login);
            Console.WriteLine("Average: " + average);

            // User Input - Part 3
            Console.WriteLine("Hello! What's your name?");
            string name3 = Console.ReadLine();
            Console.WriteLine("Nice to meet you, " + name3 + "! How old are you?");
            int age3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Did you know in 5 years you will be " + (age3 + 5) + "? Cool right?");

            // User Input - Part 4
            Console.WriteLine("First number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Third number:");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The average of " + firstNumber + ", " + secondNumber + ", and " + thirdNumber + " is " + (firstNumber + secondNumber + thirdNumber / 2) + ".");

            // User Input - Part 5
            Console.WriteLine("First Item:");
            string firstItem = Console.ReadLine();
            Console.WriteLine("Price of the first item:");
            double firstPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Second Item:");
            string secondItem = Console.ReadLine();
            Console.WriteLine("Price of the second item:");
            double secondPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The total price is: " + (firstPrice + secondPrice).ToString("C"));
            Console.WriteLine("If you were to have a twenty percent discount your total price would be : " + ((firstPrice + secondPrice) * 0.8).ToString("C"));
            
            Console.WriteLine("You end up saving: " + ((firstPrice + secondPrice) * 0.2).ToString("C"));
            double tax = (firstPrice + secondPrice) * 0.8 * 0.13;
            Console.WriteLine("Your sales tax is: " + (tax.ToString("C")));
            Console.WriteLine("Your total price with tax is: " + ((firstPrice + secondPrice) * 0.8 + tax).ToString("C"));
            // Summary
            Console.WriteLine("Here's your receipt");
            Console.WriteLine("First Item: " + firstItem + " Price: " + firstPrice.ToString("C"));
            Console.WriteLine("Second Item: " + secondItem + " Price: " + secondPrice.ToString("C"));
            Console.WriteLine("Total Price: " + (firstPrice + secondPrice).ToString("C"));
            Console.WriteLine("Total Price with Discount: " + ((firstPrice + secondPrice) * 0.8).ToString("C"));
           
            Console.WriteLine("Sales Tax: " + tax.ToString("C"));
            Console.WriteLine("Total Price with Tax: " + ((firstPrice + secondPrice) * 0.8 + tax).ToString("C"));
















        }
    }
}
