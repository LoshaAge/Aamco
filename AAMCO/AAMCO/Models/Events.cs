using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AAMCO.Models
{
    public class Event
    {
        public int Id { get; set; }
        public int YearCar { get; set; }
        public string NameCar { get; set; }
        public int Mess { get; set; }
        public int Name { get; set; }
        public int SecName { get; set; }
        public int Email { get; set; }
        public int Phone { get; set; }
    }

}