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
      

        private void button2_Click(object sender, EventArgs e)
        {
            CN_BACKUP restaurar = new CN_BACKUP();
            // Asegúrate de que se haya seleccionado un archivo antes de intentar restaurar
            if (string.IsNullOrWhiteSpace(tarchivo.Text))
            {
                MessageBox.Show("Por favor, selecciona un archivo de respaldo antes de intentar restaurar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Continúa con la función de restaurar_backup utilizando txtRutaArchivoRestaurar.Text
            restaurar.RestaurarBackup(tarchivo.Text);

            MessageBox.Show("Restauracion Exitosa!.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialogoArchivo = new OpenFileDialog())
            {
                // Configura el filtro para mostrar solo archivos .bak
                //dialogoArchivo.Filter = "Archivos de respaldo (*.bak)|*.bak|Todos los archivos (*.*)|*.*";
                dialogoArchivo.FilterIndex = 1; // Establece el índice del filtro en 1

                DialogResult resultado = dialogoArchivo.ShowDialog();

                if (resultado == DialogResult.OK && !string.IsNullOrWhiteSpace(dialogoArchivo.FileName))
                {
                    // Mostrar la ruta del archivo seleccionado en el TextBox
                    tarchivo.Text = dialogoArchivo.FileName;
                }
            }
        }
    }
}
