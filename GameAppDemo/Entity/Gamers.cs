using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAppDemo.Entity
{
    public class Gamers : IEntity
    {
        public int Id { get; set; }
        public string GamerFirstName { get; set; }
        public string GamerLastName { get; set; }
        public DateTime GamerDateOfBirth { get; set; }
        public string GamerNationalityId { get; set; }
        public string GamerNickName { get; set; }
        public string GamerEmail { get; set; }
        public string GamerPassword { get; set; }
    }
}
