using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class User:IEntity
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserAddress { get; set; }
        public int UserTypeID { get; set; }
        public string UserTelephone { get; set; }
        public string UserMail { get; set; }

    }
}
