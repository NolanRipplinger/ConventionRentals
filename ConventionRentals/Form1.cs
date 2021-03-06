using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConventionRentals
{
    public partial class RentalForm : Form
    {
        public RentalForm()
        {
            InitializeComponent();


        }



        //Selected Check in
        private void CheckInButton_Click(object sender, EventArgs e)
        {
            //if (treeView1.SelectedNode.Text != "Controllers") 
            if (treeView1.SelectedNode.Text != null)
            {
                CheckInForm CheckIn = new CheckInForm();

                //Modify Basic Attributes
                CheckIn.Text = "Check In " + treeView1.SelectedNode.Text;
        

                //Stop resizing
                CheckIn.FormBorderStyle = FormBorderStyle.FixedDialog;
                CheckIn.MaximizeBox = false;
                CheckIn.MinimizeBox = false;

                //Add Elements to Form
                //Change check in item name to be treeView1.SelectedNode.Text

                CheckIn.Show();
            }
        }

        //Selected Check out
        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Text != "Controllers")
            {
                Console.WriteLine("This would check out an item.");
            }
        }

        //Selected a node from the tree
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Bitmap bit;

            switch (treeView1.SelectedNode.Text) 
            {
                case "Xbox Controller":
                    bit = new Bitmap(System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName + "\\img\\xbox.png");
                    break;
                case "Playstation Controller":
                    bit = new Bitmap(System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName + "\\img\\playstation.png");
                    break;
                case "Switch Controller":
                    bit = new Bitmap(System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName + "\\img\\switch.png");
                    break;
                default:
                    bit = new Bitmap(System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName + "\\img\\placeholder.png");
                    break;
            }

            pictureBox1.Image = bit;
        }


        //Not worried about this but it has to exist
        private void RentalsBox_Enter(object sender, EventArgs e)
        {

        }

        //Not worried about this but it has to exist
        private void StockBox_Enter(object sender, EventArgs e)
        {

        }

        private void StockButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("This Checks the current stock.");

        }

        private void OutstandingRentalsButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("This checks outstanding rentals.");
        }
    }
}
