namespace Desgin.Services.NPCState
{
    class FightState : State
    {
        public override void checkoutState()
        {
            //якщо ви перемогли ворога
            if (true)
            {
                new PeaceState();
            }
            //якщо твоїх товаришів вбили в великій кілкості і вас залишилось мало або ти пораненний
            if (true)
            {
                new EscapeState();
            }
        }
    }
}
