using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Occupation.API.Models
{
    public class OccupationMapping
    {
        string occupation;
        string raiting;

        public OccupationMapping()
        {

        }
        public OccupationMapping(string o, string r)
        {
            occupation = o;
            raiting = r;
        }
    }
}
