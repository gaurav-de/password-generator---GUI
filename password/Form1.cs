using custom_needs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password
{
    public partial class password_generator : Form
    {
        public password_generator()
        {
            InitializeComponent();
        }

        Random random = new Random();
        shuffler shf = new shuffler();
        char[] raw_value = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()abcdefghijklmnopqrstuvwxy1234567890!@#$%^&*()".ToCharArray();
        String want_char, temp_one, temp_three, temp_two;
        int char_length, temp_four;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public String generator(int length, char[] list1, int need)
        {
            String t1 = "";
            String t2 = "";
            while (length > 0)
            {
                t1 = list1[random.Next(0, need)].ToString();
                t2 = t2 + t1;
                length--;
            }
            return t2;
        }

        private void start_generating_Click(object sender, EventArgs e)
        {
            int looping_length = int.Parse(up_length.Text);

            if (special_latter_in_password.Text == ""){ 
                password_ready.Text = generator(looping_length, raw_value, 91); 
            }
            else{ 
                want_char = special_latter_in_password.Text;
                char_length = want_char.Length;
                int left_length = looping_length - char_length;
                int half_left_length = left_length / 2;

                if(options_for_chracter.Text == "custom chracter in left")
                {
                    temp_one = generator(left_length, raw_value, 91);
                    password_ready.Text = (want_char + temp_one);
                }
                else if(options_for_chracter.Text == "custom chracter in center")
                {
                    if(left_length%2 == 0)
                    {
                        temp_one = generator(half_left_length, raw_value, 91);
                        temp_three = generator(half_left_length, raw_value, 91);
                        password_ready.Text = (temp_three + want_char + temp_one);
                    }
                    else
                    {
                        temp_four = half_left_length + 1;
                        temp_one = generator(temp_four, raw_value, 91);
                        temp_three = generator(half_left_length, raw_value, 91);
                        password_ready.Text = (temp_one + want_char + temp_three);
                    }
                }
                else if (options_for_chracter.Text == "custom chracter in right")
                {
                    temp_one = generator(left_length, raw_value, 91);
                    password_ready.Text = (temp_one + want_char);
                }
                else if (options_for_chracter.Text == "custom chracter shuffled ")
                {
                    temp_one = generator(left_length, raw_value, 91);
                    temp_two = (want_char + temp_one);
                    password_ready.Text = (shuffler.string_shuffler(temp_two));
                }
            }
        }

        private void password_generator_Load(object sender, EventArgs e)
        {
            
        }
    }
}
