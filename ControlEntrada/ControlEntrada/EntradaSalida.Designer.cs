namespace ControlEntrada
{
    partial class EntradaSalida
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
            System.Windows.Forms.Label idPersonaLabel;
            System.Windows.Forms.Label fotoLabel;
            System.Windows.Forms.Label cedulaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label primerApellidoLabel;
            System.Windows.Forms.Label segundoApellidoLabel;
            System.Windows.Forms.Label fichaLabel;
            System.Windows.Forms.Label label4;
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.verificationControl1 = new DPFP.Gui.Verification.VerificationControl();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.idPersonaTextBox = new System.Windows.Forms.TextBox();
            this.personasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entradaSalidaDataSet = new ControlEntrada.EntradaSalidaDataSet();
            this.fichaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.segundoApellidoTextBox = new System.Windows.Forms.TextBox();
            this.primerApellidoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.cedulaTextBox = new System.Windows.Forms.TextBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.personasTableAdapter = new ControlEntrada.EntradaSalidaDataSetTableAdapters.PersonasTableAdapter();
            this.tableAdapterManager = new ControlEntrada.EntradaSalidaDataSetTableAdapters.TableAdapterManager();
            idPersonaLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            cedulaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            primerApellidoLabel = new System.Windows.Forms.Label();
            segundoApellidoLabel = new System.Windows.Forms.Label();
            fichaLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaSalidaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // idPersonaLabel
            // 
            idPersonaLabel.AutoSize = true;
            idPersonaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idPersonaLabel.Location = new System.Drawing.Point(3, 16);
            idPersonaLabel.Name = "idPersonaLabel";
            idPersonaLabel.Size = new System.Drawing.Size(101, 20);
            idPersonaLabel.TabIndex = 0;
            idPersonaLabel.Text = "Id Persona:";
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fotoLabel.Location = new System.Drawing.Point(68, 17);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(51, 20);
            fotoLabel.TabIndex = 2;
            fotoLabel.Text = "Foto:";
            // 
            // cedulaLabel
            // 
            cedulaLabel.AutoSize = true;
            cedulaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cedulaLabel.Location = new System.Drawing.Point(185, 83);
            cedulaLabel.Name = "cedulaLabel";
            cedulaLabel.Size = new System.Drawing.Size(70, 20);
            cedulaLabel.TabIndex = 4;
            cedulaLabel.Text = "Cedula:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(185, 124);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(76, 20);
            nombreLabel.TabIndex = 6;
            nombreLabel.Text = "Nombre:";
            // 
            // primerApellidoLabel
            // 
            primerApellidoLabel.AutoSize = true;
            primerApellidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            primerApellidoLabel.Location = new System.Drawing.Point(185, 165);
            primerApellidoLabel.Name = "primerApellidoLabel";
            primerApellidoLabel.Size = new System.Drawing.Size(134, 20);
            primerApellidoLabel.TabIndex = 8;
            primerApellidoLabel.Text = "Primer Apellido:";
            // 
            // segundoApellidoLabel
            // 
            segundoApellidoLabel.AutoSize = true;
            segundoApellidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            segundoApellidoLabel.Location = new System.Drawing.Point(185, 206);
            segundoApellidoLabel.Name = "segundoApellidoLabel";
            segundoApellidoLabel.Size = new System.Drawing.Size(155, 20);
            segundoApellidoLabel.TabIndex = 10;
            segundoApellidoLabel.Text = "Segundo Apellido:";
            // 
            // fichaLabel
            // 
            fichaLabel.AutoSize = true;
            fichaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fichaLabel.Location = new System.Drawing.Point(185, 41);
            fichaLabel.Name = "fichaLabel";
            fichaLabel.Size = new System.Drawing.Size(58, 20);
            fichaLabel.TabIndex = 14;
            fichaLabel.Text = "Ficha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(468, 16);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(108, 20);
            label4.TabIndex = 18;
            label4.Text = "Verificación:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(680, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(52, 53);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro Entrada y Salida";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 53);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.verificationControl1);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(this.Resultado);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(fichaLabel);
            this.groupBox1.Controls.Add(this.fichaTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(segundoApellidoLabel);
            this.groupBox1.Controls.Add(this.segundoApellidoTextBox);
            this.groupBox1.Controls.Add(primerApellidoLabel);
            this.groupBox1.Controls.Add(this.primerApellidoTextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(cedulaLabel);
            this.groupBox1.Controls.Add(this.cedulaTextBox);
            this.groupBox1.Controls.Add(fotoLabel);
            this.groupBox1.Controls.Add(this.fotoPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(31, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 388);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // verificationControl1
            // 
            this.verificationControl1.Active = true;
            this.verificationControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.verificationControl1.Location = new System.Drawing.Point(593, 19);
            this.verificationControl1.Name = "verificationControl1";
            this.verificationControl1.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.verificationControl1.Size = new System.Drawing.Size(48, 47);
            this.verificationControl1.TabIndex = 19;
            this.verificationControl1.OnComplete += new DPFP.Gui.Verification.VerificationControl._OnComplete(this.verificationControl1_OnComplete);
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(472, 39);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(100, 20);
            this.Resultado.TabIndex = 17;
            this.Resultado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(idPersonaLabel);
            this.panel2.Controls.Add(this.idPersonaTextBox);
            this.panel2.Location = new System.Drawing.Point(6, 362);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(29, 20);
            this.panel2.TabIndex = 16;
            // 
            // idPersonaTextBox
            // 
            this.idPersonaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "IdPersona", true));
            this.idPersonaTextBox.Enabled = false;
            this.idPersonaTextBox.Location = new System.Drawing.Point(97, 39);
            this.idPersonaTextBox.Name = "idPersonaTextBox";
            this.idPersonaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idPersonaTextBox.TabIndex = 1;
            // 
            // personasBindingSource
            // 
            this.personasBindingSource.DataMember = "Personas";
            this.personasBindingSource.DataSource = this.entradaSalidaDataSet;
            // 
            // entradaSalidaDataSet
            // 
            this.entradaSalidaDataSet.DataSetName = "EntradaSalidaDataSet";
            this.entradaSalidaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fichaTextBox
            // 
            this.fichaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "Ficha", true));
            this.fichaTextBox.Enabled = false;
            this.fichaTextBox.Location = new System.Drawing.Point(344, 41);
            this.fichaTextBox.Name = "fichaTextBox";
            this.fichaTextBox.Size = new System.Drawing.Size(100, 20);
            this.fichaTextBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(85, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 39);
            this.label3.TabIndex = 13;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(85, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 39);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // segundoApellidoTextBox
            // 
            this.segundoApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "SegundoApellido", true));
            this.segundoApellidoTextBox.Enabled = false;
            this.segundoApellidoTextBox.Location = new System.Drawing.Point(344, 206);
            this.segundoApellidoTextBox.Name = "segundoApellidoTextBox";
            this.segundoApellidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.segundoApellidoTextBox.TabIndex = 11;
            // 
            // primerApellidoTextBox
            // 
            this.primerApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "PrimerApellido", true));
            this.primerApellidoTextBox.Enabled = false;
            this.primerApellidoTextBox.Location = new System.Drawing.Point(344, 165);
            this.primerApellidoTextBox.Name = "primerApellidoTextBox";
            this.primerApellidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.primerApellidoTextBox.TabIndex = 9;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "Nombre", true));
            this.nombreTextBox.Enabled = false;
            this.nombreTextBox.Location = new System.Drawing.Point(344, 124);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 7;
            // 
            // cedulaTextBox
            // 
            this.cedulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "Cedula", true));
            this.cedulaTextBox.Enabled = false;
            this.cedulaTextBox.Location = new System.Drawing.Point(344, 83);
            this.cedulaTextBox.Name = "cedulaTextBox";
            this.cedulaTextBox.Size = new System.Drawing.Size(100, 20);
            this.cedulaTextBox.TabIndex = 5;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.personasBindingSource, "Foto", true));
            this.fotoPictureBox.Enabled = false;
            this.fotoPictureBox.Location = new System.Drawing.Point(29, 40);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(133, 173);
            this.fotoPictureBox.TabIndex = 3;
            this.fotoPictureBox.TabStop = false;
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
            // EntradaSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 486);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntradaSalida";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntradaSalida";
            this.Load += new System.EventHandler(this.EntradaSalida_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaSalidaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private EntradaSalidaDataSet entradaSalidaDataSet;
        private System.Windows.Forms.BindingSource personasBindingSource;
        private EntradaSalidaDataSetTableAdapters.PersonasTableAdapter personasTableAdapter;
        private EntradaSalidaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox segundoApellidoTextBox;
        private System.Windows.Forms.TextBox primerApellidoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox cedulaTextBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.TextBox idPersonaTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox fichaTextBox;
        public System.Windows.Forms.TextBox Resultado;
        private DPFP.Gui.Verification.VerificationControl verificationControl1;
    }
}