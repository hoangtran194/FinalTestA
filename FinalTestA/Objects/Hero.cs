using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * STUDENT NAME: Tran Huy Hoang
 * STUDENT ID: 300 979 272
 * DESCRIPTION: This is the Hero Data Container class 
 */
namespace FinalTestA.Objects
{
    class Hero
    {
        //Identity
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Physical abilities
        public string Fighting { get; set; }
        public string Strength { get; set; }
        public string Agility { get; set; }
        public string Endurance { get; set; }

        
        //Mental abilities
        public string Reason { get; set; }
        public string Intuition { get; set; }
        public string Psyche { get; set; }
        public string Popularity { get; set; }


        //Power list
        List<Power> Powers;

        Hero()
        {
            //Instantiate an empty Power List
            Powers = new List<Power>();

        }

    }
}
