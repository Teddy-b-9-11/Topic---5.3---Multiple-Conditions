namespace Topic___5._3___Multiple_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string working, passward;
            int age, guesses;
            double money;

            
            Console.WriteLine("how old is a teenager");
            int.TryParse(Console.ReadLine(), out age);
            if (age >= 13 && age <= 19)
                Console.WriteLine("Yes a teenager is between 13-19");
            else
                Console.WriteLine("No a teenager is not " + age);

            //Task1
            Console.WriteLine("Are you supposed to be working?");
            working = Console.ReadLine();
            Console.WriteLine("how much money do you have");
            double.TryParse(Console.ReadLine(), out money);
            if (working == "no" && money >= 20.00)
                Console.WriteLine("You may enter, enjoy the movie");
            else
                Console.WriteLine("Sorry tickets cost 20 bucks, and we don't support people skipping it");
            /*
            //Task2
            Console.WriteLine("You have 5 trys to guess the passward");
            Console.WriteLine("Enter the passward");
            passward = Console.ReadLine();
            if (passward == "taco")
                Console.WriteLine("Open Sesame");
            else
                Console.WriteLine("Access Denied");
            */




        }
    }
}
