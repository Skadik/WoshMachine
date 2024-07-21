using Desgin.Entyty.Items;

namespace Desgin.Entyty.Factory
{
    public abstract class AbstractFactory : IAbstractFactory
    {
        public abstract WoshMashin create();
    }
}
