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

namespace ChatServer
{
    public partial class Form1 : Form
    {
        Sevidor servidorActual;
        Email email;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            servidorActual = new Sevidor(this);
            email = new Email();
            new Thread(() => servidorActual.Iniciar()).Start();
        }
        public void actualizarRegistro()
        {
            if(labelLista.Text != "") labelLista.Text = "";
            List<Connection> conexiones = servidorActual.getConexiones();
            foreach(Connection user in conexiones)
            {
                labelLista.Text += "\n-"+user.nombreUsuario;
            }
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                email.enviarMensaje();
            }).Start();
        }

        private void botonCerrar_Click_1(object sender, EventArgs e)
        {
            new Thread(() =>
            {

            });
            this.Close();
        }

    }
}
