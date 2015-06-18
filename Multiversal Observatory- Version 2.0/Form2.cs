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
            // todo: declare public Image EarthView { get; set; }
            public string EarthDescription { get; set; }
            public Earth(string earthName, string earthDescription) //todo: add argument string earthView
            {
                EarthName = earthName;
                //EarthView = earthView;
                EarthDescription = earthDescription;
            }
        }

        List<Earth> multiverse = new List<Earth>();
        
        public void createMultiverse()
        {
            //note: Form2 displays pre-Flashpoint multiverse
            //todo: update descriptions
            //todo: "trim the fat" and remove any universes without substantial information

            Earth earth0 = new Earth("Earth-0", "New Earth; contains Justice League of America");
            multiverse.Add(earth0);
            
            Earth earth1 = new Earth("Earth-1", "Earth One universe");
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

            Earth earth17 = new Earth("Earth-17", "contains Atomic Knights and Superdemon");
            multiverse.Add(earth17);
            
            Earth earth18 = new Earth("Earth-18", "contains Justice Riders");
            multiverse.Add(earth18);
            
            Earth earth19 = new Earth("Earth-19", "Gotham by Gaslight universe");
            multiverse.Add(earth19);
            
            Earth earth20 = new Earth("Earth-20", "contains Society of Superheroes");
            multiverse.Add(earth20);
            
            Earth earth21 = new Earth("Earth-21", "New Frontier universe");
            multiverse.Add(earth21);
            
            Earth earth22 = new Earth("Earth-22", "Kingdom Come universe");
            multiverse.Add(earth22);
            
            Earth earth26 = new Earth("Earth-26", "contains Captain Carrot and Zoo Crew");
            multiverse.Add(earth26);
            
            Earth earth30 = new Earth("Earth-30", "Red Son universe");
            multiverse.Add(earth30);
            
            Earth earth31 = new Earth("Earth-31", "TDKR/TDKSA universe");
            multiverse.Add(earth31);
            
            Earth earth32 = new Earth("Earth-32", "In Darkest Night universe; contains Bat-Lantern");
            multiverse.Add(earth32);
            
            Earth earth33 = new Earth("Earth-33", "contains Bat-Mage and Oracle");
            multiverse.Add(earth33);
            
            Earth earth34 = new Earth("Earth-34", "Amazonia universe");
            multiverse.Add(earth34);
            
            Earth earth37 = new Earth("Earth-37", "Thrillkiller universe");
            multiverse.Add(earth37);
            
            Earth earth38 = new Earth("Earth-38", "contains Captain Atom and Atomic Knights");
            multiverse.Add(earth38);
            
            Earth earth39 = new Earth("Earth-39", "contains Dan Gerrett");
            multiverse.Add(earth39);
            
            Earth earth40 = new Earth("Earth-40", "Liberty Files universe");
            multiverse.Add(earth40);
            
            Earth earth43 = new Earth("Earth-43", "Red Rain universe");
            multiverse.Add(earth43);
            
            Earth earth44 = new Earth("Earth-44", "contains Doc Tornado and Metal Men");
            multiverse.Add(earth44);
            
            Earth earth48 = new Earth("Earth-48", "War World universe; contains Forerunners");
            multiverse.Add(earth48);
            
            Earth earth50 = new Earth("Earth-50", "Wildstorm universe");
            multiverse.Add(earth50);
            
            Earth earth51 = new Earth("Earth-51", "destroyed by Superman-Prime");
            multiverse.Add(earth51);
            
            multiversalOrrery.Text = "\bList of Earths:\b0";
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
            // will eventually lead to third Multiverse form... pre-Crisis confirmed for v3.0?
        }
    }
}
