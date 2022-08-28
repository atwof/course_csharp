
namespace Entities
{
    public class ProductHash
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public ProductHash(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is ProductHash))
            {
                return false;
            }

            ProductHash other = obj as ProductHash;

            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }
    }
}

