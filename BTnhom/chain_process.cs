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
            char[] arr = new char[input.Length]; // khởi tạo mảng kí tự với độ dài là mảng nhập vào
            //chuyển chuỗi ==> mảng kí tự
            for (int i=0;i<input.Length;i++)
            {
                arr[i] = input[i];
            }
            //đảo kí tự bằng ramdom
            Random rd = new Random();
            for (int i=0; i<arr.Length;i++)
            {
                int swap = rd.Next(i, arr.Length); //lấy giá trị vị trí bất kì
                //đảo vị trí i và swap
                char temp = arr[i];
                arr[i] = arr[swap];
                arr[swap] = temp;
            }
            //xuất mảng
            for (int i=0;i<arr.Length;i++)
            {
                output += arr[i];
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
        // Tìm vị trí xuất hiện đầu tiên 
        public int firstposition(string input, string charFind)
        {
            // vị trí xuất hiên đầu tiên của ký tự charFind (cái này gọi cái là ra rồi)
            // ToLower là để đều đưa về 1 kiểu chữ thường so sánh
            int output = input.ToLower().IndexOf(charFind.ToLower().ToCharArray()[0]);
            if(output != -1)
            {
                return output + 1;
            }
            else
            {
                return output;
            }
        }
        // Tìm vị trí xuất hiện cuối cùng
        public int lastposition(string input, string charFind)
        {
            int start = 0;
            int output = -1;
            while (true)
            {
                // Lấy vị trí đầu tiên xuất hiện
                int index1 = input.ToLower().IndexOf(charFind.ToLower()[0], start);
                // Kiểm tra có tồn tại trong chuỗi input bắt đầu từ vị trí start
                if (index1 == -1)
                {
                    break;
                }
                else 
                {
                    // Kiểm tra lớn hơn vị trị đã tìm trước đó
                    if(index1 > output)
                    {
                        // Gán vị trả về = vị trí tìm được
                        output = index1;
                        // dịch vị trí tìm kiếm ký tự
                        start = output + 1;
                    }
                }
            }
            return (output == -1) ? -1 : (output + 1);
        }
        // Đếm số lần xuất hiện 
        public int Number(string input, string charCount)
        {
            int output = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input.ToLower()[i].Equals(charCount.ToLower()[0]))
                {
                    output++;
                }
            }
            return output;
        }
        // thay đổi chuỗi con
        public string change(string input, string oldString, string newString)
        {
            return input.Replace(oldString, newString);
        }
        // Xóa chuỗi con 
        public string delete(string input, string oldString)
        {
            return input.Replace(oldString, "");
        }
        // Chèn chuỗi
        public string insert(string input,string Chain, int p)
        {
            string output = "";
            string str1="", str2="";
            for(int i=0;i<input.Length;i++)
            {
                if(i<=p)
                {
                    str1 += input[i].ToString();

                }
                if(i>p)
                {
                    str2 += input[i].ToString();
                }
            }
            output = str1 + Chain + str2;

            return (output);
        }
       


        

        //Trích lọc
        public string filter(string input, int p1, int p2)
        {
            {
                string output = "";
                //đảm bảo p2 luôn lớn hơn p1
                if (p2 < p1)
                {
                    int temp = p1;
                    p1 = p2;
                    p2 = temp;
                }
                for (int i = 0; i < input.Length; i++)
                {
                    if (i >= p1 && i <= p2)
                    {
                        output += input[i];
                    }
                }
                return (output);
            }
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
