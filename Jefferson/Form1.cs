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


        private void button3_Click(object sender, EventArgs e) {
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
                        for (char k = 'A'; k <= 'Z'; k++) {
                            cylinders[i].Items.Add(k);
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


                    theAsciNumer = (TheCode + Convert.ToChar(cylinders[i].Text.ToUpper()));
                    _Message = _Message + cylinders[i].Text;
                    //MessageBox.Show(theAsciNumer.ToString());
                    if (theAsciNumer > 90) {
                        theAddedValue = theAsciNumer - 90 + 64;
                        _EncMessage = _EncMessage + (char)theAddedValue;
                    }
                    else {
                        _EncMessage = _EncMessage + (char)theAsciNumer;
                    }
                }
                Message.Text = _Message;
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
        }


        int _decCode;
        int MinValue;
        private void button8_Click(object sender, EventArgs e) {
            try {
                RealMessage.Text = "";
                _decCode = Convert.ToInt32(DecCode.Text);
                foreach (char item in EncMessageToDec.Text) {
                   // MessageBox.Show(item+"");
                    theAsciNumer = (Convert.ToChar(item) - _decCode);
                    if (theAsciNumer < 65) {
                        MinValue = 90 - (64 - theAsciNumer); 
                        RealMessage.Text = RealMessage.Text + (char)MinValue;
                    }
                    else {
                        RealMessage.Text = RealMessage.Text + (char)theAsciNumer; // true
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
    }
}
