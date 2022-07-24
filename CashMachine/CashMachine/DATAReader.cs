using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    /// <summary>
    /// Checks person data to aprove ownership of the account.
    /// </summary>
    public class DATAReader
    {
        private English _english;
        private IDATAReader _idatareader;
        public DATAReader(IDATAReader DataReader)
        {
            this._idatareader = DataReader;
        }

        public DATAReader(English english, IDATAReader DataReader)
        {
            _english = english;
            _idatareader = DataReader;
        }
        public void Read()
        {
            _idatareader.Read(_english);
        }


    }
}
