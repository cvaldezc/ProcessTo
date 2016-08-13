using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller.Interfaces
{
    public interface IWriteStaadPROable
    {

        void processAisladoSTD();

        void processNoAisladoSTD();

        StringBuilder readFile();
    }
}
