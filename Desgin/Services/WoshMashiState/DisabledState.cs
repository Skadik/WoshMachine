using Desgin.Entyty.Items;
namespace Desgin.Services.WoshMashiState
{
    public class DisabledState : State
    {
        public DisabledState(WoshMashin WM) : base(WM)
        {
            this.WM = WM;
        }

        public override void state()
        {
            if (WM.IsPower())
            {
                WM.setState(new WorkingState(WM));
            }
        }

    }
}
