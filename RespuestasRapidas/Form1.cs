using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RespuestasRapidas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAgregarRespuesta_Click(object sender, EventArgs e)
        {
            if (CajaDeTextoCrearRespuesta.Text.Length > 0)
            {
                ListaRespuestas.Items.Add(CajaDeTextoCrearRespuesta.Text);

                CajaDeTextoCrearRespuesta.Clear();
            }
        } // Agrega respuesta a la lista

        private void ListaRespuestas_DoubleClick(object sender, EventArgs e)
        {
            if (ListaRespuestas.SelectedItem != null)
            {
                Clipboard.SetText(ListaRespuestas.SelectedItem.ToString());
            }
        } // Función copiar a portapapeles al hacer click al item

        private void Form1_Load(object sender, EventArgs e)
        {
            String? line; // El signo de pregunta deja que sea nulleable
            String path;

            path = Application.StartupPath;

            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new(path + "\\Respuestas.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    ListaRespuestas.Items.Add(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("El archivo " + path + "\\Respuestas.txt" + " no se encontró. No se cargaron respuestas", "No hay respuestas"); //mensaje por si el archivo "Respuestas.txt" no existe
            }
        } // Busca el archivo Respuestas.txt en la ruta donde se inició el programa

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var x = MessageBox.Show("Guardar cambios? ",
                                     "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (x == DialogResult.No)
            {
                e.Cancel = false;
            }
            else
            {
                String path = Application.StartupPath;

                try
                {
                    // Create a FileStream with mode CreateNew  
                    //stream = new FileStream(path + "\\Respuestas.txt", FileMode.Create);
                    StreamWriter file = new(path + "\\Respuestas.txt", append: false);

                    foreach (string s in ListaRespuestas.Items)
                    {
                        file.WriteLine(s);
                    }
                    file.Close();
                }
                finally
                {

                }


            }
        } // Función para guardar cambios

        private void ListaRespuestas_RightClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {

                case MouseButtons.Right:

                    ListaRespuestas.SelectedIndex = ListaRespuestas.IndexFromPoint(e.X, e.Y); // selecciona el item incluso con el click derecho
                    
                    if (ListaRespuestas.SelectedItem != null)
                    {
                        

                    }
                    break;
                   
}
        } // A futuro, abre menú para borrar respuesta


    }
}
