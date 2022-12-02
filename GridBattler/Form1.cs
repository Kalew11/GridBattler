using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridBattler
{
    public partial class Form1 : Form
    {
        public int turnCounter = 1;
        public Form1()
        {
            InitializeComponent();
            userControl11.Assigntiles();
        }

        private void btnBuildGrid_Click(object sender, EventArgs e)
        {
            userControl11.Assigntiles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(turnCounter == 1)
                lblTurn.Text = txtPlayer1.Text + "'s turn";
            if (turnCounter == 2)
                lblTurn.Text = txtPlayer2.Text + "'s turn";
        }

        private void lblTurn_Click(object sender, EventArgs e)
        {

        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            turnCounter++;
            if (turnCounter == 3)
            {
                turnCounter = 1;
            }
            if (turnCounter == 1)
                lblTurn.Text = txtPlayer1.Text + "'s turn";
            if (turnCounter == 2)
                lblTurn.Text = txtPlayer2.Text + "'s turn";
           
        }

        private void txtPlayer2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
