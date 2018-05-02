using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            // string _time = "07:05:45PM";

            string _time = Console.ReadLine();
            string _returntime = string.Empty;

            _returntime = timeConversion(_time, _returntime);   // return _returntime;
            // Console.WriteLine(_returntime);
        }

        private static string timeConversion(string _time, string _returntime)
        {
            if (_time == "12:00:00AM")
            {
                _returntime = "00:00:00";
                Console.WriteLine(_returntime);// for AM
            }
            else if (_time == "12:00:00PM")
            {
                _returntime = "12:00:00";
                Console.WriteLine(_returntime);
            }
            else if (_time.Contains("AM"))
            {
                string _h = _time.Split(':')[0];
                if (int.Parse(_h) == 12)
                {
                    _returntime = (("00") + ":" + _time.Split(':')[1] + ":" + _time.Split(':')[2]).Replace("AM", string.Empty);
                    Console.WriteLine(_returntime);
                }
                else
                {
                    _returntime = _time.Replace("AM", string.Empty);
                    Console.WriteLine(_returntime);
                }
            }
            else if (_time.Contains("PM"))
            {
                string _h = _time.Split(':')[0];
                if (int.Parse(_h) < 12)
                {
                    _returntime = (Convert.ToString(int.Parse(_h) + 12) + ":" + _time.Split(':')[1] + ":" + _time.Split(':')[2]).Replace("PM",string.Empty);
                    Console.WriteLine(_returntime);
                }
                if (int.Parse(_h) == 12)
                {
                    _returntime = ((_h) + ":" + _time.Split(':')[1] + ":" + _time.Split(':')[2]).Replace("PM", string.Empty);
                    Console.WriteLine(_returntime);
                }
            }
            Console.ReadKey();

            return _returntime;
        }

 
    }
}
