using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caeser_Chiper
{
    public partial class Form1 : Form
    {
        IDictionary<int, string> dict = new Dictionary<int, string>();
        string[] lines = System.IO.File.ReadAllLines("words.txt", Encoding.UTF8);

        public Form1()
        {
            InitializeComponent();
            letter();
        }

        public int letter()
        {
            dict.Add(1, "A");
            dict.Add(2, "B");
            dict.Add(3, "C");
            dict.Add(4, "D");
            dict.Add(5, "E");
            dict.Add(6, "F");
            dict.Add(7, "G");
            dict.Add(8, "H");
            dict.Add(9, "I");
            dict.Add(10, "J");
            dict.Add(11, "K");
            dict.Add(12, "L");
            dict.Add(13, "M");
            dict.Add(14, "N");
            dict.Add(15, "O");
            dict.Add(16, "P");
            dict.Add(17, "Q");
            dict.Add(18, "R");
            dict.Add(19, "S");
            dict.Add(20, "T");
            dict.Add(21, "U");
            dict.Add(22, "V");
            dict.Add(23, "W");
            dict.Add(24, "X");
            dict.Add(25, "Y");
            dict.Add(26, "Z");
            return 0;
        }
        public String let_num(string letters ,string k)
        {
            
            foreach (char cha in letters)
            {
                
                for (int i = 1; i <= dict.Count; i++)
                {
                    if (dict[i] ==cha.ToString().ToUpper())
                    {

                        label1.Text += keytest(i, k);
                        //i.ToString()+",";

                        break;

                    }

                }
            }
            return label1.Text;
        }
        public String keytest(int num,string key)
        {

            int ke = int.Parse(key);
         
         if ((num - ke) % 26 > 26)
            {
                int i = (num - ke) % 26;
                while (i > 26)
                {
                   i=(num - ke) % 26 - 26;

                }
                return dict[i];

            }
         else if ((num - ke) % 26 <= 0)
         {
             int i = (num - ke) % 26;
             while (i <= 0)
             {
                 i = (num - ke) % 26 + 26;

             }
             return dict[i];

         }
         else
         {
             return dict[(num - ke) % 26];
         }
           
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text =" ";
            
            String letters = textBox1.Text;//get all the letters
            for (int j = 2; j <= 25; j++)
            {
                string get = "";
                get=let_num(letters,j.ToString());
                        
                    
               
                for (int u = 0; u <lines.Length; u++)
                {
                    if (get.ToUpper() == lines[u].ToUpper())
                    {
                      
                      
                        if(label3.Text==" "){
                    label3.Text = get + "    key=" + j + " \n";
                
                  
                        }
                        richTextBox1.Text += get + "    key=" + j + " \n";
                        break;
                        
                        //when it find the first key it jumb to this point for breaking out
                      //  goto Outer;
                    }
                
                    
                }
                if (label3.Text == "")
                {
                    label3.Text ="undefine word";
                }
                label1.Text = "";


            }//go to this point
        //Outer:;
           
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            Form2 f2 = new Form2();
            f.Close();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            Form3 f2 = new Form3();
            f.Close();
            f2.Show();

        }
    }
}
