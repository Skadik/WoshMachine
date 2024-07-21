using Desgin.Entyty.Items;

namespace Desgin.Entyty.Factory
{
    public class VerticalWMFactory : AbstractFactory
    {
        public override WoshMashin create()
        {
            return new HorizontalWoshMachin("Rogalik3000", "Німецька якість");
        }
    }
}
