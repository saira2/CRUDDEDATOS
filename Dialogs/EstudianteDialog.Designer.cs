namespace ClasesProgramacion.Dialogs
{
    partial class EstudianteDialog
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
            System.Windows.Forms.Label identidadLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label fechanacLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label observacionLabel;
            this.identidadTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.fechanacDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.observacionTextBox = new System.Windows.Forms.TextBox();
            identidadLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            fechanacLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            observacionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(365, 244);
            this.btnGuardar.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(462, 244);
            this.btnCancelar.TabIndex = 8;
            // 
            // identidadLabel
            // 
            identidadLabel.AutoSize = true;
            identidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            identidadLabel.Location = new System.Drawing.Point(2, 28);
            identidadLabel.Name = "identidadLabel";
            identidadLabel.Size = new System.Drawing.Size(71, 15);
            identidadLabel.TabIndex = 3;
            identidadLabel.Text = "Identidad:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombresLabel.Location = new System.Drawing.Point(2, 66);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(69, 15);
            nombresLabel.TabIndex = 5;
            nombresLabel.Text = "Nombres:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidosLabel.Location = new System.Drawing.Point(2, 95);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(70, 15);
            apellidosLabel.TabIndex = 7;
            apellidosLabel.Text = "Apellidos:";
            // 
            // fechanacLabel
            // 
            fechanacLabel.AutoSize = true;
            fechanacLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechanacLabel.Location = new System.Drawing.Point(188, 28);
            fechanacLabel.Name = "fechanacLabel";
            fechanacLabel.Size = new System.Drawing.Size(80, 15);
            fechanacLabel.TabIndex = 9;
            fechanacLabel.Text = "Nacimiento";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexoLabel.Location = new System.Drawing.Point(381, 28);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(43, 15);
            sexoLabel.TabIndex = 11;
            sexoLabel.Text = "Sexo:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(2, 141);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(72, 15);
            direccionLabel.TabIndex = 13;
            direccionLabel.Text = "Dirección:";
            // 
            // observacionLabel
            // 
            observacionLabel.AutoSize = true;
            observacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            observacionLabel.Location = new System.Drawing.Point(2, 200);
            observacionLabel.Name = "observacionLabel";
            observacionLabel.Size = new System.Drawing.Size(90, 15);
            observacionLabel.TabIndex = 15;
            observacionLabel.Text = "Observación:";
            // 
            // identidadTextBox
            // 
            this.identidadTextBox.Location = new System.Drawing.Point(100, 28);
            this.identidadTextBox.Name = "identidadTextBox";
            this.identidadTextBox.Size = new System.Drawing.Size(82, 20);
            this.identidadTextBox.TabIndex = 0;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombresTextBox.Location = new System.Drawing.Point(98, 66);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(439, 20);
            this.nombresTextBox.TabIndex = 3;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.apellidosTextBox.Location = new System.Drawing.Point(98, 94);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(439, 20);
            this.apellidosTextBox.TabIndex = 4;
            // 
            // fechanacDateTimePicker
            // 
            this.fechanacDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechanacDateTimePicker.Location = new System.Drawing.Point(280, 28);
            this.fechanacDateTimePicker.Name = "fechanacDateTimePicker";
            this.fechanacDateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.fechanacDateTimePicker.TabIndex = 1;
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.sexoComboBox.Location = new System.Drawing.Point(430, 31);
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(107, 21);
            this.sexoComboBox.TabIndex = 2;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.direccionTextBox.Location = new System.Drawing.Point(98, 129);
            this.direccionTextBox.Multiline = true;
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(439, 48);
            this.direccionTextBox.TabIndex = 5;
            // 
            // observacionTextBox
            // 
            this.observacionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.observacionTextBox.Location = new System.Drawing.Point(98, 183);
            this.observacionTextBox.Multiline = true;
            this.observacionTextBox.Name = "observacionTextBox";
            this.observacionTextBox.Size = new System.Drawing.Size(439, 55);
            this.observacionTextBox.TabIndex = 6;
            // 
            // EstudianteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 285);
            this.Controls.Add(identidadLabel);
            this.Controls.Add(this.identidadTextBox);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(fechanacLabel);
            this.Controls.Add(this.fechanacDateTimePicker);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.sexoComboBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(observacionLabel);
            this.Controls.Add(this.observacionTextBox);
            this.Name = "EstudianteDialog";
            this.Text = "Información del estudiante";
            this.Load += new System.EventHandler(this.EstudianteDialog_Load);
            this.Controls.SetChildIndex(this.observacionTextBox, 0);
            this.Controls.SetChildIndex(observacionLabel, 0);
            this.Controls.SetChildIndex(this.direccionTextBox, 0);
            this.Controls.SetChildIndex(direccionLabel, 0);
            this.Controls.SetChildIndex(this.sexoComboBox, 0);
            this.Controls.SetChildIndex(sexoLabel, 0);
            this.Controls.SetChildIndex(this.fechanacDateTimePicker, 0);
            this.Controls.SetChildIndex(fechanacLabel, 0);
            this.Controls.SetChildIndex(this.apellidosTextBox, 0);
            this.Controls.SetChildIndex(apellidosLabel, 0);
            this.Controls.SetChildIndex(this.nombresTextBox, 0);
            this.Controls.SetChildIndex(nombresLabel, 0);
            this.Controls.SetChildIndex(this.identidadTextBox, 0);
            this.Controls.SetChildIndex(identidadLabel, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox identidadTextBox;
        public System.Windows.Forms.TextBox nombresTextBox;
        public System.Windows.Forms.TextBox apellidosTextBox;
        public System.Windows.Forms.DateTimePicker fechanacDateTimePicker;
        public System.Windows.Forms.ComboBox sexoComboBox;
        public System.Windows.Forms.TextBox direccionTextBox;
        public System.Windows.Forms.TextBox observacionTextBox;
    }
}