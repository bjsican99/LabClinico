﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class DatosUsuarioClini : Form
    {
        public DatosUsuarioClini()
        {
            InitializeComponent();
        }

        private void DatosUsuarioClini_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            MenuClinica Vi_Menu = new MenuClinica();
            Vi_Menu.Show();
            this.Hide();
        }

        private void Txt_Regresar_Click(object sender, EventArgs e)
        {

        }
    }
}