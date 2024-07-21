using Desgin.Entyty.Items;

namespace Desgin.Services.WoshMashiState
{
    public abstract class State : IWoshMachineState
    {
        protected WoshMashin WM;

        public State(WoshMashin WM)
        {
            this.WM = WM;
        }

        public abstract void state();
    
    }
}
