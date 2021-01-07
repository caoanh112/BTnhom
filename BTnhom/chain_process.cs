using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
        //Đảo chuỗi
        public string mix(string input)
        {
            string output = "";
            for (int i = input.Length; i > 0; i--)
            {
                output = output + input[i - 1];
            }
            return output;
        }
        //Tối ưu chuỗi
        public string Opimal(string input)
        {
            string output = "";
            string[] arrWord = input.Split(' ');
            for(int i=0; i<arrWord.Length;i++)
            {
                if (arrWord[i] != "") output += arrWord[i] + " ";
            }    
            return output;
        }

        // chuyển txt ==> âm thanh 
        public string text_to_void(string input)
        {
            String result = Task.Run(async () =>
            {

                String payload = input;

                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("api-key", "qM0gRjqS9rXH4gKCTa5sgtLh0aTKa6Au");
                client.DefaultRequestHeaders.Add("speed", "");
                client.DefaultRequestHeaders.Add("voice", "banmai");                
                var response = await client.PostAsync("https://api.fpt.ai/hmi/tts/v5", new StringContent(payload));                
                return await response.Content.ReadAsStringAsync();                
            }).GetAwaiter().GetResult();
            //cắt chuỗi JSON 
            string[] str = result.Split('"');
            //play url âm thanh
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            Thread.Sleep(600);
            wplayer.URL = str[3];            
            wplayer.controls.play();
            return str[3];

        }
    }
}
