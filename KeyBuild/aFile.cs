using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyBuild
{
    public class aFile
    {
        public aFile()
        {
        }
        public static void Save(string fileName)
        {
            // Set a variable to the My Documents path.
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Create a stringbuilder and write the new user input to it.
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("New User Input");
            sb.AppendLine("= = = = = =");
            //sb.Append(UserInputTextBox.Text);
            sb.AppendLine();
            sb.AppendLine();

            // Open a streamwriter to a new text file named "UserInputFile.txt"and write the contents of 
            // the stringbuilder to it.
            using (StreamWriter outfile = new StreamWriter(mydocpath + fileName, true))
            {
                outfile.WriteAsync(sb.ToString());
            }
        }
        public static void SaveWithFileDialog(string codigo)
        {
            SaveFileDialog saveFileDialog1;
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Guardar Archivo de Texto";
            saveFileDialog1.Filter = "Archivo de Texto (.txt) |*.txt";

            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.InitialDirectory = @"H:\LO DEL ESCRITORIO";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ruta = saveFileDialog1.FileName;

                FileStream fs = new FileStream(ruta, FileMode.Create);

                StreamWriter fichero = new StreamWriter(fs);
                fichero.Write(codigo);
                fichero.Close();
                fs.Close();
                MessageBox.Show("Se guardo el archivo: " + saveFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("Has cancelado.");
            }
            saveFileDialog1.Dispose();
            saveFileDialog1 = null;
        }
    }
}
