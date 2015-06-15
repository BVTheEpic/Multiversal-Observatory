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
    public partial class Form1 : Form
    {
        public class Earth
        {
            public Image EarthView { get; set; }
            public string EarthDescription { get; set; }
            public Earth(Image earthView, string earthDescription)
            {
                EarthView = earthView;
                EarthDescription = earthDescription;
            }
        }

        Earth[] multiverse = new Earth[52];
        int multiversalDesignate = 0;
        bool doubleDigits = false;

        public void createMultiverse()
        {
            multiverse[0] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._00, "Earth-0, also known as New Earth, is the foundation stone of the Multiversal structure. It has survived several attacks, surgeries, and reconstructions, on the way to its current form. On Earth-0, the greatest young superheroes of the age are at the peak and pinnacle of their powers and achievements.");
            multiverse[1] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._01, "This freshly created universe is still cooling and as yet unformed. Earth-1's known superbeings- Superman, Batman, Wonder Woman, and the Teen Titans- are at the beginning of their careers. Time and space are still pliable, and nothing here is certain.");
            multiverse[2] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._02, "Following the deaths of Superman, Batman, and Wonder Woman in the war with the Great and Terrible Darkseid, a new generation of superheroes has emerged to continue the fight against immortal evil. This world includes a new Batman and Superman, Red Tornado, Doctor Fate, Flash, Green Lantern, Hawkgirl, Huntress, and Power Girl.");
            multiverse[3] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._03, "This world is home to the villainous, despotic Crime Syndicate of America, including their leader, the tyrant Ultraman, and his cohorts Johnny Quick, Power Ring, Deathstorm, and Atomica- the world's great super-criminals in this universe, where good and evil are reversed.");
            multiverse[4] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._04, "Earth-4's only superhuman being is Captain Allen Adam, endowed with quantum senses following close-quarters interactions with an unstable neo-element known as U-235. The Pax Americana is a group of specialized, uniformed, peacekeeping operatives including Peacemaker, Blue Beetle, and Nightshade. The Question of this world is a rogue crimebuster.");
            multiverse[5] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._05, "Known throughout the Multiverse as Thunderworld, this universe is the home of the Marvel Family paragons, their friends, and their foes. Captain Marvel, Captain Marvel Jr., Mary Marvel, and the Lieutenant Marvels fight an eternal battle to protect their world from monsters, aliens, and the machinations of the power-mad genius Doctor Sivana.");
            multiverse[6] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._06, "The happening home of Aquaman, Sandman, Batman, Green Lantern, and other familiar names, given new and unfamiliar stories! On this world, Superman is a castaway cosmic cop from the planet Krypton. Wonder Woman wields the senses-sundering celestial staff of Manco Capac, the Inca Sun God; while the glistening Green Lantern channels the peerless power of the wonderous World Tree Yggdrasil against the villainous Reverend Darrk!");
            multiverse[7] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._07, "On this world, the history of Earth-8 was recreated with subtle differences. In spite of its innovations and the protection of heroes like Crusader, Golem, Doc Future, Walkure, Devilfist, and Microbot, Earth-7 was targeted and destroyed by the rapacious demons of the Gentry as part of their first incursion into the Multiverse. The sole survivor of Earth-7 is Thunderer, an incarnate storm god.");
            multiverse[8] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._08, "On this world, great power comes with great responsibility, and heroes often pay a high price for their dedication to justice. Earth-8 is home to the battlin' Bug, Stuntmaster, the bestial Behemoth, Hyperius, and Major Max. Prominent hero teams include the Future Family, the neo-human G-Men (short for Geno-), and the Retaliators- Deadeye, Ladybug, Kite, Wundajin, American Crusader, Red Dragon, and Machinehead.");
            multiverse[9] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._09, "Here, Superman is a human being of vast intellect and mental power, while the Atom takes his place as Earth's foremost hero. Here, the light-powered Flash is the first baby born in space. Here, Green Lantern can resurrect the dead. Here, Joker is an anarchist prankster on the side of freedom, and Batman is a time-lost armored spirit seeking justice throughout eternity.");
            multiverse[10] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._10, "Also designated Earth-X, history was altered here when the rocket carrying the infant super-being Kal-L of Krypton landed in Nazi-occupied Czechoslovakia in 1938. Eighty years after assuring a German victory in World War II, the troubled Overman leads Leatherwing, Brunhilde, Blitzen, Underwaterman, and others as the New Reichsmen in their war against Uncle Sam and his terrorist Freedom Fighters- the Ray, Black Condor, the Human Bomb, Phantom Lady, Doll Man, and Doll Woman.");
            multiverse[11] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._11, "On Earth-11, the Amazons of Themyscira imposed their law on the whole world and changed it forever with new technology and philosophies, inspiring generations of women to take the lead in creating the future. This world's Justice Guild comprises Wonderous Man, Aquawoman, Batwoman, Superwoman, Jesse Quick, Star Sapphire, Power Man, and Zatara!");
            multiverse[12] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._12, "With a timeline running slightly in advance of Earth-0, this is the near future world of Batman's successor Terry McGinnis and his Justice League Beyond allies- Green Lantern, Superman, Warhawk, Aquagirl, Big Barda, Micron, and others. Together, they face the threats of an untamed future reality!");
            multiverse[13] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._13, "On this world of permanent magical twilight, every day has thirteen hours and each year has thirteen months. Here, Etrigan the Demon, rocketed to Earth from the doomed planet Kamelot, fights evil in Merlin's name as Superdemon! Fellow members of the League of Shadows include Hellblazer, Annataz, Witchboy, Swamp-Man, Fate, Ragman, Deadman, and Enchantress.");
            multiverse[14] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._14_24_25_27_28_46_49, "This world is one of seven unknown worlds created by an Inner Chamber of seven Monitor Magi. The mysterious purpose of this world, as well as this world itself, is yet to be revealed.");
            multiverse[15] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._15, "The so-called Perfect Universe was destroyed during a rampage by the deranged and so-called Superboy-Prime, during which billions of fictional lives were lost and the delicate structure of spacetime itself was irreparably damaged. A solitary, immensely powerful fragment of this universe- known as the Cosmic Grail- is said to be hidden somewhere among the many worlds of the Multiverse.");
            multiverse[16] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._16, "Earth-Me- home of the Just- a world where peace, prosperity, and boredom reign supreme. Here, the super-sons of Batman and Superman are joined by others of a pampered second generation of superheroes, like Sister Miracle, Arrowette, Megamorpho, and Offspring. While the older heroes of the Justice League indulge in nostalgic battle reenactments, the young live meaningless, self-absorbed lives.");
            multiverse[17] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._17, "Captain Adam Strange leads his Atomic Knights of Justice on a desperate, last-chance quest to preserve the remnants of humanity fifty years after a nuclear war in 1963. Facing monstrous mutations, mad science, and human heartbreak on the way to rebuilding the ruined world of 21st century Novamerika, they seek the Cosmic Grail- the only weapon that will defend against the coming threat of Darkseid the destroyer.");
            multiverse[18] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._18, "Led by Saganowana the Superchief, the Justice Riders are Bat-Lash, Madame .44, Strongbow, El Diablo, Cinnamon, the Trigger Twins, Firehair, Tomahawkman, Johnny Thunder, and Pow-Wow Smith. They are sworn to protect a frontier world where the meddling Time Trapper froze technology and culture in the late 19th century. Here, human ingenuity has used the available resources of the 19th century to create everything humans take for granted in the 21st century, including a telegraph internet and air travel.");
            multiverse[19] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._19, "Queen Victoria is dead. King Edward rules a 20th-century empire of new electric technology in a rapidly changing social landscape. Into this Modernist ferment, this world of new ideas and new futures, the superhumans have arrived! The Bat Man, the Accelerated Man, the Wonder Woman, the Shrinking Man, and others face unexpected challenges as history takes a twisted turn!");
            multiverse[20] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._20, "Home to the Society of Superheroes, a team of adventurers and science champions assembled by Doc Fate to include Green Lantern, the mighty Atom, Immortal Man, Lady Blackhawk, and the Blackhawks. Earth-20 occupies a binary universe, which tunes itself to occupy the same space as Earth-40 once every 100,000 years, with catastrophic consequences.");
            multiverse[21] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._21, "Here, a never-assassinated President John F. Kennedy stands forever poised to lead a newly superhuman, turned-on nation to the stars, while the indomitable young science heroes and pioneers of the Justice League of America fight to protect their ideals against threats from this world- and others.");
            multiverse[22] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._22, "In contrast to next-door Earth-21 is an older world where the next generation of superheroes ran wild. Here, Kansas was destroyed and civilization was brought to the brink of apocalypse before the timely return of a retired Superman.");
            multiverse[23] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._23, "The arrival on Earth of Kal-L of Krypton- this world's Superman- was the catalyst for a generation of superheroes, including Nubia the Wonder Woman, Green Lantern, Vixen, Steel, Mister Miracle, Black Lightning, Steel, and Amazing Man. In his alter ego of Calvin Ellis, Superman is the President of the United States of America.");
            multiverse[24] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._14_24_25_27_28_46_49, "This world is one of seven unknown worlds created by an Inner Chamber of seven Monitor Magi. The mysterious purpose of this world, as well as this world itself, is yet to be revealed.");
            multiverse[25] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._14_24_25_27_28_46_49, "This world is one of seven unknown worlds created by an Inner Chamber of seven Monitor Magi. The mysterious purpose of this world, as well as this world itself, is yet to be revealed.");
            multiverse[26] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._26, "Earth-26 was briefly destroyed, but the so-called cartoon physics governing this world permits the inhabitants of Earth-26 to survive almost any known physical assault. In his superheroic guise as Captain Carrot, comic book writer/artist Rodney Rabbit leads Fastback, American Eagle, Rubberduck, Yankee Poodle, Pig-Iron, Alley-Kat-Abra, and Little Cheese- A.K.A. the Zoo Crew.");
            multiverse[27] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._14_24_25_27_28_46_49, "This world is one of seven unknown worlds created by an Inner Chamber of seven Monitor Magi. The mysterious purpose of this world, as well as this world itself, is yet to be revealed.");
            multiverse[28] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._14_24_25_27_28_46_49, "This world is one of seven unknown worlds created by an Inner Chamber of seven Monitor Magi. The mysterious purpose of this world, as well as this world itself, is yet to be revealed.");
            multiverse[29] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._29, "The square planet Htrae dominates Bizarroverse, a broken continuum with damaged laws of physics. Bizarro-Superman leads his Unjustice League of Unamerica on pointless, inexplicable, and utterly futile adventures. The Bizarroverse is crowded with many nearby planets, including Nnar, home of Adam Familiar; the overpopulated Sram, birthplace of the green Sramian Snitch; Raganaht, homeplanet of the flightless Bizarro Manhawk; Ao of the Dismissers of the Universe; etc.");
            multiverse[30] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._30, "World of the Soviet Superman, where Kal-L's rocket crash-landed on a Russian collective farm, resulting in a Communist Superman. On Earth-30, Batman was a terrorist freedom fighter. Green Lantern and Bizarro were American superweapons. Following the apparent death of Superman, this world prospered under the guidance of the Luthor family.");
            multiverse[31] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._31, "Global warming, mega-tsunamis, and tectonic shifts have created a post-apocalyptic drowned world. Captain Leatherwing and the crew of the Flying Fox- including Robin Redblade, fight to preserve the safety of the Seven Seas.");
            multiverse[32] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._32, "Here, Bruce Wayne is Earth's Green Lantern and fights evil as Bat-Lantern alongside Black Arrow, Wonderhawk, Aquaflash, Super-Martian, and other members of the Justice Titans.");
            multiverse[33] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._33, "Known also as Earth-Prime, this mysterious world without superheroes exerts a powerful and unknown influence on the progress and development of the entire Multiverse. Monitor conjecture suggests that ideas created by ordinary human minds on Earth-Prime become realities on other worlds of the Multiversal Orrery structure. Earth-Prime's only known superhuman inhabitant is known as Ultra Comics. That's him there...");
            multiverse[34] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._34, "One of numerous superheroes based in the city of Cosmoville, Savior was the last survivor of the ancient super-civilization of Mu. Sent into the future to escape a doomed past, he inaugurated the Light Brigade along wiith Herculina, Radman, Goodfellow, Formula-1, Ghostman, Master Motley, Cutie, the Stingray, and many others.");
            multiverse[35] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._35, "Supremo is the greatest hero of Earth-35, an artificial universe constructed by Monitor ideominers operating from harvesting stations in Earth-35 concept space. Supremo is a proud member of the Super-Americans, alongside heroes including Starcop, Mercury-Man, Miss X, Majesty, Olympian, and the Owl.");
            multiverse[36] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._36, "The homeworld of Justice 9, where the alien Optiman fought bravely alongside such heroes as Flashlight, Cyberion, War-Woman, Mer-Man, Blackbird, Bowboy, Iron Knight, Red Racer, and more. Optiman was apparently killed by the Earth-45 monster Superdoomsday.");
            multiverse[37] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._37, "A world of lawless heroes and cynical champions. On Earth-37, technology accelerated through the 1960s, 1970s, and 1980s. The beat cellars of the 1950s gave way to the underground Mars base colonies of the 1980s; the Europa bases of the 1990s; and then to the interstellar world of Tommy Tomorrow, Manhunter 2015, and the Space Rangers.");
            multiverse[38] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._38, "Here, Superman and Batman first appeared in the 1930s, aging normally as their children inherited a world of wonder and tragedy, where heroes and heroines alike carry the heroic baton into an unknown future.");
            multiverse[39] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._39, "Home to the Agents of W.O.N.D.E.R., an organization of United Nations super-spies- Cyclotron, Doctor Nemo, Corvus, Accelerator, and Psi-Man- each equipped with an item of miracle technology designed by visionary boy genius Happy DaVinci- the Cyclo-Harness, the Accelerator Circuit, the Ghost Chamber, the LightWing, and the Cypher Suit. Repeated use of this technology might be addictive and ruinous.");
            multiverse[40] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._40, "A binary universe resonating in catastrophic harmony with Earth-20, of which it is the evil reflex. Earth-40 is home to the Society of Supercriminals, including Doc Faust, Vandal Savage, Lady Shiva, Blockbuster, and Parallax the Fear-Thing.");
            multiverse[41] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._41, "A dark and violent world. Home of the necro-floral avenger Spore, gruff Dino-Cop, Nimrod Squad, Nightcracker, the Scorpion, and Sepulchre.");
            multiverse[42] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._42, "The tiny inhabitants of Earth-42 knew nothing of mortality, evil, or violence until the death of their Superman at the hands of the Earth-45 monster Superdoomsday- but their world hides a great and terrible secret.");
            multiverse[43] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._43, "A world of darkness and fear where super-vampires rule the night as the Blood League.");
            multiverse[44] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._44, "The home of world-changing superhero A.I.s designed and built by the brilliant, bipolar Doctor Will Tornado. Tornado built the superheroes because 'there was no one to save the world.' The Metal League comprises Gold Superman, Iron Batman, Platinum Wonder Woman, Mercury Flash, Nth Metal Hawkman, Tin Elongated Man, and Lead Green Arrow.");
            multiverse[45] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._45, "On this world, there were no superhuman beings until Superman(TM) was created by Clark Kent, Lois Lane, and Jimmy Olsen using incredible new thought-powered technology. Co-opted by the business mavens of Overcorp, Superman was redesigned as a monstrous, troubled anti-hero and came to be known as Superdoomsday when his rampage through the worlds of the Multiverse resulted in the deaths of Earth-42's Superman and Earth-46's Optiman before its defeat at the hands of Earth-23's President Superman and Earth-0's Superman.");
            multiverse[46] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._14_24_25_27_28_46_49, "This world is one of seven unknown worlds created by an Inner Chamber of seven Monitor Magi. The mysterious purpose of this world, as well as this world itself, is yet to be revealed.");
            multiverse[47] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._47, "Home to the psychedelic champions of the Love Syndicate of Dreamworld led by Sunshine Superman and including the Shooting Star, Speed Freak, Magic Lantern, and Brother Power the Geek. The Love Syndicate is financed by the immortal teenaged President Prez Rickard. All is groovy.");
            multiverse[48] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._48, "The Earth of the Forerunners- a race of super-beings bred to be harvested as ultimate protectors of the Multiverse itself. Rapid evolution has resulted in super-trees, super-dogs, mice, super-TV shows, and more. Every story is a crossover epic, every event an EVENT. Sometimes known as Warworld, Earth-48 has been converted by benevolent aliens into a factory designed to produce a race of Fifth World warriors to fight in the eternal war against Lord Darkseid. The Royal Family of Warworld includes Lady Quark, Liana, Brother Eyes, Antarctic Monkey, Danger Dog, Lord Quark, Kid Vicious, and billions more.");
            multiverse[49] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._14_24_25_27_28_46_49, "This world is one of seven unknown worlds created by an Inner Chamber of seven Monitor Magi. The mysterious purpose of this world, as well as this world itself, is yet to be revealed.");
            multiverse[50] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._50, "When President Lex Luthor murdered the Flash, the Superman of this world took it upon himself to punish Luthor by death and instituted a global police state patrolled and maintained by the tyrannical, super-powered Justice Lords.");
            multiverse[51] = new Earth(Multiversal_Observatory__Version_2._0.Properties.Resources._51, "On a fragile Earth ravaged by an unknown Great Disaster, men act like beasts and beasts act like men! Here, Kamandi, the last boy on Earth, and his allies Prince Tuftan of the Tiger-Men and Ben Boxer (A.K.A. biOMAC) have embarked on a mind-bending rescue mission to the ends of the earth, while the vast, powerful, and manipulative New Gods look on.");
        }

        public Form1()
        {
            InitializeComponent();
            createMultiverse();
            
            MessageBox.Show("Welcome to the Multiversal Observatory!");
            MessageBox.Show("Enter a number in double-digit format to go to its corresponding Earth. For example, to go to Earth-2, Enter '0', then '2'.");
            MessageBox.Show("Credits to Grant Morrison's 'The Multiversity: Guidebook' for the descriptions and illustrations.");
        }

        public void reset()
        {
            multiversalDesignate = 0;
            doubleDigits = false;
            multiversalCoordinates.Text = multiversalDesignate.ToString();
        }
                                       
        private void goTo_Click(object sender, EventArgs e)
        {
            if (multiversalDesignate < 52)
            {
                viewScreen.BackgroundImage = multiverse[multiversalDesignate].EarthView;
                earthDescription.Text = multiverse[multiversalDesignate].EarthDescription;
                reset();
            }
            else
            {
                MessageBox.Show("This number is not valid! Select a number from 0 to 51.");
                reset();
            } 
        }

        private void addZero_Click(object sender, EventArgs e)
        {
            if (doubleDigits == false)
            {
                multiversalDesignate = 0;
                doubleDigits = true;
            }
            else
            {
                multiversalDesignate += 0;
            }
            multiversalCoordinates.Text = multiversalDesignate.ToString();
        }

        private void addOne_Click(object sender, EventArgs e)
        {
            if (doubleDigits == false)
            {
                multiversalDesignate = 10;
                doubleDigits = true;
            }
            else
            {
                multiversalDesignate += 1;
            }
            multiversalCoordinates.Text = multiversalDesignate.ToString();
        }

        private void addTwo_Click(object sender, EventArgs e)
        {
            if (doubleDigits == false)
            {
                multiversalDesignate = 20;
                doubleDigits = true;
            }
            else
            {
                multiversalDesignate += 2;
            }
            multiversalCoordinates.Text = multiversalDesignate.ToString();
        }

        private void addThree_Click(object sender, EventArgs e)
        {
            if (doubleDigits == false)
            {
                multiversalDesignate = 30;
                doubleDigits = true;
            }
            else
            {
                multiversalDesignate += 3;
            }
            multiversalCoordinates.Text = multiversalDesignate.ToString();
        }

        private void addFour_Click(object sender, EventArgs e)
        {
            if (doubleDigits == false)
            {
                multiversalDesignate = 40;
                doubleDigits = true;
            }
            else
            {
                multiversalDesignate += 4;
            }
            multiversalCoordinates.Text = multiversalDesignate.ToString();
        }

        private void addFive_Click(object sender, EventArgs e)
        {
            if (doubleDigits == false)
            {
                multiversalDesignate = 50;
                doubleDigits = true;
            }
            else
            {
                multiversalDesignate += 5;
            }
            multiversalCoordinates.Text = multiversalDesignate.ToString();
        }

        private void addSix_Click(object sender, EventArgs e)
        {
            if (doubleDigits == false)
            {
                multiversalDesignate = 60;
                doubleDigits = true;
            }
            else
            {
                multiversalDesignate += 6;
            }
            multiversalCoordinates.Text = multiversalDesignate.ToString();
        }

        private void addSeven_Click(object sender, EventArgs e)
        {
            if (doubleDigits == false)
            {
                multiversalDesignate = 70;
                doubleDigits = true;
            }
            else
            {
                multiversalDesignate += 7;
            }
            multiversalCoordinates.Text = multiversalDesignate.ToString();
        }

        private void addEight_Click(object sender, EventArgs e)
        {
            if (doubleDigits == false)
            {
                multiversalDesignate = 80;
                doubleDigits = true;
            }
            else
            {
                multiversalDesignate += 8;
            }
            multiversalCoordinates.Text = multiversalDesignate.ToString();
        }

        private void addNine_Click(object sender, EventArgs e)
        {
            if (doubleDigits == false)
            {
                multiversalDesignate = 90;
                doubleDigits = true;
            }
            else
            {
                multiversalDesignate += 9;
            }
            multiversalCoordinates.Text = multiversalDesignate.ToString();
        }
    }
}
