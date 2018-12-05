﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST324_TermProject_RideShare
{
    public partial class form_register : Form
    {
        public form_register()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

        private void form_register_Load(object sender, EventArgs e)
        {

        }


        private void driver_btn_Click(object sender, EventArgs e)
        {
            driver_btn.Visible = false;
            admin_btn.Visible = false;
            rider_btn.Visible = false;

            loginQuestion_lb.Visible = true;
            register_tb.Visible = true;
            enter_btn.Visible = true;
            back_btn.Visible = true;
        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            driver_btn.Visible = false;
            admin_btn.Visible = false;
            rider_btn.Visible = false;

            loginQuestion_lb.Text = "      Enter a Password";
            loginQuestion_lb.Visible = true;
            register_tb.Visible = true;
            enter_btn.Visible = true;
            back_btn.Visible = true;
        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
            //Provide logic to switch to the driver form with the provided firstname

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            driver_btn.Visible = true;
            admin_btn.Visible = true;
            rider_btn.Visible = true;

            loginQuestion_lb.Text = "      Enter First Name";
            loginQuestion_lb.Visible = false;
            register_tb.Visible = false;
            enter_btn.Visible = false;
            register_tb.Text = "";
            back_btn.Visible = false;
        }

        private void register_tb_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(register_tb.Text)){
                e.Cancel = true;
                register_tb.Focus();
                register_ep.SetError(register_tb,"Please enter a first name");

            } else if(loginQuestion_lb.Text.ToString().Equals("      Enter a Password"))
            {
                if (!register_tb.Text.ToString().Equals(password))
                {
                    e.Cancel = true;
                    register_tb.Focus();
                    register_ep.SetError(register_tb, "Incorrect Password");
                }
                else
                {
                    this.Hide();
                    Form rf = new form_Admin();
                    rf.ShowDialog();
                }

            } else
            {
                //TODO check to see if first name added was in the driver database


            }
        }

        private void rider_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form rf = new form_Rider();
            rf.ShowDialog();
        }
    }
=======
>>>>>>> parent of 4728aa6... Merge branch 'master' into Cool;beans
    }
}
