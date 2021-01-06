using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTnhom
{
    class chain_process
    {
        public int num_char(string input)
        {

            int num=0;
            num = input.Length;
            return num;
        }

        public int Count(string input,string x)
        {
            int num = 0;
           if (x=="up")
            {
                for(int i=0; i< input.Length; i++)
                {
                    if (Char.IsUpper(input[i])) num++;
                }    

            }
           else
            {
                if(x=="lower")
                {
                    for(int i=0;i<input.Length;i++)
                    {
                        if (Char.IsLower(input[i])) num++;
                    }    
                }   
                else
                {
                    for(int i=0;i<input.Length;i++)
                    {
                        if (char.IsNumber(input[i])) num++;
                    }
                }
            }
            return num;           

        }

        //tach tu
        public string separation(string input, string word)
        {
            int space = 0;
            string output = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsWhiteSpace(input[i]) == true)
                {
                    space++;
                }
            }
            string[] str = input.Split(' ');
            for (int i = 0; i <= space; i++)
            {
                if (str[i] == word)
                {
                    str[i] = "" + "\r\n";

                }
                output += str[i] + " ";

            }
            return output;
        }
            
    }
}
