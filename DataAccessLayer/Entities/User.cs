using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class User
    {
        public int ID { get; set; }
        public long AMKA { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateofBirth { get; set; }
    }
}
