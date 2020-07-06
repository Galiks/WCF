using System;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        private readonly ServiceReferenceWindowsForms.Service1Client client;
        public Form1()
        {
            InitializeComponent();
            client = new ServiceReferenceWindowsForms.Service1Client();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            foreach (var item in client.GetOrders())
            {

                label1.Text += item.Name + Environment.NewLine;
            }


        }
    }
}
