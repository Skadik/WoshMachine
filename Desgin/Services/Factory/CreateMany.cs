using Desgin.Entyty.Factory;
using Desgin.Entyty.Items;
using System.Collections.Generic;

namespace Desgin.Services.Factory
{
    public class CreateMany
    {
        public List<WoshMashin> createManyWM(IAbstractFactory factory, int count) 
        {
            List < WoshMashin > woshMashins = new List < WoshMashin >();
            for (int i = 0; i < count; i++)
            {
                woshMashins.Add(factory.create());
            }
            return woshMashins;
        }
    }
}
