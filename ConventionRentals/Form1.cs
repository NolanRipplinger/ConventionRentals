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

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Bitmap bit;

            switch (treeView1.SelectedNode.Text) 
            {
                case "Xbox Controller":
                    bit = new Bitmap("E:\\Backup\\Programming\\.net\\ConventionRentals\\ConventionRentals\\img\\xbox.png");
                    break;
                case "Playstation Controller":
                    bit = new Bitmap("E:\\Backup\\Programming\\.net\\ConventionRentals\\ConventionRentals\\img\\playstation.png");
                    break;
                case "Switch Controller":
                    bit = new Bitmap("E:\\Backup\\Programming\\.net\\ConventionRentals\\ConventionRentals\\img\\switch.png");
                    break;
                default:
                    bit = new Bitmap("E:\\Backup\\Programming\\.net\\ConventionRentals\\ConventionRentals\\img\\placeholder.png");
                    break;
            }

            pictureBox1.Image = bit;
        }
    }
}
