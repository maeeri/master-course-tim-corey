using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageWall
{

    public partial class Dashboard : Form
    {
        private List<string> messages = new List<string>();

        public Dashboard()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            msgListBox.DataSource = messages;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            messages.Add(msgAdderTxtBox.Text);
            msgAdderTxtBox.Text = "";
            msgAdderTxtBox.Focus();
        }
    }

    
}
