using Desgin.Entyty.Factory;

namespace Desgin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory = new VerticalWMFactory();
            var WM = factory.create();
            WM.putThings();
            WM.WoshMachineOn();
            WM.getThings();
            WM.WoshMachineOff();
        }
    }
}
