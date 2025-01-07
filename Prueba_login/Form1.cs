using System;
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
                    MessageBox.Show("contraseña incorrecta");
                }
            }
            else
            {
                MessageBox.Show("usuario no encontrado");
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
    }
}
