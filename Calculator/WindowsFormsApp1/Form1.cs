using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Global global = new Global();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayShow("1", global.number);
            display.Text = global.globalData;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            displayShow("2", global.number);
            display.Text = global.globalData;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            displayShow("3", global.number);
            display.Text = global.globalData;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            displayShow("4", global.number);
            display.Text = global.globalData;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            displayShow("5", global.number);
            display.Text = global.globalData;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            displayShow("6", global.number);
            display.Text = global.globalData;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            displayShow("7", global.number);
            display.Text = global.globalData;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            displayShow("8", global.number);
            display.Text = global.globalData;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            displayShow("9", global.number);
            display.Text = global.globalData;
        }
        private void button10_Click_1(object sender, EventArgs e)
        {
            displayShow("0", global.number);
            display.Text = global.globalData;
        }
        private void buttonSum_Click(object sender, EventArgs e)
        {
            displayShow("", 1);
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            displayShow("", 2);
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            displayShow("", 3);
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            displayShow("", 4);
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            global.insertedValues.Add(global.globalData);

            if (global.insertedValues.Count == 1)
            {
                global.insertedValues.Clear();
                display.Text = global.globalData;
                error.Hide();
            }
            else if (global.insertedValues == null && global.insertedOperations == 0)
            {
                error.Text = global.errorInvalidOperation;
                error.Show();
            }
            else if (global.insertedValues.Count == 1)
            {
                display.Text = global.insertedValues[global.insertedValues.Count]; 
            }
            else if (global.insertedValues.Count > 1)
            {
                error.Hide();
              
                        switch (global.insertedOperations)
                        {
                            case 1:
                                    global.result= Int32.Parse(global.insertedValues[0])+ Int32.Parse(global.insertedValues[1]);
                                break;
                            case 2:
                                    global.result = Math.Abs(Int32.Parse(global.insertedValues[0]) - Int32.Parse(global.insertedValues[1]));
                                break;
                            case 3:
                                    global.result = Int32.Parse(global.insertedValues[0]) * Int32.Parse(global.insertedValues[1]);
                                break;
                            case 4:
                                    global.result = Int32.Parse(global.insertedValues[0]) / Int32.Parse(global.insertedValues[1]);
                                break;
                        }
                   


            }
            //else if (global.insertedValues.Count > 2 && global.insertedOperations.Count > 1)
            //{
            //    error.Text = global.errorInvalidOperation;
            //    error.Show();
            //}
            //else if (global.insertedValues.Count > 2 && global.insertedOperations.Count > 2)
            //{
            //    error.Hide();
            //    int i = 0;
            //    while (global.insertedValues.Count > i)
            //    {
            //        i++;
            //    }
            //}

            display.Text = global.result.ToString();
            global.globalData = "";
            global.insertedValues = new List<string>();
            global.insertedOperations = 0;
            

        }
        private void displayShow(string dados,int operacao)
        {
            switch (operacao != 0)
            {
                case true:
                    global.insertedValues.Add(global.globalData);
                    global.insertedOperations = operacao;
                    global.globalData = "";
                    break;
                default:
                    switch (string.IsNullOrEmpty(global.globalData))
                    {
                        case true:
                            global.globalData = dados;
                            break;
                        default:
                            global.globalData = global.globalData + dados;
                            break;
                    }
                    break;
            }
            
        }
        private void display_Click(object sender, EventArgs e)
        {

        }

        private void error_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            global.globalData = "";
            global.insertedValues = new List<string>();
            global.insertedOperations = 0;
            display.Text = "";
        }




    }
}
