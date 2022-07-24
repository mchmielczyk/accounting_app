using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    /// <summary>
    /// Checks person data from a MySQL file.
    /// </summary>
    public class MYSQLReader : IDATAReader
    {
        private English _english;

        public MYSQLReader(English english)
        {
            _english = english;
        }
        public bool MYSQLConn()
        {
            return false;//No connection placeholder
        }
        public void Read(English english)
        {
            // MYSQL connection
        }
    }
}
