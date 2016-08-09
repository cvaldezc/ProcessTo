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

        public static void init()
        {
            // Datos de tabla Global
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
            dtGlobal.Columns.Add("fx", typeof(Double));
            dtGlobal.Columns.Add("fy", typeof(Double));


            // Datos de tabla SX
            dtSX = new DataTable("SX");
            dtSX.Columns.Add("story", typeof(String));
            dtSX.Columns.Add("joint", typeof(String));
            dtSX.Columns.Add("combo", typeof(String));
            dtSX.Columns.Add("fx", typeof(Double));
            dtSX.Columns.Add("fz", typeof(Double));
            dtSX.Columns.Add("my", typeof(Double));

            // Datos de tabla SY
            dtSY = new DataTable("SY");
            dtSY.Columns.Add("story", typeof(String));
            dtSY.Columns.Add("joint", typeof(String));
            dtSY.Columns.Add("combo", typeof(String));
            dtSY.Columns.Add("fy", typeof(Double));
            dtSY.Columns.Add("fz", typeof(Double));
            dtSY.Columns.Add("mx", typeof(Double));
        }

    }
}
