using DistributeurCafe.Model;
using DistributeurCafe.Services;



/// <summary>
/// Programme pour pouvoir commander une boisson et calculer le prix
/// </summary>
public class Program
{


    public static void Main()
    {

        //Initialisation de l ordre service
        IOrderService orderService = new OrderDrinkService();

        while (true)
        {
            //Affichage du message de départ
            Console.WriteLine("\nBienvenue dans notre café ! Voici notre menu :");

            // Afficher le menu
            var menu = orderService.GetMenu();
            Console.WriteLine($"{menu}");

            //Message pour selectionner une boisson 
            Console.Write("Veuillez sélectionner une boisson : ");
            var selectedRecipeName = Console.ReadLine();

            if (RecipeDictionary.Recipes.TryGetValue(selectedRecipeName, out var selectedRecipe))
            {
                Console.WriteLine($"Vous avez commandé un(e) {selectedRecipeName}.");
                var sellingPrice = orderService.CalculatePrice(selectedRecipe);
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine($"Le prix de vente est de {sellingPrice} €.");
            }
            else
            {
                Console.WriteLine("La recette sélectionnée n'est pas disponible.");
            }
        }

    }
}
