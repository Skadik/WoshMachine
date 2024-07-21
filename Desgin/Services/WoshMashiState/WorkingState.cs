using Desgin.Entyty.Items;
namespace Desgin.Services.WoshMashiState
{
    public class WorkingState : State
    {
        public WorkingState(WoshMashin WM) : base(WM) 
        {
        }

        public override void state()
        {
            if (true)
            {
               WM.setState(new WaitingState(WM));
            }
        }
    }
}
