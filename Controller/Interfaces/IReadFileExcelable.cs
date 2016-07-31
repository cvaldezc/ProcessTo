using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller.Interfaces
{
    public interface IReadFileExcelable
    {

        void selectSheet(String name);

        /// <summary>
        /// procedimiento que se encarga leer el formato de excel
        /// y llenar los datos a los dataset
        /// </summary>
        void readETabs(String story);

        void calcFormulas(Double delta, Double cm, String story);

        void close();

    }
}
