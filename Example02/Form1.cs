using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuyLibrary;

namespace Example02
{
    public partial class Form1 : Form
    {
        private Guy John;
        private Guy Bob;
        
        
        
        public Form1()
        {
            InitializeComponent();

            John = new Guy() { Name = "John", Cash = 3000 };
            Bob = new Guy { Name = "Bob", Cash = 5000 };


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guy1give_Click(object sender, EventArgs e)
        {
            Bob.ReceiveCash(John.GiveCash(600));
        }

        private void guy2give_Click(object sender, EventArgs e)
        {
            John.ReceiveCash(Bob.GiveCash(1200));
        }

        public void UpdateScreen()
        {
            this.guy1name.Text = John.Name;
            this.guy1cash.Text = John.Cash.ToString();
            this.guy2name.Text = Bob.Name;
            this.guy2cash.Text = Bob.Cash.ToString();


        }

        private void guy2name_Click(object sender, EventArgs e)
        {
            UpdateScreen();
        }

        private void guy2cash_Click(object sender, EventArgs e)
        {
            UpdateScreen();
        }

        private void guy1cash_Click(object sender, EventArgs e)
        {
            UpdateScreen();
        }

        private void guy1name_Click(object sender, EventArgs e)
        {

        }

        private void guy1name_Click_1(object sender, EventArgs e)
        {

        }

        private void guy1cash_Click_1(object sender, EventArgs e)
        {

        }
    }
}
