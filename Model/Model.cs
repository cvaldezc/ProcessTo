using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Model
{
    public class Model
    {

        public static DataTable dtGlobal;

        public static DataTable dtSX;

        public static DataTable dtSY;

        public static void ìnit()
        {
            dtGlobal = new DataTable("GLOBAL");
            dtGlobal.Columns.Add("story", typeof(String));
            dtGlobal.Columns.Add("joint", typeof(String));
            dtGlobal.Columns.Add("dead", typeof(Double));
            dtGlobal.Columns.Add("live", typeof(Double));
            dtGlobal.Columns.Add("fzx", typeof(Double));
            dtGlobal.Columns.Add("fzy", typeof(Double));
            dtGlobal.Columns.Add("sv", typeof(Double));
            dtGlobal.Columns.Add("pdsx", typeof(Double));
            dtGlobal.Columns.Add("pdsy", typeof(Double));

            dtSX = new DataTable("SX");

            dtSY = new DataTable("SY");
        }

    }
}
