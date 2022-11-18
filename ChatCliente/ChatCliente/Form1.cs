using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ChatCliente
{
    public partial class Form1 : Form
    {
        static Chat formChat;
        public Form1()
        {
            InitializeComponent();
        }
        private void botonCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            string ip = txtIP.Text;
            if (txtNombre.Text.Length > 8)
            {
                MessageBox.Show("El nombre no puede tener mas de 8 caracteres");
            }
            else
            {
                MessageBox.Show(txtNombre.Text);
                if (ip != "") ip = "127.0.0.1";
               
                formChat = new Chat(txtNombre.Text,ip);
                formChat.Show();
                this.Hide();
            }
        }

    }
}
