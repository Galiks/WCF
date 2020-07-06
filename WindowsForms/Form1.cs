using System;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            foreach (var item in client.GetOrders())
            {

                label1.Text += item.Name + Environment.NewLine;
            }


        }
    }
}
