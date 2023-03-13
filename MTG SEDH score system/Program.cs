using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTG_SEDH_score_system
        // To do list:
        // Create and Array for each catagory on a single card and fill them out 
        // Decide which Arrays effect gameplay and which do not. for those that do each of them would be a new array setting them in order of strength. 
        // 0 being the strongest. 
        // Create a score method that looks through each array given to it and prints the point values for each catagory 
        // create a CARDNAME method that scores every catagory present on one single card and test to see if the score method returns the expected result
        // Test the upper and lower limits of the score method so that it cannot return unreasonable values such as negative values. 
{

    // switch bool to check what the colors are if true #of colors 

    // call the converted mana cost and look for the number of Letters, display the mana cost == CMC - foreach DFV
    public class Program
    {
        // -Converted mana cost INT, Different Mana Value , Supertypes, Card tpes- 

        // Required metrics: Converted mana cost INT, Different mana values STRING-Array, Supertype BOOL, Card type STRING-Array, Card sub-types STRING-Array, Color Identity SWITCH, Power INT, Toughness INT.
        // CMC, D Mana values and color identity need to talk to each other. 
        // Card Super types, Card types and Sub types need to talk to each other. 

        // W == 0,  U == 5, B == 10,  R == 15,  G == 20


        public static int[] ConvertedManaCost = new int[17] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        public static string[] DifferentManaValue = new string[] { "W", "WU", "WB", "WR", "WG", "U", "UW", "UB", "UR", "UG", "B", "BW", "BU", "BR", "BG", "R", "RW", "RU", "RB", "RG", "G", "GW", "GU", "GB", "GR" };
        public static bool[] Supertype = new bool[3];
        public static string[] CardType = new string[] {"Land" , "Creature" , "Enchantment" , "Artifact" , "Instant" , "Sorceries" };
        public static int Power = 10;
        public static int Toughness = 10;


       
       


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Supertype[0] = true;
            Supertype[1] = false;     
            Supertype[2] = false;
            Supertype[3] = false;





            //string[,] Example = new string[6,9];
            





    }





    }





       


    








    }
