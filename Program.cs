namespace ArrayHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Which student would you like to learn more about?Enter a number 1-3");
            Console.ReadLine();
            
            string input = Console.ReadLine();
            int num;
            num = int.Parse(Console.ReadLine());
          
            if (num > 3)
            {
                Console.WriteLine("Sorry, choose between 1-3");
                return;
                
            
        

                //string[] names = { "Brandon", "Biggie", "Sean" };
            
            
                //names[0] = "Brandon";
                //names[1] = "Biggie";
                //names[2] = "Sean";

            }

            //string[] hometown = {"Mt.Clemens", "Brooklyn", "Detroit" };
            //string[] FavoriteFood = { "Alfredo", "Steak", "Corned Beef" };
        }
    }
}