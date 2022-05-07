using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace E_Pharma_App
{
    
    public class MyLogger 
    {        
        private string CurrentDirectory { get; set; }
        private string FileName { get; set; }
        private string FilePath { get; set; }
        /// <summary>
        /// Creates a text document in the same directory
        /// </summary>
        public MyLogger()
        {
            this.CurrentDirectory = Directory.GetCurrentDirectory();
            this.FileName = "Log.txt";
            this.FilePath = this.CurrentDirectory + "/" + this.FileName;
        }
        /// <summary>
        /// Logs The approriate message
        /// </summary>
        /// <param name="message">Enter the message</param>

        public  void Log(string message)
        {
            using (System.IO.StreamWriter sw = System.IO.File.AppendText(this.FilePath))
            {
                sw.Write("\r\n Log Entry:");
                sw.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                sw.WriteLine("   :{0}", message);
                sw.WriteLine("----------------------------------------------");
            }

        }
    }
}
