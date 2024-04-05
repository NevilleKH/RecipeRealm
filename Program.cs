namespace RecipeRealm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("\nWelcome to RecipeRealm!");
                Console.WriteLine("**************************\n");
                Console.WriteLine("Please Choose An Option Below\n");
                Console.WriteLine("1. Enter Recipe");
                Console.WriteLine("2. Show Recipe");
                Console.WriteLine("3. Scale Recipe");
                Console.WriteLine("4. Reset Recipe");
                Console.WriteLine("5. Clear Recipe");
                Console.WriteLine("6. Close Program");

                string option = Console.ReadLine();

                if (option == "1")
                {
                    RecipeInfor.RecipeInfo();
                }
                else if (option == "2")
                {
                    RecipeInfor.DisplayRecipe();
                }
                else if (option == "3")
                {
                    RecipeInfor.ScalePortion();
                }
                else if (option == "4")
                {
                    RecipeInfor.ResetQuantities();
                }
                else if (option == "5")
                {
                    Console.WriteLine("You entered no.5");
                }
                else if (option == "6")
                {
                    Console.WriteLine("You entered no.6");
                }
                else
                {
                   Console.WriteLine("Please enter a correct option");
                }

            }// End of While Loop

        }// End of Main method

    }// End of internal class

}// End of name space

