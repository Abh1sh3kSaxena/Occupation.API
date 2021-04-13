using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Occupation.API.Models;

namespace Occupation.API.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public List<OccupationMapping> Get()
        {
            List<OccupationMapping> occupations = new List<OccupationMapping>();
            occupations.Add(new OccupationMapping("Cleaner", "Light Manual"));
            occupations.Add(new OccupationMapping("Doctor", "Professional"));
            occupations.Add(new OccupationMapping("Author", "White Collar"));
            occupations.Add(new OccupationMapping("Farmer", "Heavy Manual"));
            occupations.Add(new OccupationMapping("Mechanic", "Heavy Manual"));
            occupations.Add(new OccupationMapping("Florist", "Light Manual"));
            return occupations;
            
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

     
    }
}
