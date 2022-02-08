using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ActualizadorVideos.Clases
{
    public class logs
    {
        //string logsEventos = Application.StartupPath + @"\logs";
        private string Path = "";
        private string Brinco = "\n";

        public logs(string Path)
        {
            this.Path = Path;
        }

        public void Add(string slog)
        {
            CreateDirectory();
            string nombre = GetNameFiles();
            string cadena = "";

            cadena += DateTime.Now + " - " + slog + Environment.NewLine;
            
            StreamWriter sw = new StreamWriter(Path + "/" + nombre,true);
            sw.Write(cadena);
            sw.Close();

        }

        private string GetNameFiles()
        {
            string nombre = "";

            nombre = "log_" + DateTime.Now.ToLongDateString() + "_" + DateTime.Now.Month + ".txt";

            return nombre;
        }

        private void CreateDirectory()
        {
            try
            {
                if (!Directory.Exists(Path))
                    Directory.CreateDirectory(Path);

              
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new Exception(ex.Message);
               
            }

        }

    }

    
}
