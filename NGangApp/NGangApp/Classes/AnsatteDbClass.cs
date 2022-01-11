using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace NGangApp.Classes
{
    public class AnsatteDbClass
    {
        [PrimaryKey, AutoIncrement]
        public int AnsatteId { get; set; }

        public string Navne { get; set; }

        public string Efternavne { get; set; }

        public string Email { get; set; }

        public string TlfNummer { get; set; }

        public string Loen { get; set; }

    }
}
