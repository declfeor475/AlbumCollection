using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Album_Collection
{
    public partial class Form1 : Form
    {
        //global lists for the albums inputted
        public static List<string> albumList = new List<string>();
        public static List<string> sortedList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //turning user input into variable
            string album = albumInput.Text;

            //adding user input to both lists
            albumList.Add(album);
            sortedList.Add(album);

            //clearing labels
            originalLabel.Text = "";
            sortedLabel.Text = "";

            //displaying the albums
            for (int i = 0; i < albumList.Count(); i++)
            {
                originalLabel.Text += albumList[i] + "\n";
            }

            //sorting albums alphanumerically
            sortedList.Sort();

            //displaying sorted albums
            for (int i = 0; i < sortedList.Count(); i++)
            {
                sortedLabel.Text += sortedList[i] + "\n";
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            //turning user input into variable
            string remove = albumInput.Text;

            for (int i = 0; i < sortedList.Count(); i++)
            {
                if (sortedList.Contains(remove))
                {
                    albumList.Remove(remove);
                    sortedList.Remove(remove);
                }
            }

            //clearing labels
            originalLabel.Text = "";
            sortedLabel.Text = "";

            //displaying the albums
            for (int i = 0; i < albumList.Count(); i++)
            {
                originalLabel.Text += albumList[i] + "\n";
            }

            //sorting albums alphanumerically
            sortedList.Sort();

            //displaying sorted albums
            for (int i = 0; i < sortedList.Count(); i++)
            {
                sortedLabel.Text += sortedList[i] + "\n";
            }
        }
    }
}
