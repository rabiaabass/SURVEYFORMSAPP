﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SURVEYFORMSAPP.Models
{
    public class User
    {
        
        public string UserName { get; set; }

        public string UserSurname { get; set; }


        public User(string userName, string userSurname)
        {
            UserName = userName;
            UserSurname = userSurname;
        }
    }
}
