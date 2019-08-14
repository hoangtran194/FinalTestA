using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
* STUDENT NAME: Tran Huy Hoang
* STUDENT ID: 300 979 272
* DESCRIPTION: This is the Power class 
*/
namespace FinalTestA.Objects
{
    class Power
    {
        //Public Properties
        public string Name { get; set; }
        public int Number { get; set; }

        public Power(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public Power()
        {
        }

        public static Power Parse(string stringToParse)
        {
            string[] values = stringToParse.Split('\t');
            Power result = new Power(values[0], Convert.ToInt32(values[1]));
            return result;
        }
    }
}
