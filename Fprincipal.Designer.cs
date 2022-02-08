namespace ActualizadorVideos
{
    partial class Fprincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fprincipal));
            this.txtRutaGuardarArchivo = new System.Windows.Forms.TextBox();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.txturl = new System.Windows.Forms.TextBox();
            this.lbprogreso = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnMenuCmabiarLink = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuCambiarLinkManual = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLinkNuevoEdit = new System.Windows.Forms.ToolStripTextBox();
            this.btnCambiarRutaDescarga = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuscarRutaSustituirC = new System.Windows.Forms.ToolStripMenuItem();
            this.txtstRutaUbicacionArchivosSustituirEdit = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuBuscarRuta = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuBuscarRutaCambiarCarpetaEdit = new System.Windows.Forms.ToolStripTextBox();
            this.btnMenuCambiarNombreCarpeta = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuCambiarNombreCarpetaEdit = new System.Windows.Forms.ToolStripTextBox();
            this.btnAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblfecha = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.notaAgregarNombreDeCarpetaATrabajarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRutaGuardarArchivo
            // 
            this.txtRutaGuardarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRutaGuardarArchivo.Location = new System.Drawing.Point(12, 93);
            this.txtRutaGuardarArchivo.Name = "txtRutaGuardarArchivo";
            this.txtRutaGuardarArchivo.ReadOnly = true;
            this.txtRutaGuardarArchivo.Size = new System.Drawing.Size(644, 26);
            this.txtRutaGuardarArchivo.TabIndex = 0;
            // 
            // btnDescargar
            // 
            this.btnDescargar.AccessibleDescription = "";
            this.btnDescargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargar.Image = ((System.Drawing.Image)(resources.GetObject("btnDescargar.Image")));
            this.btnDescargar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDescargar.Location = new System.Drawing.Point(662, 36);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(110, 41);
            this.btnDescargar.TabIndex = 1;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // txturl
            // 
            this.txturl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txturl.Location = new System.Drawing.Point(12, 46);
            this.txturl.Name = "txturl";
            this.txturl.ReadOnly = true;
            this.txturl.Size = new System.Drawing.Size(644, 26);
            this.txturl.TabIndex = 2;
            // 
            // lbprogreso
            // 
            this.lbprogreso.AutoSize = true;
            this.lbprogreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbprogreso.Location = new System.Drawing.Point(675, 95);
            this.lbprogreso.Name = "lbprogreso";
            this.lbprogreso.Size = new System.Drawing.Size(35, 24);
            this.lbprogreso.TabIndex = 4;
            this.lbprogreso.Text = "0%";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuCmabiarLink,
            this.btnAyuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnMenuCmabiarLink
            // 
            this.btnMenuCmabiarLink.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuCambiarLinkManual,
            this.toolStripMenuItem1,
            this.btnCambiarRutaDescarga});
            this.btnMenuCmabiarLink.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuCmabiarLink.Image")));
            this.btnMenuCmabiarLink.Name = "btnMenuCmabiarLink";
            this.btnMenuCmabiarLink.Size = new System.Drawing.Size(28, 20);
            // 
            // btnMenuCambiarLinkManual
            // 
            this.btnMenuCambiarLinkManual.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtLinkNuevoEdit});
            this.btnMenuCambiarLinkManual.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuCambiarLinkManual.Image")));
            this.btnMenuCambiarLinkManual.Name = "btnMenuCambiarLinkManual";
            this.btnMenuCambiarLinkManual.Size = new System.Drawing.Size(285, 22);
            this.btnMenuCambiarLinkManual.Text = "&Cambiar link de descarga";
            // 
            // txtLinkNuevoEdit
            // 
            this.txtLinkNuevoEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLinkNuevoEdit.Name = "txtLinkNuevoEdit";
            this.txtLinkNuevoEdit.Size = new System.Drawing.Size(500, 23);
            this.txtLinkNuevoEdit.TextChanged += new System.EventHandler(this.EventoCambioLink);
            // 
            // btnCambiarRutaDescarga
            // 
            this.btnCambiarRutaDescarga.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBuscarRutaSustituirC});
            this.btnCambiarRutaDescarga.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiarRutaDescarga.Image")));
            this.btnCambiarRutaDescarga.Name = "btnCambiarRutaDescarga";
            this.btnCambiarRutaDescarga.Size = new System.Drawing.Size(285, 22);
            this.btnCambiarRutaDescarga.Text = "&Cambiar ruta a sustituir archivos";
            // 
            // btnBuscarRutaSustituirC
            // 
            this.btnBuscarRutaSustituirC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtstRutaUbicacionArchivosSustituirEdit});
            this.btnBuscarRutaSustituirC.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarRutaSustituirC.Image")));
            this.btnBuscarRutaSustituirC.Name = "btnBuscarRutaSustituirC";
            this.btnBuscarRutaSustituirC.Size = new System.Drawing.Size(180, 22);
            this.btnBuscarRutaSustituirC.Text = "Buscar ruta";
            this.btnBuscarRutaSustituirC.Click += new System.EventHandler(this.btnBuscarRutaSustituir_Click);
            // 
            // txtstRutaUbicacionArchivosSustituirEdit
            // 
            this.txtstRutaUbicacionArchivosSustituirEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtstRutaUbicacionArchivosSustituirEdit.Name = "txtstRutaUbicacionArchivosSustituirEdit";
            this.txtstRutaUbicacionArchivosSustituirEdit.ReadOnly = true;
            this.txtstRutaUbicacionArchivosSustituirEdit.Size = new System.Drawing.Size(400, 23);
            this.txtstRutaUbicacionArchivosSustituirEdit.TextChanged += new System.EventHandler(this.EventoCambioRutaSitioSustituir);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuBuscarRuta,
            this.btnMenuCambiarNombreCarpeta});
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(285, 22);
            this.toolStripMenuItem1.Text = "Cambiar nombre de carpeta descargada";
            // 
            // btnMenuBuscarRuta
            // 
            this.btnMenuBuscarRuta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtMenuBuscarRutaCambiarCarpetaEdit,
            this.notaAgregarNombreDeCarpetaATrabajarToolStripMenuItem});
            this.btnMenuBuscarRuta.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuBuscarRuta.Image")));
            this.btnMenuBuscarRuta.Name = "btnMenuBuscarRuta";
            this.btnMenuBuscarRuta.Size = new System.Drawing.Size(268, 22);
            this.btnMenuBuscarRuta.Text = "Ruta donde esta la carpeta a cambiar";
            this.btnMenuBuscarRuta.Click += new System.EventHandler(this.btnMenuBuscarRutaCambiarCarpeta_Click);
            // 
            // txtMenuBuscarRutaCambiarCarpetaEdit
            // 
            this.txtMenuBuscarRutaCambiarCarpetaEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMenuBuscarRutaCambiarCarpetaEdit.Name = "txtMenuBuscarRutaCambiarCarpetaEdit";
            this.txtMenuBuscarRutaCambiarCarpetaEdit.Size = new System.Drawing.Size(600, 23);
            this.txtMenuBuscarRutaCambiarCarpetaEdit.TextChanged += new System.EventHandler(this.EventoCambiarRutaCambiarNombreCarpeta);
            // 
            // btnMenuCambiarNombreCarpeta
            // 
            this.btnMenuCambiarNombreCarpeta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtMenuCambiarNombreCarpetaEdit});
            this.btnMenuCambiarNombreCarpeta.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuCambiarNombreCarpeta.Image")));
            this.btnMenuCambiarNombreCarpeta.Name = "btnMenuCambiarNombreCarpeta";
            this.btnMenuCambiarNombreCarpeta.Size = new System.Drawing.Size(268, 22);
            this.btnMenuCambiarNombreCarpeta.Text = "Nombre final de carpeta";
            // 
            // txtMenuCambiarNombreCarpetaEdit
            // 
            this.txtMenuCambiarNombreCarpetaEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMenuCambiarNombreCarpetaEdit.Name = "txtMenuCambiarNombreCarpetaEdit";
            this.txtMenuCambiarNombreCarpetaEdit.Size = new System.Drawing.Size(300, 23);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(69, 20);
            this.btnAyuda.Text = "&Ayuda";
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Link de Actualización:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "(Ruta a guardar zip)";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(592, 7);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(0, 13);
            this.lblfecha.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 127);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(776, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(400, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel1.Image")));
            this.toolStripStatusLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(362, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Bienvenido...!!";
            // 
            // notaAgregarNombreDeCarpetaATrabajarToolStripMenuItem
            // 
            this.notaAgregarNombreDeCarpetaATrabajarToolStripMenuItem.Name = "notaAgregarNombreDeCarpetaATrabajarToolStripMenuItem";
            this.notaAgregarNombreDeCarpetaATrabajarToolStripMenuItem.Size = new System.Drawing.Size(560, 22);
            this.notaAgregarNombreDeCarpetaATrabajarToolStripMenuItem.Text = "Agregar nombre de carpeta a trabajar :(Nombre de carpeta descomprimida) ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(735, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Fprincipal
            // 
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(776, 149);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbprogreso);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.txtRutaGuardarArchivo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Fprincipal";
            this.Text = "Actualizar Archivos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventoCerrarApp);
            this.Load += new System.EventHandler(this.Fprincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRutaGuardarArchivo;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.Label lbprogreso;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnMenuCmabiarLink;
        private System.Windows.Forms.ToolStripMenuItem btnAyuda;
        private System.Windows.Forms.ToolStripMenuItem btnMenuCambiarLinkManual;
        private System.Windows.Forms.ToolStripTextBox txtLinkNuevoEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.ToolStripMenuItem btnCambiarRutaDescarga;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnMenuBuscarRuta;
        private System.Windows.Forms.ToolStripTextBox txtMenuBuscarRutaCambiarCarpetaEdit;
        private System.Windows.Forms.ToolStripMenuItem btnMenuCambiarNombreCarpeta;
        private System.Windows.Forms.ToolStripTextBox txtMenuCambiarNombreCarpetaEdit;
        private System.Windows.Forms.ToolStripMenuItem btnBuscarRutaSustituirC;
        private System.Windows.Forms.ToolStripTextBox txtstRutaUbicacionArchivosSustituirEdit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem notaAgregarNombreDeCarpetaATrabajarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

