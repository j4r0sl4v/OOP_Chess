using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Chess_IT1A
{
    public class Figure
    {
        private List<string> numbers = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8" };
        private List<string> letters = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H" };
        private string position;

        public FigureType Type { get; set; }
        public string Position
        {
            set
            {
                if (string.IsNullOrEmpty(value))    //hodnota v proměnné value je null nebo ""
                {
                    throw new Exception("Figure postion value can't be empty string or null value!");
                }
                else if (value.Length == 2)
                {
                    if (letters.Contains(value.Substring(0, 1)) && numbers.Contains(value.Substring(1,1)))  //druhý znak v proměnné value je v listu numbers
                    {

                    }
                }
                else
                {
                    throw new Exception("Figure postion value has to be 2 letters valid chess postion!");
                }
            }
            get => position;
        }

        public Figure()
        {
            Position = "A2";
            Position = "a2";
            Position = "sdfsdf";
        }
    }


    //výčtový datový typ - seznam hodnot - interně jsou to hodnoty integer (od 0)
    public enum FigureType
    {
        Pawn,       //pěšec
        Rook,       //věž
        Knight,     //jezdec
        Bishop,     //střelec
        Queen,      //dáma
        King        //král
    }
}
