﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Sockets;

namespace ChatServer
{
    public class Connection
    {
        public NetworkStream datosRed { get; }
        public StreamWriter escribir { get; }
        public StreamReader leer { get; }
        public string nombreUsuario { get; set; }
        public Connection(TcpClient client)
        {
            this.datosRed = client.GetStream();
            this.escribir = new StreamWriter(this.datosRed);
            this.leer = new StreamReader(this.datosRed);
            this.nombreUsuario = leer.ReadLine();
        }
    }
}
