using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
namespace CashMachine { 
public class CSVWriter: IDATAWriter 
{
    private English _english;
	public CSVWriter(English english)
	{
        _english = english;
	}
    public void Writer(English english)
    {
        /*StringBuilder csv = new StringBuilder();
        csv.Append($"{Name},{Surname},{Login},{Password},{Money}");
        csv.AppendLine();*/
        using (FileStream fs = new FileStream(_english._dataBasePath, FileMode.Open, FileAccess.Write))
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_english.@_dataBasePath, false))
                {
                    try
                    {
                        sw.WriteLine($"{_english.ID},{_english.Name},{_english.Surname},{_english.Login},{_english.Password},{_english.Money}");
                    }
                    catch (Exception ex)
                    {
                        throw new AggregateException("Program has stuck upon an unexpected problem:", ex);
                    }
                    finally
                    {
                        if (sw != null)
                            sw.Dispose();
                    }
                }
            }
            catch
            {

            }

        }
    }
}
}