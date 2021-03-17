using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Stream_Control_Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var sr = new StreamReader("G:\\Streaming\\data.js"))
                {
                    //var fullFile = sr.ReadToEnd();
                    sr.ReadLine();
                    String json_Data = sr.ReadLine();
                    int n = 12;
                    json_Data = json_Data.Substring(n, json_Data.Length - (n + 2));
                    JObject json = JObject.Parse(json_Data);
                    textBox1.Text = (string)json;
                }
            }
            catch (IOException erorr)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(erorr.Message);
            }
        }
    }
}
