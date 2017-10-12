using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace journal
{//purpose of journal is to add a time stamp to a string of text and append it to a file for journaling
   
    
    class Program
    {
        static void Main(string[] args)
        {
            bool kg = true;
            bool first = false;//so the first time through we want a time stamp to be added

            GetJournal(first);//bool nft below will be false
            first = true;

            while (kg == true)
            {
                GetJournal(first); //bool nft below will be true
            }
        }
        public static void GetJournal(bool nft)//asks for input then adds a timestamp at the beginning of the string if nft is false, nft not first time
        {
            DateTime localDate = DateTime.Now;
            string inputted = Console.ReadLine();
            string current = localDate.ToString();

            if (nft == false)
            {
                inputted = current + ": " + inputted;
            }

            PostJournal(inputted);

            inputted = " ";
            current = " ";
        }
        public static void PostJournal(string input)//appends the file thought.txt with timestamped string from above
        {
            using (StreamWriter writer = new StreamWriter("INSERT YOUR FILENAME HERE", true))//MUST CHANGE TO YOUR PERSONAL .txt FILE YOU CREATE 
            {
                writer.WriteLine(input);
            }
          
        }
    }
}
