using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.BuilderBurger
{
    public class BurgerDirector
    {
        private readonly Interface1 _builder;
        public BurgerDirector(Interface1 builder)
        {
            _builder = builder;
        }
        public void Buildefault()
        {
            _builder
                .AddCheese()
                .AddTomato()
                .AddPickles();
        }
        public void BuildWithBeacon()
        {
            _builder
                .AddTomato()
                .AddBacon()
                .AddLetuce();
        }
    }
}
