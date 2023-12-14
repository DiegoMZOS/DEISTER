using System.Windows.Forms;

namespace HERMMAMIENTA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SeleccionarCarpetaButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    // Limpiar la lista antes de agregar nuevos archivos
                    ArchivosListBox.Items.Clear();

                    // Obtener la ruta de la carpeta seleccionada
                    string carpetaSeleccionada = folderBrowserDialog.SelectedPath;

                    // Obtener archivos con extensiones específicas en la carpeta
                    string[] archivos = Directory.GetFiles(carpetaSeleccionada, "*.*")
                        .Where(file => file.ToLower().EndsWith(".pdf") || file.ToLower().EndsWith(".jpg") || file.ToLower().EndsWith(".png"))
                        .ToArray();

                    // Mostrar archivos en la ListBox
                    foreach (string archivo in archivos)
                    {
                        ArchivosListBox.Items.Add(archivo);
                    }
                }
            }

        }

        private void ArchivosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ModificarNombres_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    // Limpiar la lista antes de agregar nuevos archivos
                    ArchivosListBox.Items.Clear();

                    // Obtener la ruta de la carpeta seleccionada
                    string carpetaSeleccionada = folderBrowserDialog.SelectedPath;

                    // Obtener archivos con extensiones específicas en la carpeta
                    string[] archivos = Directory.GetFiles(carpetaSeleccionada, "*.*")
                        .Where(file => file.ToLower().EndsWith(".pdf") || file.ToLower().EndsWith(".jpg") || file.ToLower().EndsWith(".png"))
                        .ToArray();

                    // Mostrar archivos en la ListBox
                    foreach (string archivo in archivos)
                    {
                        ArchivosListBox.Items.Add(archivo);
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}