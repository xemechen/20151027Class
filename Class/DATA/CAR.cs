using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary.DATA
{
    public class CAR
    {

        private string name;
        private int year;

        public void SetName(string name)
        {
            this.name=name;
        }


        public void SetYear(int year)
        {if (year >= 2015)
                this.year = 2015;
            else if (year <= 1850)
                this.year = 1850;
            else
                this.year = year;}


        public string GetName()
        {
        return this.name;
        }


        public int GetYear()
        {
            return this.year;
        }



        public int Year
        {
            get { return this.year; }

            set
            {
                if (value >= 2015)
                    this.year = 2015;
                else if (value <= 1850)
                    this.year = 1850;
                else
                    this.year = value;
            }
        }
            
    }
}
