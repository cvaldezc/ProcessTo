using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Model
{
    public class MDStaadPRO
    {

        public static DataTable dtGlobal;

        public static void init()
        {
            dtGlobal = new DataTable("GLOBAL");
            dtGlobal.Columns.Add("nodo", typeof(string));
            dtGlobal.Columns.Add("sv", typeof(double));
            dtGlobal.Columns.Add("cm", typeof(double));
            dtGlobal.Columns.Add("cv", typeof(double));
            dtGlobal.Columns.Add("csx", typeof(double));
            dtGlobal.Columns.Add("csz", typeof(double));
            dtGlobal.Columns.Add("csxv", typeof(double));
            dtGlobal.Columns.Add("cszv", typeof(double));
            dtGlobal.Columns.Add("pdsx", typeof(double));
            dtGlobal.Columns.Add("pdsz", typeof(double));
            dtGlobal.Columns.Add("pdsxa", typeof(double));
            dtGlobal.Columns.Add("pdsza", typeof(double));
        }

    }
}
