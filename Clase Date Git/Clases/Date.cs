using Clase_Date.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Date.Clases
{
    internal class Date
    {
        private int _day;
        private int _month;  
        private int _year;

        public Date(int day, int month, int year)
        {
            _day = checkDay(day,month,year);
            _month = CheckMonth( month);
            _year = year;
        }

        public override string ToString()
        {
            return $"{_day:00} / {_month:00} // {_year:00} "; 
        }

        public int CheckMonth(int month) 
        {
            if (month>= 1  && month<=12)
            {
                return month;

            }
            

            throw new InvalidMonth("invalid Month");
            
        }

        public int checkDay( int day,int month , int year)
        {
            int[] months = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] montsTotal = {1,2,3,4,5,6,7,8,9,10,11,12 };

           
                if (month == 2 && day == 29 && leapYear(year))
                {
                    return day;
                }

                if (day >= 1 && day <= months[month])
                {
                    return day;
                }

                if (true)
                {

                }

                throw new InvalidDay("invalid day");                

        }

        private bool leapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
            
          


           
        }


    }
}
