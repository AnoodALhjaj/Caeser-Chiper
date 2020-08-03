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
    public partial class Form3 : Form
    {
        IDictionary<int, string> dict = new Dictionary<int, string>();
        public Form3()
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

        public String  let_num(char lett, string k)
        {

            string let = lett.ToString();
            string get = "";
            for (int i = 1; i <= dict.Count; i++)
            {
                if (dict[i] == let.ToUpper())
                {

                    get += keytest(i, k);
                }


            }
            return get;
        }
        public String keytest(int num, string key)
        {

            int ke = int.Parse(key);
            if ((num + ke) % 26 > 26)
            {
                int i = (num + ke) % 26;
                while (i <= 26)
                {
                    i = i % 26;

                }
                return dict[i];

            }
            
             else if ((num + ke) % 26 == 0)
            {
                return dict[(num + ke)];
            }
            else
            {

                return dict[(num + ke) % 26];
            }
            



        }
 
        private void button1_Click(object sender, EventArgs e)
        {
         
            String letters = textBox1.Text;//get all the letters
  
               
                foreach (char i in letters)
                {

                     label3.Text+=let_num(i,textBox2.Text);


                }
               
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label3.Text);
            MessageBox.Show("message have been copied !","Notifcation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}