using Restoran.DBCon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.BuilderBurger
{
    public class BurgerBuilder : Interface1
    {
        private Burgers _burger;
        public BurgerBuilder()
        {
            _burger = new Burgers();    
        }
        public Interface1 AddBacon()
        {
            _burger.Bacon = true;
            return this;
        }

        public Interface1 AddCheese()
        {
            _burger.Cheese = true;
            return this;
        }

        public Interface1 AddLetuce()
        {
            _burger.Letuce = true;
            return this;
        }

        public Interface1 AddPickles()
        {
            _burger.Pickles = true;
            return this;
        }

        public Interface1 AddTomato()
        {
            _burger.Tomato = true;
            return this;
        }

        public Burgers GetBurgers()
        {
            Burgers burger = _burger;
            _burger = new Burgers();
            return burger;
        }
    }
}
