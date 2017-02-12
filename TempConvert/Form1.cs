using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConvert
{
    public partial class frmTempConvert : Form
    {
        public frmTempConvert()
        {
            InitializeComponent();
        }
        //The GUI objects are named based on Hungarian Notations. 
        //Hugarian notation uses CamelCase, where the type is abbreviated in all lower case 
        //And the first letter of the object name is capitalized. 
        //Example; cboConvert, cbo stands for combobox and Convert is the name of the object selected.

        private void cboConvert_SelectedIndexChanged(object sender, EventArgs e)
        {
            //The values float and decimal maybe be better suited for represetning monetary values 
            //due to their precision.
            //Double is better suited for representing whole numbers.
            double userInput;
            double F;
            double C;
            double K;

            //The TryParse method returns a boolean result (true or false).
            //If condition 1 (txtInput.text) and conditonal 2 (userInput) match (true), the temperature conversion code executes.
            if (double.TryParse(txtInput.Text, out userInput) == true)
            {
                //Selectionn box or choices of temperature scale.
                //Switch statement is used for the Temeprature selection
                string Temperature = cboConvert.Text;
                switch (Temperature)
                {
                    case "Fahrenheit":      //When selection box "Fahrenheit" is selected the following code runs                                                                     
                        F = userInput;      //F is the user entered number which is used as a variable for the formulas below.                    
                        lblF.Text = userInput.ToString("N2");   //ToString("N2"); will disply user entered number into correct label                      
                                                                //Formatting type "N2" is used to keep temeprature numbers within TWO decimal points.
                                                                //Formulas for converting Fahrenheit to Celsius and Kelvin.
                        lblC.Text = ((F - 32) * 5 / 9).ToString("N2");
                        lblK.Text = ((F + 459.67) * 5 / 9).ToString("N2");
                        //Break will end the closest switch statement and execeute the next statement
                        break;

                    case "Celsius":     //When "Celsius" is selected in the combo box the following code will run                                                                                                
                        C = userInput;
                        lblC.Text = userInput.ToString("N2");
                        lblF.Text = ((C * 1.8) + 32).ToString("N2");
                        lblK.Text = (C + 273.15).ToString("N2");
                        break;

                    case "Kelvin":  //When "Kelvin" is selected in the combo box the following code will run                     
                        K = userInput;
                        lblK.Text = userInput.ToString("N2");
                        lblF.Text = ((1.8 * (K - 273.15)) + 32).ToString("N2");
                        lblC.Text = (K - 273.15).ToString("N2");
                        break;
                }
            }
        }
        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            //user can select the three different temperature options through the use of the up and down arrow // 
            if (e.KeyCode == Keys.Enter)
            {
                cboConvert.PerformLayout();
            }
        }
        private void frmTempConvert_KeyDown(object sender, KeyEventArgs e)
        {
            //user can press the "Esc" key to exit program        
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Messege box about the creator of this appication.
            MessageBox.Show("This Application is created by Mei Changshi at ASA College" + Environment.NewLine +
                "May 20, 2016");
        }
        private void frmTempConvert_Load(object sender, EventArgs e)
        {
            //This function will run the formulas automatically.
                cboConvert.SelectedIndex = 0;
        }
    }
}