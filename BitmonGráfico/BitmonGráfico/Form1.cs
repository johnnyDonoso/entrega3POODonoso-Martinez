﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;


namespace BitmonGráfico
{

    public partial class Form1 : Form
    {
        public static ControllerLucha lucha1 = new ControllerLucha();
        public static string nombre1,nombre2;
        
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("C:\\Users\\usuario\\Desktop\\entrega3POODonoso-Martinez\\Imagenes\\bitmon_stadium.jpeg");
        }

        private void bt_ALuchar_Click(object sender, EventArgs e)
        {
            nombre1 = tb_NameP1.Text;
            nombre2 = tb_NameP2.Text;

            if(nombre1 == "" || nombre2 == "")
            {
                MessageBox.Show("Ingrese nombres válidos porfavor!!");
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                lucha1.OnagregarJugardor(tb_NameP1.Text);
                lucha1.OnagregarJugardor(tb_NameP2.Text);
                MessageBox.Show(tb_NameP1.Text + " y " + tb_NameP2.Text + " \n" + "Ahora se iniciara la elección de bitmon \npara cada jugador");
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
            }
            
        }
        private void tb_NameP1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

