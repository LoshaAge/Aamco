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
        public int Year { get; set; }
        public string NameCar { get; set; }
        public int Message { get; set; }
        public int Name { get; set; }
        public int SName { get; set; }
        public int Email { get; set; }
        public int Phone { get; set; }
    }

}