namespace RecipeRealm
{

    class RecipeInfor
    {
        static int numIngredient; // Number Ingredients 
        static int numsteps; // Numbers of Steps
        static string recipeName; // Name of Recipe
        static string[] ingredName; // Ingredient Name
        static string[] indregMeasurement; // Measurement of Ingredients 
        static string[] stepsInstruction; // Clear Instrcutions of Steps
        static double[] measurementAmount; // The Amount of Measurement 


        public RecipeInfor()
        {
            // Initialize arrays
            numIngredient = 0;
            numsteps = 0;
            recipeName = "";
            ingredName = new string[0]; // Initialize as empty arrays
            indregMeasurement = new string[0];
            stepsInstruction = new string[0];
            measurementAmount = new double[0];

        }

        public static void RecipeInfo()
        {

            Console.WriteLine("\nWelcome To The RecipeRealm HandBook");
            Console.WriteLine("***************************************\n");

            Console.WriteLine("Enter Name Of Recipe");
            recipeName = Console.ReadLine();

            Console.WriteLine("Enter Number Of Ingridents");
            numIngredient = int.Parse(Console.ReadLine());

            ingredName = new string[numIngredient]; 
            measurementAmount = new double[numIngredient];
            indregMeasurement = new string[numIngredient];

            for (int i = 0; i < numIngredient; i++)
            {
                Console.WriteLine("\nEnter Ingrident Name " + (i + 1) + ":");
                ingredName[i] = Console.ReadLine();

                Console.WriteLine("\nEnter The Amount For " + ingredName[i] + ":");
                measurementAmount[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter the Unit Of Measurement For " + ingredName[i] + ":" + "(Tablespoons, Cup, Slice, etc... )");
                indregMeasurement[i] = Console.ReadLine();

            }


        }


    }

}