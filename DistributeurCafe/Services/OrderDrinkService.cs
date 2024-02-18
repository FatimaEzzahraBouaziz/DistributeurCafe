using DistributeurCafe.Model;
using System.Text;

namespace DistributeurCafe.Services
{
    /// <summary>
    /// Service pour commander boisson
    /// </summary>
    public class OrderDrinkService : IOrderService
    {
        private const double margin = 1.3;

        ///<inheritdoc/>
        public double CalculatePrice(Recipe recipe)
        {
            double cost = recipe.Ingredients.Sum(ingredient => ingredient.Price*ingredient.Dose);
            double sellingPrice = cost * margin;

            return Math.Round(sellingPrice,2);
        }

        ///<inheritdoc/>
        public string GetMenu()
        {
            StringBuilder menu = new StringBuilder();
            foreach (var recipe in RecipeDictionary.Recipes.Values)
            {
                menu.Append($"{recipe.Name}\n");
            }

            return menu.ToString();
        }

    }
}
