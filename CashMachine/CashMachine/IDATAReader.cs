using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    /// <summary>
    /// Interface between reading data methods from different data sources. 
    /// </summary>
    public interface IDATAReader
    {
        void Read(English english);
    }
}
