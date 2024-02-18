namespace DistributeurCafe.Model
{
    /// <summary>
    /// Classe recette
    /// </summary>
    public class Recipe
    {
        /// <summary>
        /// Nom
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Ingredients
        /// </summary>
        public List<Ingredient> Ingredients { get; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ingredients"></param>
        public Recipe(string name, List<Ingredient> ingredients)
        {
            Name = name;
            Ingredients = ingredients;
        }
    }
}
