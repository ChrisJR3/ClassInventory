using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassInventory
{
    public partial class Form1 : Form
    {
        // TODO - create a List to store all inventory objects
        List<Player_Info> allPlayers = new List<Player_Info>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // TODO - gather all information from screen 

            // TODO - create object with gathered information
            Player_Info newPlayer = new Player_Info();
            newPlayer.name = nameInput.Text;
            newPlayer.age = ageInput.Text;
            newPlayer.team = teamInput.Text;
            newPlayer.position = positionInput.Text;

            // TODO - add object to global list
            allPlayers.Add(newPlayer);

            // TODO - display message to indicate addition made
            outputLabel.Text = "New player added";
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions.
            //---------------------------

            // TODO - if object is in list remove it

            // TODO - display message to indicate deletion made
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions.
            //---------------------------

            // TODO - if object entered exists in list show it
            // TODO - else show not found message
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions.
            //---------------------------

            // TODO - show all objects in list
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
