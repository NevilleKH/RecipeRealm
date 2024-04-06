namespace RecipeRealm
{

    class RecipeInfor
    {
        static int numIngredient; // Number Ingredients 
        static int numSteps; // Numbers of Steps
        static string recipeName; // Name of Recipe
        static string[] ingredName; // Ingredient Name
        static string[] indregMeasurement; // Measurement of Ingredients 
        static string[] stepsInstruction; // Clear Instrcutions of Steps
        static double[] measurementAmount; // The Amount of Measurement 
        static double[] originalAmount; // Array to store original values


        public RecipeInfor()
        {
            // Initialize arrays
            numIngredient = 0;
            numSteps = 0;
            recipeName = "";
            ingredName = new string[0]; // Initialize as empty arrays
            indregMeasurement = new string[0];
            stepsInstruction = new string[0];
            measurementAmount = new double[0];
            originalAmount = new double[0];

        } // End of RecipeInfor contructor

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

            originalAmount = new double[numIngredient];
            Array.Copy(measurementAmount, originalAmount, numIngredient);

            Console.WriteLine("********************************************************************\n");
            Console.WriteLine("Enter Number Of Steps To Make a " + recipeName);
            numSteps = int.Parse(Console.ReadLine());

            stepsInstruction = new string[numSteps];

            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine("\nEnter Step Number " + (i + 1) + ":");
                stepsInstruction[i] = Console.ReadLine();

            }

            Console.WriteLine("\nThank you! The Recipe, Measurements, and Steps has been captured!");
            Console.WriteLine("********************************************************************\n");

        } // End of RecipeInfo Method

        public static void DisplayRecipe()
        {

            // Check if there is a recipe sotred
            if (string.IsNullOrEmpty(recipeName) || numIngredient == 0 || numSteps == 0)
            {
                Console.WriteLine("\nThere is no recipe to display here. Please Add A Recipe\n");
                return;
            }

            Console.WriteLine("\nRecipe Name: " + recipeName);
            Console.WriteLine("\nAll Inredients: ");
            Console.WriteLine("=====================================\n");

            for (int i = 0; i < numIngredient; i++)
            {

                Console.WriteLine(measurementAmount[i] + " " + indregMeasurement[i] + " of " + ingredName[i]);

            }

            Console.WriteLine("\nSteps to make a " + recipeName + ": ");
            Console.WriteLine("=====================================\n");

            for (int i = 0; i < numSteps; i++)
            {

                Console.WriteLine((i + 1) + ". " + stepsInstruction[i]);

            }

            Console.WriteLine("=====================================\n");

        } // Endd of DisplayRecipe Method


        //Scale Recipe Portion
        public static void ScalePortion()
        {
            // Check if there are ingredients to scale
            if (numIngredient == 0)
            {
                Console.WriteLine("\nThere's no recipe to scale here. Please Add Recipe\n");
                return; // Exit the method
            }

            Console.WriteLine("\nSelect An Option Below To Scale The Recipe");
            Console.WriteLine("=====================================\n");
            Console.WriteLine("1: Half(0.5)");
            Console.WriteLine("2: Double");
            Console.WriteLine("3: Triple");

            string option = Console.ReadLine();

            if (option == "1")
            {
                for (int i = 0; i < numIngredient; i++)
                {
                    originalAmount[i] = measurementAmount[i];
                    measurementAmount[i] *= 0.5;
                }
            }
            else if (option == "2")
            {
                for (int i = 0; i < numIngredient; i++)
                {
                    originalAmount[i] = measurementAmount[i];
                    measurementAmount[i] *= 2;
                }
            }
            else if (option == "3")
            {
                for (int i = 0; i < numIngredient; i++)
                {
                    originalAmount[i] = measurementAmount[i];
                    measurementAmount[i] *= 3;
                }
            }
            else
            {
                Console.WriteLine("Please Slect An Option From 1-3\n");

            }

            Console.WriteLine("\nYour Recipe Has Been Scaled!");
            Console.WriteLine("\nAll Inredients: ");

            for (int i = 0; i < numIngredient; i++)
            {
                Console.WriteLine(measurementAmount[i] + " " + indregMeasurement[i] + " of " + ingredName[i]);

            }

            Console.WriteLine("=====================================\n");

        } // End of Scale Recipe Portion Method

        //Reset to the original quantities.
        public static void ResetQuantities()
        {
            // Check if there are ingredients to reset
            if (numIngredient == 0)
            {
                Console.WriteLine("\nThere's no recipe to reset here. Please Add Recipe\n");
                return; // Exit the method
            }

            for (int i = 0; i < numIngredient; i++)
            {

                measurementAmount[i] = originalAmount[i];
            }

            Console.WriteLine("\nRecipe Has Been Reset To Its Original Scale.\n");

        }//End Reset to the original quantities method 

        // Clear Recipe Data
        public static void ClearRecipeData()
        {

            // Check if there's any recipe data to clear
            if (numIngredient == 0 && numSteps == 0 && string.IsNullOrEmpty(recipeName) && ingredName == null && indregMeasurement == null && stepsInstruction == null && measurementAmount == null && originalAmount == null)
            {
                Console.WriteLine("\nThere's no recipe data to clear. Please Add Recipe\n");
                return; // Exit the method
            }

            numIngredient = 0;
            numSteps = 0;
            recipeName = "";
            ingredName = null;
            indregMeasurement = null;
            stepsInstruction = null;
            measurementAmount = null;
            originalAmount = null;

            Console.WriteLine("\nAll Recipe details has been cleared!");
            Console.WriteLine("=====================================\n");
        }// End Of Clear Recipe Data Method

    }// End of Recipe Class
}