using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playlist_Converter.Models
{
    public class AccountModel
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }

    }
    //Need to finish going through the model and find all the properties needed for the DB
    //Need to create controller for Accounts to access the correct pages from the login partial
    //Need to create folder for login 
}
