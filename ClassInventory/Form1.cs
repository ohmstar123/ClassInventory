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
        List<NewPlayer> data = new List<NewPlayer>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name, age, team, position;
            // TODO - gather all information from screen 
            name = c.Text;
            age = ageInput.Text;
            team = teamInput.Text;
            position = positionInput.Text;

            // TODO - create object with gathered information
            NewPlayer t = new NewPlayer(name, age, team, position);

            // TODO - add object to global list
            data.Add(t);
            label1.Text = "";

            // TODO - display message to indicate addition made
            label1.Text = "Finished";
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
            

            foreach (NewPlayer informationList in data)
            {
                label1.Text += informationList.name + " " + informationList.age + " " + informationList.team + " " + informationList.position + "\n";
            }
        }
    }
}
