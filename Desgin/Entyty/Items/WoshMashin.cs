using Desgin.Services.WoshMashiState;
using System;

namespace Desgin.Entyty.Items
{
    public class WoshMashin : IWoshMachine
    {
        public enum Type
        {
            Horizontal,
            Vertical
        }

        protected State state;
        protected string name;
        protected string description;
        protected bool power;
        protected bool things;
        protected Type type;

        public WoshMashin(string name, string description, Type type)
        {
            state = new DisabledState(this);
            this.power = false;
            this.things = false;
            this.name = name;
            this.description = description;
            this.type = type;
        }
        public void WoshMachineOn()
        {
            if (this.isEmpty())
            {
                this.setPower(true);
                state.state();
            }
            else
            {
                throw new Exception("Немає речей");
            }
        }

        public void WoshMachineOff()
        {
            this.setPower(false);
            state.state();
        }

        public void putThings()
        {
            this.setThings(true);
        }

        public void getThings()
        {
            this.setThings(false);
        }

        // get set
        public string getName() => name;
        public void setName(string name)
        {
            this.name = name;
        }

        public string getDescription() => description;
        public void setDescription(string description)
        {
            this.description = description;
        }

        public Type getType() => type;
        public void setType(Type type)
        {
            this.type = type;
        }

        public bool IsPower() => power;
        public void setPower(bool isPower)
        {
            this.power = isPower;
        }

        public bool isEmpty() => things;
        public void setThings(bool Things)
        {
            this.things = Things;
        }

        public void setState(State state)
        {
            this.state = state;
        }
    }
}
