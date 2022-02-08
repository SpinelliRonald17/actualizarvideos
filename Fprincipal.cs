using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Microsoft.VisualBasic.Devices;
//using System.IO.Compression;
using System.Xml.Schema;
using System.Configuration;
using ActualizadorVideos.Clases;
using System.Text.RegularExpressions;
using Ionic.Zip;

namespace ActualizadorVideos
{
    //#############################################
    // ## Autor: Ronald Jesus Contreras Spinelli ##
    // ## Fecha: 01-11-2020                      ##
    // ## inspiración mis 2 hijos                ##
    //#############################################

    public partial class Fprincipal : Form
    {
        #region Rutas config
        // Configuracion por el config: Ruta para cambiar la ubicacion de la ruta donde se van a sustituir los archivos
        string stRutaUbicacionArchivosSustituir = ConfigurationSettings.AppSettings["stRutaUbicacionArchivosSustituir"].ToString();

        // Configuracion por el config: Ruta para cambiar el nombre donde se van a sustituir los archivos
        string stRutaCambiarNombreCarpeta = ConfigurationSettings.AppSettings["stRutaCambiarNombreCarpeta"].ToString();
        
        //Ubicacion de carpeta donde se va a guardar los Archivos
        string carpeta = Application.StartupPath + @"\Archivos";

        //Ubicacion de carpeta donde se va a guardar los logs
        string logsEventos = Application.StartupPath + @"\logs";

        string[] todaCarpeta;

        // Así accederemos al "FileSystem"
        Computer mycomputer = new Computer();
        #endregion

        #region InitializeComponent
        public Fprincipal()
        {
            InitializeComponent();

            // Configuracion por el config para ser automatico o cambiar el nombre de la carpeta a sutituir
            txtMenuCambiarNombreCarpetaEdit.Text = Properties.Settings.Default.NombreCarpetas ?? "";

            // Configuracion por el config para cambiar el link de descarga
            txtLinkNuevoEdit.Text = Properties.Settings.Default.LinkDescargas ?? "";

        }
        // Parametro de link
        WebClient cliente = new WebClient();
        string ruta = null;
        #endregion

        #region Fprincipal_Load
        private void Fprincipal_Load(object sender, EventArgs e)
        {
            timer1.Start();// Actualiza la fecha 
            cliente.DownloadProgressChanged += new DownloadProgressChangedEventHandler(cargando); // Muestra la carga de la barra y el porcentaje
            cliente.DownloadFileCompleted += new AsyncCompletedEventHandler(descargado); // Descarga, descomprime y sutituye archivos 
        }
        #endregion

        #region Carga y descarga
        private void cargando(object sender, DownloadProgressChangedEventArgs e)
        {   // Muestra la carga de la barra y el porcentaje
            toolStripProgressBar1.Value = e.ProgressPercentage;
            lbprogreso.Text = toolStripProgressBar1.Value.ToString() + "%";
            toolStripStatusLabel1.Text = "Por favor espere se están descargando los archivos...";
            pictureBox1.Visible = true;
        }

        private void descargado(object sender, AsyncCompletedEventArgs e)
        {   // Descarga, descomprime y sutituye archivos 

            //cear carpeta donde se instale la app
            try
            {
                //El directorio existe NO crear carpeta 
                if (Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta); Directory.Delete(carpeta, true);
                }

                // Descomprimir el archivo .zip descargado en la ruta donde esta el app
                //ZipFile.ExtractToDirectory(txtRutaGuardarArchivo.Text.Trim(), carpeta); // metodo extrae con caracteres especiales

                DescromprimirZip(txtRutaGuardarArchivo.Text, carpeta);

                Application.DoEvents();

                toolStripStatusLabel1.Text = "Se están descomprimiendo los archivos...";

                Application.DoEvents();

                // Renombrar el archivo descomprimido
                mycomputer.FileSystem.RenameDirectory(stRutaCambiarNombreCarpeta.Trim(), txtMenuCambiarNombreCarpetaEdit.Text.Trim());

                Application.DoEvents();

                toolStripStatusLabel1.Text = "Estamos renombrando el archivo...";

                // Mover el documento descomprimido de la ruta donde esta el app a la ruta donde se desea sustituir o actualizar los documentos
                Application.DoEvents();

                mycomputer.FileSystem.CopyDirectory(carpeta.ToString(), stRutaUbicacionArchivosSustituir.Trim(), true);

                Application.DoEvents();

                toolStripStatusLabel1.Text = "Espere un momento estamos moviendo los archivos...";

                Application.DoEvents();

                pictureBox1.Visible = false;

                Application.DoEvents();

                toolStripStatusLabel1.Text = "Archivos sustituidos correctamente...";

                Application.DoEvents();

                MessageBox.Show("Proceso Finalizado...!!", "Informacion..!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                pictureBox1.Visible = false;
                toolStripStatusLabel1.Text = "Error (404) por favor verificar: Logs y Ayuda...";
                lbprogreso.Text = "0%";
                toolStripProgressBar1.Value = 0;
                MessageBox.Show("Error (404) por favor verificar que el link sea el permitido para la aplicación (Aire Scav) \nLeer Logs de Error \nLeer la ayuda", "Importante..!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("Error debido a: " + ex.ToString());
                logs oLogs = new logs(logsEventos);
                oLogs.Add(ex.Message);
            }
        }
        #endregion

        #region Guardar archivo
        private void btnDescargar_Click(object sender, EventArgs e)
        { //Descarga y guarda cualquier link si es zip lo descomprime y sustituye en una ruta indicada
            try
            {
                lbprogreso.Text = "0%";
                toolStripProgressBar1.Value = 0;
                this.toolStripStatusLabel1.Text = "Bienvenido...!!";

                SaveFileDialog dialogo = new SaveFileDialog();
                dialogo.InitialDirectory = @"C:\";
                dialogo.Filter = "zip|.zip";
                dialogo.AddExtension = true;
                dialogo.FileName = txturl.Text.Substring(txturl.Text.LastIndexOf("/") + 1);
                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    ruta = dialogo.FileName;
                    txtRutaGuardarArchivo.Text = dialogo.FileName;
                    cliente.DownloadFileAsync(new Uri(txturl.Text), dialogo.FileName);
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error (404) por favor verificar: Logs y Ayuda...";
                lbprogreso.Text = "0%";
                toolStripProgressBar1.Value = 0;
                MessageBox.Show("Error (404) por favor verificar que el link sea el permitido para la aplicación (Aire Scav) \nLeer Logs de Error \nLeer la ayuda", "Importante..!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("Error debido a: " + ex.ToString());
                logs oLogs = new logs(logsEventos);
                oLogs.Add(ex.Message);
            }
           
        }
        #endregion

        #region Btn buscar rutas
        private void btnMenuBuscarRutaCambiarCarpeta_Click(object sender, EventArgs e)
        {///btn menu buscar ruta de carpeta para cambiar el nombre donde se va a sustituir
            //var BuscarCarpetaCambiarNombre = new FolderBrowserDialog();
            //if (BuscarCarpetaCambiarNombre.ShowDialog() == DialogResult.OK)
            //{
                txtMenuBuscarRutaCambiarCarpetaEdit.Text = stRutaCambiarNombreCarpeta ;
            //}
        }

        private void btnBuscarRutaSustituir_Click(object sender, EventArgs e)
        {//btn menu buscar ruta de carpeta donde se va a sustituir
            var BuscarRutaCarpeta = new FolderBrowserDialog();
            if (BuscarRutaCarpeta.ShowDialog() == DialogResult.OK)
            {
                txtstRutaUbicacionArchivosSustituirEdit.Text = BuscarRutaCarpeta.SelectedPath;
            }
        }
        #endregion

        #region Eventos 
        private void timer1_Tick(object sender, EventArgs e)
        { // Actualiza la fecha del dia en formato dia con nombre y numero , mes nombre , año numero
            lblfecha.Text = DateTime.Now.ToLongDateString();
            
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        { // Btn Ayuda información 
            MessageBox.Show("1) Si el programa no descarga o esta dando algún error primero cierre y luego abra la aplicación. \n2) Leer Archivo Logs que esta en la ubicación donde se instalo la aplicación. \n3) Solo esta permitido: Los Link de (Aire Scav) que son archivos(.zip) \n4) Si el problema persiste por favor pasar un correo a (soporte@archicentro.com).", "Importante..!!", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void EventoCambioLink(object sender, EventArgs e)
        { //Evento para cambiar el link de descarga por el menu 
           txturl.Text = txtLinkNuevoEdit.Text;
            lbprogreso.Text = "0%";
            toolStripProgressBar1.Value = 0;
            this.toolStripStatusLabel1.Text = "Bienvenido...!!";
        }

        private void EventoCambiarRutaCambiarNombreCarpeta(object sender, EventArgs e)
        {// Evento cambiar Buscar RutaCambiar Carpetaa sustituir por app y por config
            stRutaCambiarNombreCarpeta = txtMenuBuscarRutaCambiarCarpetaEdit.Text;
        }

        private void EventoCambioRutaSitioSustituir(object sender, EventArgs e)
        {// Evento cambiar ruta a sustituir por app y por config
            stRutaUbicacionArchivosSustituir = txtstRutaUbicacionArchivosSustituirEdit.Text;
        }

        // Evento notificar para cerrar la app
        private void EventoCerrarApp(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes != MessageBox.Show(this,
             "¿Está seguro de salir de la aplicación?",
             "Cerrar",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button2))
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region contar archivos
        public void ShowFiles(String pathFrom, Boolean incDirs)
        {
            // Si el subdirectorio está activo
            if (incDirs)
            {
                string[] allfiles = Directory.GetFiles(pathFrom, "*.*", SearchOption.AllDirectories);
                // Establecer el valor mínimo para la barra
                //toolStripProgressBar1.Minimum = 0;
                //Establecer el valor de la barra de longitud máxima relacionada con los archivos encontrados
                //toolStripProgressBar1.Maximum = allfiles.Length;
                // Acción para cada archivo
                foreach (var file in allfiles)
                {
                    // Aumenta la barra para cada archivo encontrado
                    toolStripProgressBar1.Increment(1);
                    FileInfo info = new FileInfo(file);
                }
                // Acumular archivos
                //lblTotalArchivos.Text = "Total de archivos leídos = " + toolStripProgressBar1.Value.ToString();
                //System.Windows.Forms.MessageBox.Show("Archivos encontrados: " + allfiles.Length.ToString(), "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //// Barra de reinicio
                //toolStripProgressBar1.Value = 0;
            }
            else
            {
                // Obtener archivos
                string[] files = Directory.GetFiles(pathFrom);
                // Establecer el valor mínimo para la barra
                //toolStripProgressBar1.Minimum = 0;
                // Establecer el valor de la barra de longitud máxima relacionada con los archivos encontrados
                //toolStripProgressBar1.Maximum = files.Length;
                foreach (var file in files)
                {
                    //Aumenta la barra para cada archivo encontrado
                    //toolStripProgressBar1.Increment(1);
                    FileInfo info = new FileInfo(file);
                }
                // Acumular archivos
                //lblTotalArchivos.Text = "Total de archivos leídos = " + toolStripProgressBar1.Value.ToString();
                //System.Windows.Forms.MessageBox.Show("Archivos encontrados: " + files.Length.ToString(), "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //// Barra de reinicio
                //toolStripProgressBar1.Value = 0;
            }
        }

        #endregion

        #region Metdo descomprimir Ionic.Zip
        // Descomprimir el archivo .zip descargado en la ruta donde esta el app
        static public Boolean DescromprimirZip(string ArchivoZip, string RutaGuardar)
        {
            try
            {
                using (ZipFile zip = ZipFile.Read(ArchivoZip))
                {

                    zip.ExtractAll(RutaGuardar);
                    zip.Dispose();

                }

                return true;
            }
            catch
            {
                return false;
            }

        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            string carpetaS = Application.StartupPath ;

            //El directorio existe NO crear carpeta 
            if (Directory.Exists(carpetaS))
            {
                MessageBox.Show("Existe");
            }
            else
            {
                Directory.CreateDirectory(carpetaS);
            }

            //string folderName = @"C:\Users\Soporte Sistemas\source\repos\ActualizadorVideos\bin\Debug\Archivos";

            //// To create a string that specifies the path to a subfolder under your
            //// top-level folder, add a name for the subfolder to folderName.
            //string pathString = System.IO.Path.Combine(folderName, "SubFolder");

        }
    }





}
