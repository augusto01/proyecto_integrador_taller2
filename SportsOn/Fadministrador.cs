﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsOn
{
    public partial class Fadministrador : Form
    {
        public Fadministrador()
        {
            InitializeComponent();
        }

        private void Busuario_Click(object sender, EventArgs e)
        {
            Form formulario = new FagregarUsuario();
            formulario.Show();

        }
    }
}
