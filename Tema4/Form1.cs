using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4
{
    public partial class Form1 : Form
    {
        private string[] lengthUnits = { "Metri", "Inch", "Feet", "Kilometri" };
        private string[] weightUnits = { "Kilograme", "Grame", "Uncii", "Livre" };
        private string[] temperatureUnits = { "Celsius", "Kelvin", "Fahrenheit" };
        public Form1()
        {
            InitializeComponent();
            comboBoxIntrare.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxIesire.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Doriți să închideți aplicația?","Exit",MessageBoxButtons.YesNo);
           // this.Close();
        }

        private void lengthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBoxIntrare.Items.Clear();
            comboBoxIesire.Items.Clear();
            comboBoxIntrare.Items.AddRange(lengthUnits);
            comboBoxIesire.Items.AddRange(lengthUnits);
        }

        private void weightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBoxIntrare.Items.Clear();
            comboBoxIesire.Items.Clear();
            comboBoxIntrare.Items.AddRange(weightUnits);
            comboBoxIesire.Items.AddRange(weightUnits);
        }

        private void temperatureToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            comboBoxIntrare.Items.Clear();
            comboBoxIesire.Items.Clear();
            comboBoxIntrare.Items.AddRange(temperatureUnits);
            comboBoxIesire.Items.AddRange(temperatureUnits);
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            double value;
            if (!double.TryParse(textBoxValue.Text, out value))
            {
                MessageBox.Show("Introduceți o valoare numerică validă!", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string InputUnit = comboBoxIntrare.SelectedItem.ToString();
            string OutputUnit = comboBoxIesire.SelectedItem.ToString();

            double convertedValue = 0;

            switch (InputUnit)
            {
                case "Metri":
                    switch (OutputUnit)
                    {
                        case "Metri":
                            convertedValue = value;
                            break;
                        case "Inch":
                            convertedValue = value * 39.37;
                            break;
                        case "Feet":
                            convertedValue = value * 3.281;
                            break;
                        case "Kilometri":
                            convertedValue = value / 1000;
                            break;
                        default:
                            MessageBox.Show("Unitatea de ieșire nu este validă!", "Eroare",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                    break;

                case "Inch":
                    switch (OutputUnit)
                    {
                        case "Inch":
                            convertedValue = value;
                            break;
                        case "Metri":
                            convertedValue = value / 39.37;
                            break;
                        case "Feet":
                            convertedValue = value / 12;
                            break;
                        case "Kilometri":
                            convertedValue = value / 39370.079;
                            break;
                        default:
                            MessageBox.Show("Unitatea de ieșire nu este validă!", "Eroare",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                    break;

                case "Feet":
                    switch(OutputUnit)
                    {
                        case "Feet":
                            convertedValue = value;
                            break;
                        case "Metri":
                            convertedValue = value / 3.281;
                            break;
                        case "Inch":
                            convertedValue = value * 12;
                            break;
                        case "Kilometri":
                            convertedValue = value / 3280.84;
                            break;
                        default:
                            MessageBox.Show("Unitatea de ieșire nu este validă!", "Eroare",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                    break;

                case "Kilometri":
                    switch (OutputUnit)
                    {
                        case "Kilometri":
                            convertedValue = value;
                            break;
                        case "Metri":
                            convertedValue = value * 1000;
                            break;
                        case "Inch":
                            convertedValue = value * 39370.079;
                            break;
                        case "Feet":
                            convertedValue = value * 3280.84;
                            break;
                        default:
                            MessageBox.Show("Unitatea de ieșire nu este validă!", "Eroare",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                    break;

                case "Kilograme":
                    switch (OutputUnit)
                    {
                        case "Kilograme":
                            convertedValue = value;
                            break;
                        case "Grame":
                            convertedValue = value * 1000;
                            break;
                        case "Uncii":
                            convertedValue = value * 35.274;
                            break;
                        case "Livre":
                            convertedValue = value * 2.205;
                            break;
                        default:
                            MessageBox.Show("Unitatea de ieșire nu este validă!", "Eroare",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                    break;

                case "Grame":
                    switch (OutputUnit)
                    {
                        case "Grame":
                            convertedValue = value;
                            break;
                        case "Kilograme":
                            convertedValue = value / 1000;
                            break;
                        case "Uncii":
                            convertedValue = value * 0.035274;
                            break;
                        case "Livre":
                            convertedValue = value * 0.002205;
                            break;
                        default:
                            MessageBox.Show("Unitatea de ieșire nu este validă!", "Eroare",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                    break;

                case "Uncii":
                    switch (OutputUnit)
                    {
                        case "Uncii":
                            convertedValue = value;
                            break;
                        case "Kilograme":
                            convertedValue = value * 0.02835;
                            break;
                        case "Grame":
                            convertedValue = value * 28.35;
                            break;
                        case "Livre":
                            convertedValue = value * 0.0625;
                            break;
                        default:
                            MessageBox.Show("Unitatea de ieșire nu este validă!", "Eroare",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                    break;

                case "Livre":
                    switch (OutputUnit)
                    {
                        case "Livre":
                            convertedValue = value;
                            break;
                        case "Kilograme":
                            convertedValue = value * 0.4536;
                            break;
                        case "Grame":
                            convertedValue = value * 453.6;
                            break;
                        case "Uncii":
                            convertedValue = value * 16;
                            break;
                        default:
                            MessageBox.Show("Unitatea de ieșire nu este validă!", "Eroare",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                    break;

                case "Celsius":
                    switch (OutputUnit)
                    {
                        case "Celsius":
                            convertedValue = value;
                            break;
                        case "Kelvin":
                            convertedValue = value + 273.15;
                            break;
                        case "Fahrenheit":
                            convertedValue = (value * 9 / 5) + 32;
                            break;
                        default:
                            MessageBox.Show("Unitatea de ieșire nu este validă!", "Eroare",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                    break;

                case "Kelvin":
                    switch (OutputUnit)
                    {
                        case "Kelvin":
                            convertedValue = value;
                            break;
                        case "Celsius":
                            convertedValue = value - 273.15;
                            break;
                        case "Fahrenheit":
                            convertedValue = (value - 273.15) * 9 / 5 + 32;
                            break;
                        default:
                            MessageBox.Show("Unitatea de ieșire nu este validă!", "Eroare",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                    break;

                case "Fahrenheit":
                    switch (OutputUnit)
                    {
                        case "fahrenheit":
                            convertedValue = value;
                            break;
                        case "Celsius":
                            convertedValue = (value - 32) * 5 / 9;
                            break;
                        case "Kelvin":
                            convertedValue = (value - 32) * 5 / 9 + 273.15;
                            break;
                        default:
                            MessageBox.Show("Unitatea de ieșire nu este validă!", "Eroare",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                    break;

                default:
                    MessageBox.Show("Unitatea de intrare nu este validă!", "Eroare",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }


                    labelResult.Text=$"{convertedValue}";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            comboBoxIntrare.SelectedIndex = -1;
            comboBoxIesire.SelectedIndex = -1;
            textBoxValue.Clear();
            labelResult.Text = string.Empty;
            MessageBox.Show("Datele au fost sterse cu succes!", "Stergere",
                        MessageBoxButtons.OK);
        }
    }
}
