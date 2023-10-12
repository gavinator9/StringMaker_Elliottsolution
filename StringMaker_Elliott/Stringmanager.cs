// Gavin Elliott
// IT113
// NOTES: I tried everything I could think of to avoid having to do modular arithmetic. In the end it was easy to do it with modulus but I still
//wish I could've found another way to get the behaviour I was after with the ToString method besides modulus.
// BEHAVIORS NOT IMPLIMENTED AND WHY: None 

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StringMaker_Elliott
{
    internal class Stringmanager
    {


        private string originalinput=null;

        public Stringmanager()
        {

        }

        public string reverse(string input)
        {
            if (originalinput == null)
            {
                originalinput = input;
            }
            char[] result= new char[input.Length];
            Queue<char> queue = new Queue<char>();
            for(int i=input.Length-1; i>=0; i--)
            {
                queue.Enqueue(input[i]);
            }
            for(int i=0; i<input.Length; i++)
            {
                result[i] = queue.Dequeue();
            }

            
            return new string(result);
        }

        public string reverse(string input, bool casepreserve)
        {
            if (originalinput == null)
            {
                originalinput = input;
            }
            char[] original= input.ToCharArray();
            char[] result = new char[input.Length];
            Queue<char> queue = new Queue<char>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                queue.Enqueue(input[i]);
            }
            for (int i = 0; i < input.Length; i++)
            {
                result[i] = queue.Dequeue();
                if (char.IsLetter(result[i]) == true) 
                {

                    if (char.IsUpper(original[i]) == true)
                    {
                        result[i] = char.ToUpper(result[i]);
                    }
                    else
                    {
                        result[i] = char.ToLower(result[i]);
                    }


                }

            }


            return new string(result);
        }

        public bool symmetric(string input)
        {
            if (originalinput == null)
            {
                originalinput = input;
            }

            string reversed=reverse(input);
            if (reversed==input) return true;
            else return false;

            


        }

        public string ToString(string input)
        {
            if (originalinput == null)
            {
                originalinput = input;
            }

            int ascii = 0;
            if (string.IsNullOrEmpty(input))
            {
                return "Negative One";
            }
            string[] digits = {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string result = "";
            string[] resultbuilder= new string[input.Length];
            for(int i=0; i<input.Length; i++)
            {
                ascii += (int)input[i];


            }
            int counter = 0;
            // This particular modulo trick took some stack overflow and headaches to figure out after exhausting other int manipulation choices
            while (ascii>0)
            {
                int tens = ascii % 10;
                resultbuilder[counter] = digits[tens];
                ascii /= 10;
                counter++;
            }


            for(int i = input.Length - 1; i >= 0; i--)
            {
                result += resultbuilder[i];
                result += " ";
            }

            return result.Trim();
            

        }

        public override bool Equals(object input)
        {
            bool result = false;

            if (input is string)
            {
                if ((string)input==originalinput) result = true;
            }
            return result;
        }


    }
}
