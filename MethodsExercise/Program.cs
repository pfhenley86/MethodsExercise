namespace MethodsExercise
{
    public class Program
    {
        //Exercise 1: Creating a C# Story Program
        public static string SocialEngineering()
        {
            //Exercise 1 - Social Engineering
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your mother's maiden name?");
            string motherName = Console.ReadLine();
            Console.WriteLine("What is the name of your first pet?");
            string petsFirstName = Console.ReadLine();
            Console.WriteLine("Name of the city where you were born?");
            string birthCity = Console.ReadLine();

            //output
            string result =
                $"Your name is {name} and your age is {age}, your mother's maiden name is {motherName}. Your first pet's name is {petsFirstName} and you were born in {birthCity}. Now I have your identity!! Haha!!";

            Console.WriteLine(result);
            return result;
        }

        //Exercise 2: Math Operations Methods
           public static int Addition(int num1, int num2)
           {
               int add = num1 + num2;
               Console.WriteLine(add);
               return add;
           }
           
           public static int Subtraction(int num1, int num2)
           {
                int sub = num1 - num2;
                Console.WriteLine(sub);
                return sub;
           }
           public static int Multiplication(int num1, int num2)
           {
               int multiply = num1 * num2;
               Console.WriteLine(multiply);
               return multiply;
           }
           
           public static double Division(double num1, double num2)
           {
               double divide = num1 / num2;
               Console.WriteLine(divide);
               return divide;
           }
           
    
        static void Main(string[] args)
        {
            //Call Exercise 1
            SocialEngineering();
            
            //Call Exercise 2
            Addition(100, 320);
            Subtraction(1340, 290);
            Multiplication(145, 23);
            Division(275, 13);
        }
    }
}
