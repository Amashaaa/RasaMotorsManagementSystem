﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasaMotorsManagementSystem.Common
{
    class Utils
    {
        private static string connectionString = "Data Source=PASAN;Initial Catalog=ServiceCenterManagementDatabase;Integrated Security=True";
        //private static string connectionString = @"Data Source=CHARMINPC\SQLEXPRESS;Initial Catalog=ServiceCenterManagementDB;Integrated Security=True";

        public static string ConnectionString
        {
            get
            {
                return connectionString;
            }
            set
            {
                connectionString = value;
            }
        }
    }

}

