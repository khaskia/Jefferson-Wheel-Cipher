using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jefferson {

    /***
     * 
     * Mohamed Ali Khaskia
     * Facebook.com/MohamedKhaskia
     * 01276399758
     * Menofia University
     * 
     * 
     * 
     * 
     *
     ***/
    public partial class Form1 : Form {
        /************                 Varables                      ****************/
        int cNumbers = 5;
        ComboBox[] cylinders;
        String _Message;
        String _EncMessage;
        int theAsciNumer;
        int theAddedValue;
        int TheCode;
        /************                End Varables                      ****************/

        public Form1() {
            InitializeComponent();
            Tab.Appearance = TabAppearance.FlatButtons;
            Tab.ItemSize = new Size(0, 1);
            Tab.SizeMode = TabSizeMode.Fixed;

        }

        String RandomChars;
        private void button3_Click(object sender, EventArgs e) {
            RandomChars = generateRandomLetters();
            if (string.IsNullOrEmpty(CylinersNumber.Text)) {
                MessageBox.Show("you must Enter The Cyliners number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                try {
                    cNumbers = Convert.ToInt32(CylinersNumber.Text); 
                    cylinders = new ComboBox[cNumbers];
                    for (int i = 0, w = 0; i < cNumbers; i++, w += 60) {
                        cylinders[i] = new ComboBox();
                        cylinders[i].SetBounds(w, 5, 50, 40);
                        cylinders[i].Font = new Font("Aria", 15);
                        CylinerPanel.Controls.Add(cylinders[i]);
                        foreach (char item in RandomChars) {
                            cylinders[i].Items.Add(item.ToString());
                        }

                    }
                }
                catch (FormatException er) {
                    MessageBox.Show("please Enter a number");

                }

            }



        }
        #region TabandSomeStuff
        private void ctlModernBlack1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            Tab.SelectedTab = encPage;
        }

        private void button2_Click(object sender, EventArgs e) {
            Tab.SelectedTab = DecPage;

        }

        private void button5_Click(object sender, EventArgs e) {

        }
        #endregion

        private void button4_Click(object sender, EventArgs e) {
            try {
                TheCode = Convert.ToInt32(CodeNumber.Text);
                for (int m = 2; m < 100; m++) {
                 if (TheCode > 26 && TheCode <26*m) {
                     TheCode = TheCode - (26 * (m - 1));
                     MessageBox.Show(TheCode+"");
                     break;
                }   
                }
                
                
                Message.Text = ""; EncMessage.Text = "";
                _Message = ""; _EncMessage = "";
                for (int i = 0; i < cNumbers; i++) {

                    theAsciNumer = TheCode + RandomChars.IndexOf(cylinders[i].Text);

                 //   theAsciNumer = (TheCode + Convert.ToChar(cylinders[i].Text.ToUpper()));
                    _Message = _Message + cylinders[i].Text;
                    //MessageBox.Show(theAsciNumer.ToString());
                    if (theAsciNumer >= 26) {
                        theAddedValue = theAsciNumer - 26 + 0;
                        _EncMessage = _EncMessage + RandomChars[theAddedValue];
                    }
                    else {
                        try {
                            _EncMessage = _EncMessage + RandomChars[theAsciNumer];
                        }
                        catch {
                            MessageBox.Show(cylinders[i].Text+" Probleeeeem ");
                        }
                    }
                }
                Message.Text = _Message.ToUpper();
                EncMessage.Text = _EncMessage;
            }
            catch (FormatException er) {
                    MessageBox.Show("please Enter a number and check your data");    
            }
        }

        private void button6_Click(object sender, EventArgs e) {
            EncMessageToDec.Text = EncMessage.Text;
            Tab.SelectedTab = DecPage;
        }

        private void button7_Click(object sender, EventArgs e) {
            Message.Text = string.Empty;
            EncMessage.Text = string.Empty;
           // MessageBox.Show(generateRandomLetters().Length.ToString());
            int[] orderdnumbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            Random rnd = new Random();
            int[] RandomedNumbers= orderdnumbers.OrderBy(x => rnd.Next()).ToArray();

            MessageBox.Show(RandomedNumbers.ToString());
            string value="";
            foreach (var item in RandomedNumbers) {
                value = value +","+ item;       
          }
            MessageBox.Show(value);
        }


        int _decCode;
        int MinValue;
        private void button8_Click(object sender, EventArgs e) {
            try {
                _decCode = Convert.ToInt32(DecCode.Text);
                for (int m = 2; m < 100; m++) {
                    if (_decCode > 26 && _decCode < 26 * m) {
                        _decCode = (_decCode - (26 * (m - 1)));
                        MessageBox.Show(_decCode + "");
                        break;
                    }
                }


                RealMessage.Text = "";
                //      
               // MessageBox.Show(_decCode+"");

                foreach (char item in EncMessageToDec.Text) {
                   // MessageBox.Show(item+"");
                    theAsciNumer = (RandomChars.IndexOf(item) - _decCode);
                    if (theAsciNumer < 0) {
                        MinValue =( 25 - (-1 - theAsciNumer));
                        try {
                        RealMessage.Text = RealMessage.Text + RandomChars[MinValue];
                        }
                        catch {
                            MessageBox.Show("error in " + item);
                        }
                    }
                    else {
                        RealMessage.Text = RealMessage.Text + RandomChars[theAsciNumer]; // true
                    }

                }
                MessageBox.Show(_Message);
                
              /*  for (int i = 0; i < cNumbers; i++) {

                    theAsciNumer = (TheCode + Convert.ToChar(cylinders[i].Text));
                    _Message = _Message + cylinders[i].Text;
                    //MessageBox.Show(theAsciNumer.ToString());
                    if (theAsciNumer > 90) {
                        theAddedValue = theAsciNumer - 90 + 64;
                        _EncMessage = _EncMessage + (char)theAddedValue;
                    }
                    else {
                        _EncMessage = _EncMessage + (char)theAsciNumer;
                    }
              } */
                
            }
            catch (FormatException er) {
                MessageBox.Show("please Enter a number");
            }
        }

        private void button5_Click_1(object sender, EventArgs e) {
            try { 
            char[] text = textBox1.Text.ToCharArray();
                for (int i = 0; i < cNumbers; i++) {
                  
                    cylinders[i].Text=text[i].ToString();
                    
                }
                    
                    }catch(IndexOutOfRangeException ewe) {
                        MessageBox.Show("Please Fill all the Fields");
                    }
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length >= Convert.ToInt32( CylinersNumber.Text)){
                textBox1.Text = textBox1.Text.Substring(0, Convert.ToInt32(CylinersNumber.Text));

                MessageBox.Show("it is your last Char ");

            
        }
        }

        private void fastLoadTextToolStripMenuItem_Click(object sender, EventArgs e) {
            groupBox7.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e) {
            groupBox7.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e) {
            
            label4.Text = generateRandomLetters();
        }

        public string generateRandomLetters() {

          //  var exclude = new HashSet<int>() { 5, 7, 17, 23 };
          //  var range = Enumerable.Range(1, 100).Where(x => !exclude.Contains(x));

           // var rand = new System.Random();
           // int index = rand.Next(0, 100 - exclude.Count);
           // return range.ElementAt(index);


            int[] orderdnumbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            Random rnd = new Random();
            int[] RandomedNumbers = orderdnumbers.OrderBy(x => rnd.Next()).ToArray();

           string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random rand = new Random();
            String newchars = "";
           // MessageBox.Show("Char Lengh = " + chars.Length);
            int i; int num;
            for ( i = 0; i <= chars.Length-1; i++) {
            //    MessageBox.Show("newcharLenght = " + newchars.Length);
          //  label5:
                // num = rand.Next(0, chars.Length - 1);
                 if (newchars.Contains(chars[RandomedNumbers[i]])) {
                //    i--;
                   //goto label5;
                   }
               else {
                   newchars = newchars + chars[RandomedNumbers[i]].ToString();
                }
            }
            //MessageBox.Show("new char Lenght = " + newchars.Length);
            //MessageBox.Show("iteration is " + i);
            //MessageBox.Show(newchars.Length.ToString());
            return newchars;
        }
    }
}
