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
    public partial class UserControl1 : UserControl
    {
        Random rnd = new Random();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

      

        public void Assigntiles()
        {

            List<String> tiles = new List<String>()
        {
            "g","g", "g","g","g","g","g","g","g","g","g",
            "g","g", "g","g","g","g","g","g","g","g","g",
            "g","g", "g","g","g","g","g","g","g","g","g",
            "g","g", "g","g","g","g","g","g","g","g","g",
            "g","g", "g","g","g","g","g","g","g","g","g",
            "g","g", "g","g","g","g","g","g","g","g","g",
            "g","g", "g","g","g","g","g","g","g","g","g",
            "g","g", "g","g","g","g","g","g","g","g","g",
            "g","g", "g","g","g","g","g","g","g","g","g",
            "m","m", "m","m","m","m","m","m","m","m","m",
            "w","w", "w","w","w","w","w","w","w","w","w",
        };

            int randomNumber;

            PictureBox picBox;


            for (int i = 0; i < gridLayout.Controls.Count; i++)
            {

                if (gridLayout.Controls[i] is PictureBox)
                {

                    picBox = (PictureBox)gridLayout.Controls[i];                   
                }
                else
                {
                    continue;
                }
                randomNumber = rnd.Next(0, tiles.Count);

                picBox.Text = "";
                picBox.Tag = tiles[randomNumber]; //assigns tiles randomly to squares

                if (picBox.Tag == "w")
                {
                    picBox.Image = Image.FromFile("water.jpg");
                }

                if (picBox.Tag == "m")
                {
                    picBox.Image = Image.FromFile("Rocks.jpg");
                    

                    
                }
                if (picBox.Tag == "g")
                {
                    picBox.Image = Image.FromFile("grass.jpg");
                   
                    
                }
                


                tiles.RemoveAt(randomNumber); //removes from list so no duplicates

            }
        }
    }
}
