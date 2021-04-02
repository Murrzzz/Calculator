using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int val=0;
        int result = 0;
        String op;
        
       Boolean  c_enter =false  ;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (val != 0)
            {
                btnEqual.PerformClick();
                op = "+";
                txtVal.Text = "";
            }
            else
            {
                op = "+";
                val = int.Parse(txtVal.Text);
                txtVal.Text = "";
            }   
  
        }

        private void btnSubt_Click(object sender, EventArgs e)
        {

            if (val != 0)
            {
                btnEqual.PerformClick();
                op = "-";
                txtVal.Text = "";
            }
            else
            {
                op = "-";
                val = int.Parse(txtVal.Text);
                txtVal.Text = "";
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (val != 0)
            {
                btnEqual.PerformClick();
                op = "/";
                txtVal.Text = "";
            }
            else
            {
                op = "/";
                val = int.Parse(txtVal.Text);
                txtVal.Text = "";
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (val != 0)
            {
                btnEqual.PerformClick();
                op = "*";
                txtVal.Text = "";
            }
            else
            {
                op = "*";
                val = int.Parse(txtVal.Text);
                c_enter = true;
                txtVal.Text = "";
            }
        }

        private void btnEqual_Click_1(object sender, EventArgs e)
        {

            switch (op)
            { 
                case "+":
                    txtVal.Text = (val + int.Parse(txtVal.Text)).ToString() ;
                   
                    break;
                case "-":
                    txtVal.Text = (val - int.Parse(txtVal.Text)).ToString();
                    break;
                case "/":
                    txtVal.Text = (val / int.Parse(txtVal.Text)).ToString();
                    break;
                case "*":
                    txtVal.Text = (val * int.Parse(txtVal.Text)).ToString();
                    break;
            
            
            }
            val = int.Parse(txtVal.Text);
            op = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVal.Text = "0";
            val = 0;
        }

        private void c_text()
        {
            if (c_enter)
            {
                txtVal.Text = "";
                c_enter = false;
            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c_text();
        }
       

        
    }
}
