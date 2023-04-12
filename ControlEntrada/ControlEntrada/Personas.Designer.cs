namespace ControlEntrada
{
    partial class Personas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cedulaLabel;
            System.Windows.Forms.Label idPersonaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label primerApellidoLabel;
            System.Windows.Forms.Label segundoApellidoLabel;
            System.Windows.Forms.Label fichaLabel;
            System.Windows.Forms.Label huellaLabel;
            System.Windows.Forms.Label noDedoLabel;
            System.Windows.Forms.Label fotoLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personas));
            this.enrollmentControl1 = new DPFP.Gui.Enrollment.EnrollmentControl();
            this.entradaSalidaDataSet = new ControlEntrada.EntradaSalidaDataSet();
            this.personasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personasTableAdapter = new ControlEntrada.EntradaSalidaDataSetTableAdapters.PersonasTableAdapter();
            this.tableAdapterManager = new ControlEntrada.EntradaSalidaDataSetTableAdapters.TableAdapterManager();
            this.cedulaTextBox = new System.Windows.Forms.TextBox();
            this.idPersonaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.primerApellidoTextBox = new System.Windows.Forms.TextBox();
            this.segundoApellidoTextBox = new System.Windows.Forms.TextBox();
            this.fichaTextBox = new System.Windows.Forms.TextBox();
            this.huellaPictureBox = new System.Windows.Forms.PictureBox();
            this.noDedoTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUploadPhoto = new System.Windows.Forms.Button();
            this.fotoPictureBox1 = new System.Windows.Forms.PictureBox();
            cedulaLabel = new System.Windows.Forms.Label();
            idPersonaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            primerApellidoLabel = new System.Windows.Forms.Label();
            segundoApellidoLabel = new System.Windows.Forms.Label();
            fichaLabel = new System.Windows.Forms.Label();
            huellaLabel = new System.Windows.Forms.Label();
            noDedoLabel = new System.Windows.Forms.Label();
            fotoLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.entradaSalidaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huellaPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cedulaLabel
            // 
            cedulaLabel.AutoSize = true;
            cedulaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cedulaLabel.Location = new System.Drawing.Point(23, 354);
            cedulaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cedulaLabel.Name = "cedulaLabel";
            cedulaLabel.Size = new System.Drawing.Size(63, 20);
            cedulaLabel.TabIndex = 3;
            cedulaLabel.Text = "Cedula:";
            // 
            // idPersonaLabel
            // 
            idPersonaLabel.AutoSize = true;
            idPersonaLabel.Location = new System.Drawing.Point(4, 25);
            idPersonaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idPersonaLabel.Name = "idPersonaLabel";
            idPersonaLabel.Size = new System.Drawing.Size(90, 20);
            idPersonaLabel.TabIndex = 5;
            idPersonaLabel.Text = "Id Persona:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(197, 354);
            nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(69, 20);
            nombreLabel.TabIndex = 9;
            nombreLabel.Text = "Nombre:";
            // 
            // primerApellidoLabel
            // 
            primerApellidoLabel.AutoSize = true;
            primerApellidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            primerApellidoLabel.Location = new System.Drawing.Point(363, 354);
            primerApellidoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            primerApellidoLabel.Name = "primerApellidoLabel";
            primerApellidoLabel.Size = new System.Drawing.Size(118, 20);
            primerApellidoLabel.TabIndex = 11;
            primerApellidoLabel.Text = "Primer Apellido:";
            // 
            // segundoApellidoLabel
            // 
            segundoApellidoLabel.AutoSize = true;
            segundoApellidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            segundoApellidoLabel.Location = new System.Drawing.Point(531, 354);
            segundoApellidoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            segundoApellidoLabel.Name = "segundoApellidoLabel";
            segundoApellidoLabel.Size = new System.Drawing.Size(138, 20);
            segundoApellidoLabel.TabIndex = 13;
            segundoApellidoLabel.Text = "Segundo Apellido:";
            // 
            // fichaLabel
            // 
            fichaLabel.AutoSize = true;
            fichaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fichaLabel.Location = new System.Drawing.Point(686, 354);
            fichaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fichaLabel.Name = "fichaLabel";
            fichaLabel.Size = new System.Drawing.Size(52, 20);
            fichaLabel.TabIndex = 15;
            fichaLabel.Text = "Ficha:";
            // 
            // huellaLabel
            // 
            huellaLabel.AutoSize = true;
            huellaLabel.Location = new System.Drawing.Point(18, 60);
            huellaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            huellaLabel.Name = "huellaLabel";
            huellaLabel.Size = new System.Drawing.Size(58, 20);
            huellaLabel.TabIndex = 17;
            huellaLabel.Text = "Huella:";
            // 
            // noDedoLabel
            // 
            noDedoLabel.AutoSize = true;
            noDedoLabel.Location = new System.Drawing.Point(16, 166);
            noDedoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            noDedoLabel.Name = "noDedoLabel";
            noDedoLabel.Size = new System.Drawing.Size(76, 20);
            noDedoLabel.TabIndex = 19;
            noDedoLabel.Text = "No Dedo:";
            // 
            // fotoLabel1
            // 
            fotoLabel1.AutoSize = true;
            fotoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fotoLabel1.Location = new System.Drawing.Point(623, 34);
            fotoLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fotoLabel1.Name = "fotoLabel1";
            fotoLabel1.Size = new System.Drawing.Size(46, 20);
            fotoLabel1.TabIndex = 26;
            fotoLabel1.Text = "Foto:";
            // 
            // enrollmentControl1
            // 
            this.enrollmentControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enrollmentControl1.EnrolledFingerMask = 0;
            this.enrollmentControl1.Location = new System.Drawing.Point(15, 14);
            this.enrollmentControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.enrollmentControl1.MaxEnrollFingerCount = 10;
            this.enrollmentControl1.Name = "enrollmentControl1";
            this.enrollmentControl1.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.enrollmentControl1.Size = new System.Drawing.Size(492, 314);
            this.enrollmentControl1.TabIndex = 0;
            this.enrollmentControl1.OnDelete += new DPFP.Gui.Enrollment.EnrollmentControl._OnDelete(this.enrollmentControl1_OnDelete);
            this.enrollmentControl1.OnEnroll += new DPFP.Gui.Enrollment.EnrollmentControl._OnEnroll(this.enrollmentControl1_OnEnroll_1);
            this.enrollmentControl1.OnStartEnroll += new DPFP.Gui.Enrollment.EnrollmentControl._OnStartEnroll(this.enrollmentControl1_OnStartEnroll);
            // 
            // entradaSalidaDataSet
            // 
            this.entradaSalidaDataSet.DataSetName = "EntradaSalidaDataSet";
            this.entradaSalidaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personasBindingSource
            // 
            this.personasBindingSource.DataMember = "Personas";
            this.personasBindingSource.DataSource = this.entradaSalidaDataSet;
            // 
            // personasTableAdapter
            // 
            this.personasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PersonasTableAdapter = this.personasTableAdapter;
            this.tableAdapterManager.RegistrosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ControlEntrada.EntradaSalidaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cedulaTextBox
            // 
            this.cedulaTextBox.Location = new System.Drawing.Point(27, 379);
            this.cedulaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cedulaTextBox.Name = "cedulaTextBox";
            this.cedulaTextBox.Size = new System.Drawing.Size(148, 26);
            this.cedulaTextBox.TabIndex = 4;
            // 
            // idPersonaTextBox
            // 
            this.idPersonaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "IdPersona", true));
            this.idPersonaTextBox.Location = new System.Drawing.Point(105, 20);
            this.idPersonaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idPersonaTextBox.Name = "idPersonaTextBox";
            this.idPersonaTextBox.Size = new System.Drawing.Size(148, 26);
            this.idPersonaTextBox.TabIndex = 6;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(201, 379);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(148, 26);
            this.nombreTextBox.TabIndex = 10;
            // 
            // primerApellidoTextBox
            // 
            this.primerApellidoTextBox.Location = new System.Drawing.Point(367, 379);
            this.primerApellidoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.primerApellidoTextBox.Name = "primerApellidoTextBox";
            this.primerApellidoTextBox.Size = new System.Drawing.Size(148, 26);
            this.primerApellidoTextBox.TabIndex = 12;
            // 
            // segundoApellidoTextBox
            // 
            this.segundoApellidoTextBox.Location = new System.Drawing.Point(534, 379);
            this.segundoApellidoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.segundoApellidoTextBox.Name = "segundoApellidoTextBox";
            this.segundoApellidoTextBox.Size = new System.Drawing.Size(148, 26);
            this.segundoApellidoTextBox.TabIndex = 14;
            // 
            // fichaTextBox
            // 
            this.fichaTextBox.Location = new System.Drawing.Point(690, 379);
            this.fichaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fichaTextBox.Name = "fichaTextBox";
            this.fichaTextBox.Size = new System.Drawing.Size(148, 26);
            this.fichaTextBox.TabIndex = 16;
            // 
            // huellaPictureBox
            // 
            this.huellaPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.personasBindingSource, "Huella", true));
            this.huellaPictureBox.Location = new System.Drawing.Point(87, 60);
            this.huellaPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.huellaPictureBox.Name = "huellaPictureBox";
            this.huellaPictureBox.Size = new System.Drawing.Size(150, 77);
            this.huellaPictureBox.TabIndex = 18;
            this.huellaPictureBox.TabStop = false;
            // 
            // noDedoTextBox
            // 
            this.noDedoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "NoDedo", true));
            this.noDedoTextBox.Location = new System.Drawing.Point(105, 162);
            this.noDedoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.noDedoTextBox.Name = "noDedoTextBox";
            this.noDedoTextBox.Size = new System.Drawing.Size(148, 26);
            this.noDedoTextBox.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(idPersonaLabel);
            this.panel1.Controls.Add(noDedoLabel);
            this.panel1.Controls.Add(this.noDedoTextBox);
            this.panel1.Controls.Add(this.idPersonaTextBox);
            this.panel1.Controls.Add(this.huellaPictureBox);
            this.panel1.Controls.Add(huellaLabel);
            this.panel1.Location = new System.Drawing.Point(829, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 20);
            this.panel1.TabIndex = 21;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(416, 423);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 34);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(312, 423);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 34);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(747, 190);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 44);
            this.button1.TabIndex = 29;
            this.button1.Text = "Eliminar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUploadPhoto
            // 
            this.btnUploadPhoto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUploadPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadPhoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUploadPhoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnUploadPhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUploadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadPhoto.Image = ((System.Drawing.Image)(resources.GetObject("btnUploadPhoto.Image")));
            this.btnUploadPhoto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUploadPhoto.Location = new System.Drawing.Point(747, 135);
            this.btnUploadPhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.Size = new System.Drawing.Size(57, 45);
            this.btnUploadPhoto.TabIndex = 28;
            this.btnUploadPhoto.Text = "Subir Foto";
            this.btnUploadPhoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUploadPhoto.UseVisualStyleBackColor = true;
            this.btnUploadPhoto.Click += new System.EventHandler(this.btnUploadPhoto_Click);
            // 
            // fotoPictureBox1
            // 
            this.fotoPictureBox1.Location = new System.Drawing.Point(558, 72);
            this.fotoPictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fotoPictureBox1.Name = "fotoPictureBox1";
            this.fotoPictureBox1.Size = new System.Drawing.Size(170, 223);
            this.fotoPictureBox1.TabIndex = 27;
            this.fotoPictureBox1.TabStop = false;
            // 
            // Personas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUploadPhoto);
            this.Controls.Add(fotoLabel1);
            this.Controls.Add(this.fotoPictureBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(fichaLabel);
            this.Controls.Add(this.fichaTextBox);
            this.Controls.Add(segundoApellidoLabel);
            this.Controls.Add(this.segundoApellidoTextBox);
            this.Controls.Add(primerApellidoLabel);
            this.Controls.Add(this.primerApellidoTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(cedulaLabel);
            this.Controls.Add(this.cedulaTextBox);
            this.Controls.Add(this.enrollmentControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Personas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarPersona";
            this.Load += new System.EventHandler(this.AgregarPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.entradaSalidaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huellaPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EntradaSalidaDataSet entradaSalidaDataSet;
        private System.Windows.Forms.BindingSource personasBindingSource;
        private EntradaSalidaDataSetTableAdapters.PersonasTableAdapter personasTableAdapter;
        private EntradaSalidaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idPersonaTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUploadPhoto;
        public System.Windows.Forms.TextBox cedulaTextBox;
        public System.Windows.Forms.TextBox nombreTextBox;
        public System.Windows.Forms.TextBox primerApellidoTextBox;
        public System.Windows.Forms.TextBox segundoApellidoTextBox;
        public System.Windows.Forms.TextBox fichaTextBox;
        public System.Windows.Forms.PictureBox huellaPictureBox;
        public System.Windows.Forms.TextBox noDedoTextBox;
        public System.Windows.Forms.PictureBox fotoPictureBox1;
        public DPFP.Gui.Enrollment.EnrollmentControl enrollmentControl1;
    }
}