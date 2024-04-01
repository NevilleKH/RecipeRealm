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
            Measurementamount = new double[0];

        }


    }

}