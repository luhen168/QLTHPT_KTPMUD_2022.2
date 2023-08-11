using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QLTHPT_KTPMUD_2022._2
{

    public class DatabaseConnection
    {
        private static DatabaseConnection instance;
        private string connectionString;
        private DatabaseConnection()
        {

            connectionString = "Data Source=DESKTOP-96D4EUK\\SQLEXPRESS;Initial Catalog=QLTHPT_20222;Integrated Security=True";

        }
        public static DatabaseConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseConnection();
                }
                return instance;
            }
        }
        public string ConnectionString
        {
            get { return connectionString; }
        }

    }
}
