using Desgin.Entyty.Items;

namespace Desgin.Services.WoshMashiState
{
    public class WaitingState : State
    {
        public WaitingState(WoshMashin WM) : base (WM) 
        {
        }

        public override void state()
        {
            if (!WM.IsPower())
            {
                WM.setState(new DisabledState(WM));
            }
        }
    }
}
