using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion.Vistas.Backup
{
    public partial class Fagregar_backup : Form
    {
        public Fagregar_backup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (truta.Text == String.Empty || tnombrearchivo.Text == String.Empty || truta.Text == "Seleccione un destino")
            {
                if (truta.Text == String.Empty || truta.Text == "Seleccione un destino")
                {
                    eruta.SetError(truta, "Selecciona una direccion!");
                }
                else
                {
                    enombre.SetError(tnombrearchivo, "Selecciona un nombre de archivo!");
                }

            }
            else
            {
                CN_BACKUP backup = new CN_BACKUP();
                backup.RealizarBackup(truta.Text.Trim(), tnombrearchivo.Text.Trim());
                truta.Clear();
                tnombrearchivo.Clear();
                enombre.Clear();
                eruta.Clear();
                MessageBox.Show("Backup realizado con exito!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            

        }

        private void banadir_Click(object sender, EventArgs e)
        {
            {
                using (FolderBrowserDialog dialogoCarpeta = new FolderBrowserDialog())
                {
                    DialogResult resultado = dialogoCarpeta.ShowDialog();

                    if (resultado == DialogResult.OK && !string.IsNullOrWhiteSpace(dialogoCarpeta.SelectedPath))
                    {
                        // Mostrar la ruta seleccionada en el TextBox
                        truta.Text = dialogoCarpeta.SelectedPath;
                    }
              
                }
            }   
        }
    }
}
