namespace DistributeurCafe.Model
{
    public static class RecipeDictionary
    {
        public static readonly Dictionary<string, Recipe> Recipes = new Dictionary<string, Recipe>
    {
        {"Expresso", new Recipe("Expresso", new List<Ingredient> { new Ingredient("Café", 1.0,1), new Ingredient("Eau", 0.2,1) })},
        {"Allongé", new Recipe("Allongé", new List<Ingredient> { new Ingredient("Café", 1.0,1), new Ingredient("Eau", 0.2,2) })},
        {"Capuccino", new Recipe("Capuccino", new List<Ingredient> { new Ingredient("Café", 1.0,1), new Ingredient("Chocolat", 1.0,1), new Ingredient("Eau", 0.2,1), new Ingredient("Crème", 0.5,1) })},
        {"Chocolat", new Recipe("Chocolat", new List<Ingredient> { new Ingredient("Chocolat", 1.0,3), new Ingredient("Lait", 0.4,2), new Ingredient("Eau", 0.2,1), new Ingredient("Sucre", 0.1,1) })},
        {"Thé", new Recipe("Thé", new List<Ingredient> { new Ingredient("Thé", 2.0,1), new Ingredient("Eau", 0.2,2) })}

    };

    }
}
