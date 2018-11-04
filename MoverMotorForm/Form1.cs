using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace MoverMotorForm
{
    public partial class Form1 : Form
    {

        SerialPort mipuerto;

        public Form1()
        {
            InitializeComponent();

            mipuerto = new SerialPort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mipuerto.Write("a");



        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripCmbPuertos.Items.AddRange(SerialPort.GetPortNames());
        }

        private void cerrarPuertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mipuerto.Close();
        }

        private void abrirPuertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                mipuerto.PortName = toolStripCmbPuertos.SelectedItem.ToString();
                mipuerto.BaudRate = int.Parse(toolStripCmbVelocidad.SelectedItem.ToString());
                mipuerto.Open();
             


            }
            catch (IOException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
