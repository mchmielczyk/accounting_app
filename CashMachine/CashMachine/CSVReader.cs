using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace CashMachine
{

    /// <summary>
    /// Checks person data from a CSV file.
    /// </summary>
    public class CSVReader : IDATAReader
    {
        private English _english;

        public CSVReader(English english)
        {
            _english = english;
        }
        public void Read(English english)
        {
            using (var reader = new StreamReader($"{_english._dataBasePath}"))
            {
                try
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');
                        try
                        {
                            _english.ID.Add(Int32.Parse(values[0]));
                        }
                        catch (Exception) { }
                        try
                        {
                            _english.Name.Add(values[1]);
                        }
                        catch (Exception) { }
                        try
                        {
                            _english.Surname.Add(values[2]);
                        }
                        catch (Exception) { }
                        try
                        {
                            _english.Login.Add(values[3]);
                        }
                        catch (Exception) { }
                        try
                        {
                            _english.Password.Add(values[4]);
                        }
                        catch (Exception) { }
                        try
                        {
                            _english.Money.Add(values[5]);
                        }
                        catch (Exception) { }
                    }
                    /*reader.Close();*/
                }
                catch (Exception e)
                {
                    // Log.Save(e.Message);

                    // Any form of non internet or connection to database security. 
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    reader.Close();
                }
            }
        }
    }
}