using System;

namespace Problems {

    public class Program {

        static void Main(string[] args) {

            Console.WriteLine("Enter some input");
            string input = Console.ReadLine();
            Console.WriteLine(Prefix(input));
        }

        static string Prefix(string input) {
            int words = 0;
            int length = input.Length;
            bool noWords = true;
            char[] c = input.ToCharArray();
            bool looking = true; // currently looking for a word

            for(int i = 0; i< length; i++) {
                Console.WriteLine("curr = " + c[i]);
                if(c[i] != ' ' && noWords == true) {//checks whether or not there is at least one word
                    noWords = false;
                }

                if(looking == true && c[i] == ' ') { // skips over spaces
                    continue;
                }

                if(looking == false && c[i] != ' ') {// skips over words that have already been counted
                    continue;
                }

                if(looking == false && c[i] == ' ') { // if finds a space after a word, then look for a new word
                    looking = true;
                }

                if(looking == true && c[i] != ' ') { //if looking for a new word and finds !space then words++ and stop looking
                    looking = false;
                    words++;
                }

            }

            if(noWords == false && words == 0) {// if a word was found but not added, then add it
                words++;
            }

            return Convert.ToString(length) + "," + Convert.ToString(words) + ":" + input;
        }
    }
}
