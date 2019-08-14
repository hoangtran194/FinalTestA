using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using FinalTestA.Controllers;
using FinalTestA.Objects;

/*
 * STUDENT NAME: Tran Huy Hoang
 * STUDENT ID: 300 979 272
 * DESCRIPTION: This is the Hero Generator Form
 */
namespace FinalTestA.Views
{
    public partial class HeroGenerator : FinalTestA.Views.MasterForm
    {


        

        public static List<string> FirstNameList;
        public static List<string> LastNameList;
        public static List<string> PowerList;

        public HeroGenerator()
        {
            InitializeComponent();
            LoadNames();
            GenerateNames();

            generateRandomAbility();

            LoadPowers();
            GenerateRandomPowers();

        }


        private void LoadPowers()
        {
           string powerFilePath = "../../Data/Power.txt";
           PowerList = Ultilities.LoadNames(powerFilePath);
        }

        private void LoadNames()
        {
            string firstNamePath = "../../Data/firstNames.txt";
            string lastNamePath = "../../Data/lastNames.txt";

            FirstNameList = Ultilities.LoadNames(firstNamePath);
            LastNameList = Ultilities.LoadNames(lastNamePath);
        }

        /// <summary>
        /// Next button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }


        /// <summary>
        /// Back button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        private void generateNameButton_Click(object sender, EventArgs e)
        {
            GenerateNames();

            Program.character.FirstName = firstNameDataLabel.Text;
            Program.character.LastName = lastNameDataLabel.Text;
            Program.character.HeroName = Program.character.FirstName + " " + Program.character.LastName;
        }

        private void GenerateNames()
        {

            int firstNameRandomIndex = Ultilities.randomNumber(0, FirstNameList.Count - 1);
            int lastNameRandomIndex = Ultilities.randomNumber(0, LastNameList.Count - 1);

            firstNameDataLabel.Text = FirstNameList[firstNameRandomIndex];
            lastNameDataLabel.Text = LastNameList[lastNameRandomIndex];
            heroNameTextBox.Text = FirstNameList[firstNameRandomIndex] + " " + LastNameList[lastNameRandomIndex];

            Program.character.FirstName = firstNameDataLabel.Text;
            Program.character.LastName = lastNameDataLabel.Text;
            Program.character.HeroName = heroNameTextBox.Text;
        }

        private void GenerateRandomPowers() {
            List<int> randomNumbers = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                randomNumbers.Add(Ultilities.randomNumber(0, PowerList.Count - 1));
            }

            power1DataLabel.Text = PowerList[randomNumbers[0]];
            power2DataLabel.Text = PowerList[randomNumbers[1]];
            power3DataLabel.Text = PowerList[randomNumbers[2]];
            power4DataLabel.Text = PowerList[randomNumbers[3]];

            Power power1 = new Power(power1DataLabel.Text, 1);
            Power power2 = new Power(power2DataLabel.Text, 2);
            Power power3 = new Power(power3DataLabel.Text, 3);
            Power power4 = new Power(power4DataLabel.Text, 4);

            Program.character.Powers = new List<Power>();
            Program.character.Powers.Add(power1);
            Program.character.Powers.Add(power2);
            Program.character.Powers.Add(power3);
            Program.character.Powers.Add(power4);

        }

        private void generatePowerButton_Click(object sender, EventArgs e)
        {

            
            GenerateRandomPowers();

        }

        private void generateAbilityButton_Click(object sender, EventArgs e)
        {
            generateRandomAbility();
        }

        private void generateRandomAbility()
        {
            List<int> abilities = new List<int>();
            List<Label> labels = new List<Label>();

            //8 Text field
            for (int i = 0; i < 8; i++)
            {
                abilities.Add(Ultilities.randomNumber(10, 50));
            }


            //8 Label
            labels.Add(fightingDataLabel);
            labels.Add(agilityDataLabel);
            labels.Add(strengthDataLabel);
            labels.Add(enduranceDataLabel);

            labels.Add(reasonDataLabel);
            labels.Add(intuitionDataLabel);
            labels.Add(psycheDataLabel);
            labels.Add(popularityDataLabel);

            for (int i = 0; i < abilities.Count; i++)
            {
                labels[i].Text = abilities[i].ToString();
            }

            Program.character.Fighting = fightingDataLabel.Text;
            Program.character.Agility = agilityDataLabel.Text;
            Program.character.Strength = strengthDataLabel.Text;

            Program.character.Endurance = enduranceDataLabel.Text;
            Program.character.Reason = reasonDataLabel.Text;
            Program.character.Intuition = intuitionDataLabel.Text;

            Program.character.Psyche = psycheDataLabel.Text;
            Program.character.Popularity = popularityDataLabel.Text;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDialog();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openDialog();
        }

        private void openDialog()
        {
            string filePath = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string CombinedPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\Results\\");
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                //openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                openFileDialog.InitialDirectory = System.IO.Path.GetFullPath(CombinedPath);


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    List<Hero> hero = Ultilities.ReadSerializedObjectFile<List<Hero>>(filePath);

                    //Save the hero to program
                    Program.character = hero[0];

                    //Write it into full label for all screen                    
                    updateLayout();
                }
            }       
        }

        //Update data from the character from program
        private void updateLayout()
        {

            Hero hero = Program.character;
            //Name tab
            firstNameDataLabel.Text = hero.FirstName;
            lastNameDataLabel.Text  = hero.LastName;
            heroNameTextBox.Text    = hero.HeroName;

            //Ability tab
            fightingDataLabel.Text  = hero.Fighting;
            agilityDataLabel.Text   = hero.Agility;
            strengthDataLabel.Text  = hero.Strength;

            enduranceDataLabel.Text = hero.Endurance;
            reasonDataLabel.Text    = hero.Reason;
            intuitionDataLabel.Text = hero.Intuition;

            psycheDataLabel.Text        = hero.Psyche;
            popularityDataLabel.Text    = hero.Popularity;


            //Power tab
            power1DataLabel.Text = hero.Powers[0].Name;
            power2DataLabel.Text = hero.Powers[1].Name;
            power3DataLabel.Text = hero.Powers[2].Name;
            power4DataLabel.Text = hero.Powers[3].Name;


            //Character sheet
            CSFirstNameDataLabel.Text   = hero.FirstName;
            CSLastNameDataLabel.Text    = hero.LastName;
            CSHeroNameDataLabel.Text    = hero.HeroName;

            CSAbilitiesDataLabel.Text   = makeHeroAbilitiesString();
            CSPowerDataLabel.Text       = makeHeroPowerString();


        }


        //Create an array object and save it into files with Serialize Object
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveFile()
        {
            List<Hero> heroes = new List<Hero>();
            heroes.Add(Program.character);
            string CombinedPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\Results\\Henry.txt");
            Ultilities.WriteSerialObjectToFile(CombinedPath, heroes);
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            showAboutBox();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showAboutBox();
        }

        private void showAboutBox() {
            Program.aboutBoxForm.ShowDialog();
        }

        private string makeHeroAbilitiesString() {
            string result = "";
            Hero hero = Program.character;

            result += "Fighting " + hero.Fighting;
            result += "Strength " + hero.Strength;
            result += "Agility " + hero.Agility;
            result += "Endurance " + hero.Endurance;

            result += "Reason " + hero.Reason;
            result += "Intuition " + hero.Intuition;
            result += "Psyche " + hero.Psyche;
            result += "Popularity " + hero.Popularity;

            return result;
        }

        private string makeHeroPowerString()
        {
            string result = "";
            Hero hero = Program.character;

            foreach (Power power in hero.Powers)
            {
                result += power.Name + " ";
            }

            return result;
        }



        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl control = sender as TabControl;
            //Load the data into form
            if (control.SelectedIndex == 3)
            {
                CSFirstNameDataLabel.Text = Program.character.FirstName;
                CSLastNameDataLabel.Text = Program.character.LastName;
                CSHeroNameDataLabel.Text = Program.character.HeroName;



                CSAbilitiesDataLabel.Text = makeHeroAbilitiesString();
                CSPowerDataLabel.Text = makeHeroPowerString();


            }
        }
    }
}
