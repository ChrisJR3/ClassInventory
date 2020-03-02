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

            // if object is in list remove it
            // display message to indicate deletion made
           // Player_Info search = allPlayers.Find(x => x.name == textBox1.Text);
            int index = allPlayers.FindIndex(x => x.name == removeInput.Text);
            if (index < 0)
            {
                outputLabel.Text = "No player matches that name.";
            }
            else
            {
                //int converter = Convert.ToInt32(search);
                allPlayers.RemoveAt(index);
                outputLabel.Text = "Player removed sucessfuly.";
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions.
            //---------------------------
            outputLabel.Text = "";

            // if object entered exists in list show it
            // else show not found message
            Player_Info search = allPlayers.Find(x => x.name == textBox1.Text);
            if (search == null)
            {
                outputLabel.Text = "No player matches that name";
            }
            else
            {
                outputLabel.Text = "Name:    " + search.name + "\n" + "Age:       " + search.age + "\n" + "Team:     " + search.team + "\n" + "Position: " + search.position;
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            foreach (Player_Info p in allPlayers)
            {
                outputLabel.Text += "\n" + "\n" + "Name:    " + p.name + "\n" + "Age:       " + p.age + "\n" + "Team:     " + p.team + "\n" + "Position: " + p.position;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
