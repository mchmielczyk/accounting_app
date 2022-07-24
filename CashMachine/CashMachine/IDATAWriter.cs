using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    /// <summary>
    /// Interface between writing data methods to different data storage destinations. 
    /// </summary>
    public interface IDATAWriter
    {
        void Writer(English english);
    }
}
