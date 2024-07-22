namespace Desgin.Services.NPCState
{
    public class SerchState : State
    {
        public override void checkoutState()
        {
            //в випадку якщо ти пыдыйшов до тої точки де когось бачив і нікого немає
            if (true)
            {
                new PeaceState();
            }
            //якщо ти побачив ворога 
             if (true)
            {
                new FightState();
            }
        }
    }
}
