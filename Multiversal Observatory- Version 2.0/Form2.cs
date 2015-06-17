using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiversal_Observatory__Version_2._0
{
    public partial class Form2 : Form
    {
        public class Earth
        {
            public string EarthName { get; set; } 
            public string EarthDescription { get; set; }
            public Earth(string earthName, string earthDescription)
            {
                EarthName = earthName;
                EarthDescription = earthDescription;
            }
        }

        List<Earth> multiverse = new List<Earth>();
        
        public void createMultiverse()
        {
            //note: Form2 displays pre-Flashpoint multiverse
            //todo: "trim the fat" and remove any universes without substantial information

            Earth earth1 = new Earth("Earth-1", "primary Earth; contains Justice League of America");
            multiverse.Add(earth1);

            Earth earth2 = new Earth("Earth-2", "contains Justice Society Infinity");
            multiverse.Add(earth2);

            Earth earth3 = new Earth("Earth-3", "contains Crime Society");
            multiverse.Add(earth3);

            Earth earth4 = new Earth("Earth-4", "Charleton Comics universe; contains Blue Beetle, Question, and Captain Atom");
            multiverse.Add(earth4);

            Earth earth5 = new Earth("Earth-5", "Fawcett Comics universe; contains Marvel Family");
            multiverse.Add(earth5);

            Earth earth6 = new Earth("Earth-6", "contains Marvel Comics analogues");
            multiverse.Add(earth6);

            Earth earth7 = new Earth("Earth-7", "contains Courtney Whitmore/Starwoman");
            multiverse.Add(earth7);

            Earth earth8 = new Earth("Earth-8", "contains Lord Havok and the Extremists");
            multiverse.Add(earth8);

            Earth earth9 = new Earth("Earth-9", "Tangent Comics universe");
            multiverse.Add(earth9);

            Earth earth10 = new Earth("Earth-10", "contains Freedom Fighters and Overman");
            multiverse.Add(earth10);

            Earth earth11 = new Earth("Earth-11", "reversed-gender universe");
            multiverse.Add(earth11);

            Earth earth12 = new Earth("Earth-12", "Batman Beyond universe");
            multiverse.Add(earth12);

            Earth earth13 = new Earth("Earth-13", "dark/arcane universe");
            multiverse.Add(earth13);

            Earth earth15 = new Earth("Earth-15", "utopian world destroyed by Superboy Prime");
            multiverse.Add(earth15);

            Earth earth16 = new Earth("Earth-16", "Young Justice universe");
            multiverse.Add(earth16);

            //todo: continue adding Earths
            
            multiversalOrrery.Text = "LIST OF EARTHS:";
            for (int i = 0; i < multiverse.Count; i++)
            {
                multiversalOrrery.Text += "\n" + multiverse[i].EarthName;
            }
        }
        
        
        public Form2()
        {
            InitializeComponent();
            createMultiverse();
        }

        private void goTo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < multiverse.Count; i++)
            {
                if (multiverse[i].EarthName == multiversalDesignate.Text)
                {
                    earthDescription.Text = multiverse[i].EarthDescription;
                }
            }
        }

        private void viewScreen_Click(object sender, EventArgs e)
        {
            // will eventually lead to third Multiverse form
        }
    }
}
