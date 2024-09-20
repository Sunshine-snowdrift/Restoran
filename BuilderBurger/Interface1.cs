using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restoran.DBCon;

namespace Restoran.BuilderBurger
{
    public interface Interface1
    {
        Interface1 AddCheese();
        Interface1 AddBacon();
        Interface1 AddLetuce();
        Interface1 AddTomato();
        Interface1 AddPickles();

        Burgers GetBurgers();
    }
}
