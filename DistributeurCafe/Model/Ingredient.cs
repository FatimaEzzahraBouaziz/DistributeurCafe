namespace DistributeurCafe.Model
{
    /// <summary>
    /// Classe Ingredient
    /// </summary>
    public class Ingredient
    {
        /// <summary>
        /// Le nom
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Le prix 
        /// </summary>
        public double Price { get; }

        /// <summary>
        /// La dose
        /// </summary>
        public int Dose { get; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="dose"></param>
        public Ingredient(string name, double price, int dose)
        {
            Name = name;
            Price = price;
            Dose = dose;
        }
    }
}
