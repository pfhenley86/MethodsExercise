namespace MethodsExercise
{
    public class Program
    {
        public static string  SocialEngineering()
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
           string result = $"Your name is {name} and your age is {age}, your mother's maiden name is {motherName}. Your first pet's name is {petsFirstName} and you were born in {birthCity}. Now I have your identity!! Haha!!";
           
           Console.WriteLine(result);
           return result;
            
            
        }
        static void Main(string[] args)
        {
            SocialEngineering();
        }
    }
}
