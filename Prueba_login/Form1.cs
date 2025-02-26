﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private Dictionary<string, string> usuarios;

       
        public Form1(Dictionary<string, string> usuarios)
        {
            InitializeComponent();
            this.usuarios=usuarios;
        
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Usuario";
            label2.Text = "Contraseña";
            button1.Text = "Iniciar";
            button2.Text = "Registrar";

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario=textBox1.Text;
            string contraseña=textBox2.Text;

            if (usuarios.ContainsKey(usuario))
            {
                if (usuarios[usuario] == contraseña)  
                {
                    MessageBox.Show("Inicio exitoso");
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta\"");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nuevoUsuario = textBox4.Text;
            string nuevaContraseña = textBox3.Text;

            if (string.IsNullOrWhiteSpace(nuevoUsuario) || string.IsNullOrWhiteSpace(nuevaContraseña))
            {
                MessageBox.Show("Usuario o contraseña vacios");
                return;
            }


            if (usuarios.ContainsKey(nuevoUsuario))
            {
                MessageBox.Show("El usuario ya existe");
            }
            else
            {
                usuarios.Add(nuevoUsuario, nuevaContraseña);
                MessageBox.Show("Usuario registrado");
                textBox4.Clear();
                textBox3.Clear();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
