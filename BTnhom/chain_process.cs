using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTnhom
{
    class chain_process
    {
        //chuyển chuỗi in hoa
        public string Upper(string input)
        {
            string output = "";
            for (int i=0;i<input.Length; i++)
            {
                output += char.ToUpper(input[i]);
            }
            return output;
        }
        //chuyển chuỗi in thường
        public string Lower(string input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                output += Char.ToLower(input[i]);
            }
            return output;
        }
        //đếm số kí tự In hoa, thường hoặc số
        public int Count(string input,string x)
        {
            int num = 0;
           if (x=="up")
            {
                for(int i=0; i< input.Length; i++)
                {
                    if (Char.IsUpper(input[i])==true) num++;
                }    

            }
           else
            {
                if(x=="lower")
                {
                    for(int i=0;i<input.Length;i++)
                    {
                        if (Char.IsLower(input[i])==true) num++;
                    }    
                }   
                else
                {
                    if (x == "digit")
                    {
                        for (int i = 0; i < input.Length; i++)
                        {
                            if (char.IsNumber(input[i]) == true) num++;
                        }
                    }
                    
                }
            }
            return num;           

        }

        //tách từ khỏi chuỗi
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
