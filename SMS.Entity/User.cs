using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entity
{
    public class User
    {
        public string UserName { get; set; }
        public string UserID { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ProfilePhotoPath { get; set; }
    }
}
