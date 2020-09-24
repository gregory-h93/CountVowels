//Gregory Hass
//9/23/2020
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CountVowels
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            //Decalre the variables being used and initialize the number of vowels to 0
            int numVowels = 0, i;
            string str, lowerStr;

            //Set the text input by the user equal to a variable
            str = txtInput.Text;

            //Make the text input by the user all lowercase
            lowerStr = str.ToLower();

            //Loop through the input going character by character
            for(i = 0; i < lowerStr.Length; i++)
            {
                //Compare easch character to the vowel list
                if(lowerStr[i] == 'a' || lowerStr[i] == 'e' || lowerStr[i] == 'i' || lowerStr[i] == 'o' || lowerStr[i] == 'u')
                {
                    //If a vowel matches then add 1 to the count
                    numVowels++;
                }
            }
            //Display the results
            txtNumVowels.Text = (numVowels.ToString());
        }

        //Clear the results should the input change
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            txtNumVowels.Text = "";
        }
    }
}
