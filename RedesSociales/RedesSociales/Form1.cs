using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RedesSociales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
           IWeb Network;
                //Console.WriteLine("Enter Social Network Name:");
                string network = comboBox1.Text;
                WebFactory factory = new WebFactory();
                Network = factory.CreateRequest(network);
                //Network.direccion="http://www." + network.ToLower() + ".com";
                // webBrowser1.Navigate("http://www." + network.ToLower() + ".com"); // variable
                webBrowser1.Navigate(Network.Url);
                //Console.WriteLine(Network.Destination);
                // Network.Login();
                //Console.ReadKey();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
