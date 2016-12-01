using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AAMCO.Models
{
    public class Events
    {
        public int YearCar { get; set; }
        public int NameCar { get; set; }
        public int Mass { get; set; }
        public int Name { get; set; }
        public int SName { get; set; }
        public int Email { get; set; }
        public int Phone { get; set; }

        
    
    }
}