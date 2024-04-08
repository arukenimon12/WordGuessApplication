using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class Form1 : Form
    {

        private String word = "computer";
        private Random rand = new Random();
        private String[] words =
        {
            "Abacus",
            "Abyss",
            "Achieve",
            "Acoustic",
            "Admire",
            "Adventure",
            "Affair",
            "Agriculture",
            "Airplane",
            "Alchemist",
            "Algebra",
            "Algorithm",
            "Alligator",
            "Alphabet",
            "Amulet",
            "Anatomy",
            "Angel",
            "Anger",
            "Animal",
            "Anniversary",
            "Antenna",
            "Antique",
            "Apartment",
            "Apocalypse",
            "Apparel",
            "Appliance",
            "Aquarium",
            "Arboretum",
            "Architecture",
            "Arena",
            "Arithmetic",
            "Armchair",
            "Aroma",
            "Artichoke",
            "Asparagus",
            "Assemble",
            "Astronomy",
            "Athletic",
            "Atmosphere",
            "Attic",
            "Auction",
            "Audio",
            "Authentic",
            "Autograph",
            "Automobile",
            "Autumn",
            "Avalanche",
            "Avocado",
            "Award",
            "Baby",
            "Backpack",
            "Bacon",
            "Baggage",
            "Bailiff",
            "Baker",
            "Balcony",
            "Ballad",
            "Ballot",
            "Bamboo",
            "Banana",
            "Bandana",
            "Bandit",
            "Banker",
            "Banquet",
            "Barber",
            "Barefoot",
            "Bargain",
            "Barnacle",
            "Barricade",
            "Baseball",
            "Baseline",
            "Basketball",
            "Bathrobe",
            "Beach",
            "Beanbag",
            "Bear",
            "Beard",
            "Beast",
            "Beauty",
            "Bedspread",
            "Beefsteak",
            "Beeswax",
            "Beethoven",
            "Begonia",
            "Belladonna",
            "Belligerent",
            "Beltway",
            "Benevolent",
            "Beret",
            "Bermuda",
            "Berry",
            "Beryl",
            "Beverage",
            "Bible",
            "Bicycle",
            "Bigfoot",
            "Billboard",
            "Binocular",
            "Biography",
            "Biology"
        };

        private Timer timer = new Timer();
        
        void RandomQuestion()
        {
            word = words[rand.Next(0, words.Length - 1)];//YAWAcxz
        }
        string question = null;
        void Setup()
        {
            //RandomQuestion();
            question = "";
            for(int i = 0; i < word.Length; i++)
            {

                if(i!=0 && i!= word.Length - 1)
                {
                    question += "?";
                }
                else
                {
                    question += word.ToCharArray()[i].ToString();
                }

            }
            lblGuess.Text = question + "\n" + word;
        }

        public Form1()
        {
            InitializeComponent();

            Setup();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();


            if (txtGuess.Text.ToLower() != word.ToLower())
            {
                lbGuess.Items.Add(txtGuess.Text);
                MessageBox.Show("Wrong guess!\nTry again.");
            }
            else
            {

                timer.Interval = 3000;

                timer.Tick += (o, v) =>
                {
                    lblGuess.Text = question + "\n" + word;
                    timer.Stop();
                };
                lblGuess.Text = word;
                timer.Start();

                
                MessageBox.Show("Correct guess!");
                Setup();
            }

        }
        
        
        private void txtGuess_KeyDown(object sender, KeyEventArgs e)
        {
            
            /*if (e.KeyCode == Keys.D)
            {
                test = true;
            }

            if (e.KeyCode == Keys.Space)
            {

                fireBullet_ = true;
            }*/

        }

        private void txtGuess_KeyUp(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.D)
            {
                test = false;
            }
            if (e.KeyCode == Keys.Space)
            {

                fireBullet_ = false;
            }*/
        }
    }
}
