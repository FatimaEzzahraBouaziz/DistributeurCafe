using DistributeurCafe.Model;

namespace DistributeurCafe.Services
{
    /// <summary>
    /// Interface pour la commande de boisson  
    /// </summary>
    public interface IOrderService
    {
        /// <summary>
        /// Calculer prix de la recette 
        /// </summary>
        /// <param name="recipe"></param>
        double CalculatePrice(Recipe recipe);

        /// <summary>
        /// Afficher menu
        /// </summary>
        string GetMenu();
    }
}
