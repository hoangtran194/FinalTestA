﻿using System;
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

        //PRIVATE INSTANCE VARIABLES
        private string m_fighting;
        private string m_strength;
        private string m_agility;
        private string m_endurance;
        private string m_reason;
        private string m_intuition;
        private string m_psyche;
        private string m_popularity;

        //Identity
        public string HeroName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //PRIMARY ABILITIES

        //Physical abilities
        public string Fighting
        {
            get
            {
                return m_fighting;
            }
            set
            {
                this.m_fighting = value;
                Health += int.Parse(m_fighting);
            }
        }
        public string Strength
        {
            get
            {
                return m_strength;
            }
            set
            {
                this.m_strength = value;
                Health += int.Parse(m_strength);
            }
        }
        public string Agility
        {
            get
            {
                return m_agility;
            }
            set
            {
                this.m_agility = value;
                Health += int.Parse(m_agility);
            }
        }
        public string Endurance
        {
            get
            {
                return m_endurance;
            }
            set
            {
                this.m_endurance = value;
                Health += int.Parse(m_endurance);
            }
        }


        //Mental abilities
        public string Reason
        {
            get
            {
                return m_reason;
            }
            set
            {
                this.m_reason = value;
                Karma += int.Parse(m_reason);
            }
        }
        public string Intuition
        {
            get
            {
                return m_intuition;
            }
            set
            {
                this.m_intuition = value;
                Karma += int.Parse(m_intuition);
            }
        }
        public string Psyche
        {
            get
            {
                return m_psyche;
            }
            set
            {
                this.m_psyche = value;
                Karma += int.Parse(m_psyche);
            }
        }
        public string Popularity
        {
            get
            {
                return m_popularity;
            }
            set
            {
                this.m_popularity = value;
                Karma += int.Parse(m_popularity);
            }
        }


        //SECONDARY ABILITIES
        public int Health { get; set; }
        public int Karma { get; set; }

        //Power list
        public List<Power> Powers;

        public Hero()
        {
            //Instantiate an empty Power List
            Powers = new List<Power>();
        }

        //TODO
        public static Hero Parse(string stringToParse)
        {
            string[] values = stringToParse.Split('\t');
            Hero result = new Hero();

            result.Fighting     = values[0];
            result.Agility      = values[1];
            result.Strength     = values[2];
            result.Endurance    = values[3];

            result.Reason       = values[4];
            result.Intuition    = values[5];
            result.Psyche       = values[6];
            result.Popularity   = values[7];

            result.HeroName         = values[8];
            result.FirstName    = values[9];
            result.LastName     = values[10];

            return result;
        }
    }
}
