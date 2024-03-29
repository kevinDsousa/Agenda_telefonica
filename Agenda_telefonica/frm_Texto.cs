﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_telefonica
{
    public partial class frm_Texto : Form
    {

        //props de controle
        public bool cancelado { get; set; }

        public string texto { get; set; }
        public frm_Texto()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmd_cancelar_Click(object sender, EventArgs e)
        {
            //cancela o quadro
            cancelado = true; 
            this.Close();
        }

        private void cmd_pesquisar_Click(object sender, EventArgs e)
        {
            if (text_texto.Text == "") return;
            texto = text_texto.Text;
            cancelado = false;
            this.Close();
        }

        private void text_texto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                cmd_pesquisar_Click(cmd_pesquisar, EventArgs.Empty);
        }
    }
}
