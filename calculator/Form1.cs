using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {

        private string text;
        private string text1;
        private string text2;
        private int namber;

        public Form1()
        {
            InitializeComponent();
            namber = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { if(namber == 0)
            {
                text = textBox1.Text;
            }
            else if(namber == 1)
            {
                text1 = textBox1.Text;
            }
            else if (namber == 2)
            {
                text2 = textBox1.Text;
            }

            inform.Text = "";
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text = "";
            textBox1.Text = "";
            namber = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (namber == 0)
            {
                inform.Text = "Введите подстроку которую хотите заменить и нажмите ещё раз";
                namber++;

            }
            else if(namber ==1)
            {

                inform.Text = "Введите подстроку которой хотите заменить и нажмите ещё раз";
                namber++;
            }
            else if(namber ==2)
            {
                text = text.Replace(text1, text2);
                inform.Text = "Выполнено ";
                textBox1.Text = text;
                namber = 0;
                text1 = "";
                text2 = "";
               
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (namber == 0)
            {
                inform.Text = "Введите подстроку которую хотите удалить и нажмите ещё раз";
                namber++;
                
            }
            else if (namber == 1)
            {
                text = text.Replace(text1, "");
                inform.Text = "Выполнено " ;
                textBox1.Text = text;
                namber = 0;
                text1 = "";
              
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (namber == 0)
                {
                    inform.Text = "введите номер символа в строке и нажмите ещё раз";
                    namber++;
                }
                else if (namber == 1)
                {
                    int i;
                    i = Convert.ToInt16(text1);
                    inform.Text = "Выполнено ";
                    textBox1.Text = text[i + 1].ToString();
                    text1 = "";
                    namber = 0;
                }

            }
            catch (Exception exept)
            {
                inform.Text = exept.Message;
                inform.ForeColor = Color.Red;
               
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
          int q= text.Length;
            inform.Text = "Выполнено: "+ q;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int d=0;
            string glas = "ауоыиэяюёеiuАУОЫИЭЯЮЁЕIUY";
            for (int r = 0; r < text.Length; r++){
                for(int t = 0; t < glas.Length; t++)
                {
                    if (text[r] == glas[t])
                    {
                        d++;
                    }
                }
             
            }


            inform.Text = "Выполнено: " +d;
      
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int d = 0;
            string glas = "qwrtpsdfghjklzxcvbnmQWRTPSDFGHJKLZXCVBNMЙЦКНГШЩЗХЪФВПРЛДЖЧСМТЬБйцкнгшщзхъфвпрлджчсмтьб";
            for (int r = 0; r < text.Length; r++)
            {
                for (int t = 0; t < glas.Length; t++)
                {
                    if (text[r] == glas[t])
                    {
                        d++;
                    }
                }

            }


            inform.Text = "Выполнено: " + d;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int d = 0;
            for (int r = 0; r < text.Length; r++)
            {
               
                    if (text[r] == '.')
                    {
                        d++;
                    }
                

            }


            inform.Text = "Выполнено: " + d;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int d = 0;
            for (int r = 0; r < text.Length; r++)
            {
                if (text[r] != text[text.Length-1])
                {
                    if (text[r] == ' ' && text[r + 1] != ' ')
                    {
                        d++;
                    }
                }
               
             


            }
            if(text[0]!=' ')
            d++;
            inform.Text = "Выполнено: " + d;
        }
    }
}
