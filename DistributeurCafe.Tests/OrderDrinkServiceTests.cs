using DistributeurCafe.Model;
using DistributeurCafe.Services;
using Xunit;


/// <summary>
/// Classe pur le test 
/// </summary>
public class OrderDrinkServiceTests
{
    [Fact]
    public void CalculatePrice_ShouldCalculateCorrectly()
    {
        // Arrange
        var orderService = new OrderDrinkService();
        // On utilise une recette existante dans le dictionnaire pour le test
        var expressoRecipe = RecipeDictionary.Recipes["Expresso"];

        // Act
        var expressoresult = orderService.CalculatePrice(expressoRecipe);

      
        // Assert
        Assert.Equal(1.56, expressoresult, 2);
    }

    [Fact]
    public void GetFormattedMenu_ShouldReturnCorrectMenu()
    {
        // Arrange
        var orderService = new OrderDrinkService();

        // Act
        var result = orderService.GetMenu();

        // Assert
        Assert.Contains("Expresso", result);
        Assert.Contains("Allongé", result);
    }

    [Fact]
    public void CalculatePrice_ShouldReturnZero_ForEmptyRecipe()
    {
        var orderService = new OrderDrinkService();
        var emptyRecipe = new Recipe("EmptyRecipe", new List<Ingredient>());

        var result = orderService.CalculatePrice(emptyRecipe);

        Assert.Equal(0.0, result, 2);
    }


}
