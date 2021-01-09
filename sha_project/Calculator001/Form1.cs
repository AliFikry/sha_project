using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCalulator
{
    public partial class Form1 : Form
    {
        Calculation operation = new Calculation(); 
     
        public Form1()
        {
            InitializeComponent();
           
        }
              
           

        private void buttonNum_Click(object sender, EventArgs e)
        {
            
            if (lblResult.Text == "0" )
            {
                lblResult.ResetText();
            }     
            Button button = (Button)sender;
            if(button.Text == ".")
            {               
                lblResult.Text = lblResult.Text + button.Text;
            }else
            lblResult.Text = lblResult.Text + button.Text;
            
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            lblResult.ResetText();
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0";
        }

        private void Calculation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation.op = button.Text;
            operation.Number2 = double.Parse(lblResult.Text);
            lblResult.ResetText();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            switch (operation.op)
            {
                case "/":
                    lblResult.Text = Calculation.Division(operation.Number2, double.Parse(lblResult.Text)).ToString();
                    break;
                case "-":
                    lblResult.Text = Calculation.Subtraction(operation.Number2, double.Parse(lblResult.Text)).ToString();
                    break;
                case "+":
                    lblResult.Text = Calculation.Addition(operation.Number2, double.Parse(lblResult.Text)).ToString();
                    break;
                case "X":
                    lblResult.Text = Calculation.Multiplication(operation.Number2, double.Parse(lblResult.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    button0.PerformClick();
                    break;
                case "1":
                    button1.PerformClick();
                    break;
                case "2":
                    button02.PerformClick();
                    break;
                case "3":
                    button03.PerformClick();
                    break;
                case "4":
                    button04.PerformClick();
                    break;
                case "5":
                    button05.PerformClick();
                    break;
                case "6":
                    button06.PerformClick();
                    break;
                case "7":
                    button07.PerformClick();
                    break;
                case "8":
                    button08.PerformClick();
                    break;
                case "9":
                    button09.PerformClick();
                    break;
                case ".":
                    buttonPoint.PerformClick();
                    break;
                case "+":
                    buttonAdd.PerformClick();
                    break;
                case "-":
                    buttonMinus.PerformClick();
                    break;
                case "*":
                    buttonMultiply.PerformClick();
                    break;
                case "/":
                    buttonDiv.PerformClick();
                    break;
                case " ":
                    btnResult.PerformClick();
                    break;
                case "\r":
                    btnResult.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
