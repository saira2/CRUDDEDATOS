﻿namespace ClasesProgramacion.Dialogs
{
    partial class GastosDialog
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
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label subcategoriaLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label formapagoLabel;
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.subcategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.formapagoComboBox = new System.Windows.Forms.ComboBox();
            fechaLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            subcategoriaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            formapagoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(407, 259);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(506, 259);
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaLabel.Location = new System.Drawing.Point(18, 38);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(47, 18);
            fechaLabel.TabIndex = 3;
            fechaLabel.Text = "fecha:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoriaLabel.Location = new System.Drawing.Point(18, 95);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(71, 18);
            categoriaLabel.TabIndex = 5;
            categoriaLabel.Text = "Categoría:";
            // 
            // subcategoriaLabel
            // 
            subcategoriaLabel.AutoSize = true;
            subcategoriaLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            subcategoriaLabel.Location = new System.Drawing.Point(18, 145);
            subcategoriaLabel.Name = "subcategoriaLabel";
            subcategoriaLabel.Size = new System.Drawing.Size(92, 18);
            subcategoriaLabel.TabIndex = 7;
            subcategoriaLabel.Text = "subcategoría:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(18, 190);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(85, 18);
            descripcionLabel.TabIndex = 9;
            descripcionLabel.Text = "Descripción:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorLabel.Location = new System.Drawing.Point(202, 38);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(44, 18);
            valorLabel.TabIndex = 11;
            valorLabel.Text = "valor:";
            // 
            // formapagoLabel
            // 
            formapagoLabel.AutoSize = true;
            formapagoLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            formapagoLabel.Location = new System.Drawing.Point(356, 37);
            formapagoLabel.Name = "formapagoLabel";
            formapagoLabel.Size = new System.Drawing.Size(84, 18);
            formapagoLabel.TabIndex = 13;
            formapagoLabel.Text = "Forma pago:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(116, 35);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(77, 20);
            this.fechaDateTimePicker.TabIndex = 4;
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Items.AddRange(new object[] {
            "Alimentos",
            "Transporte",
            "Hogar",
            "Lavandería",
            "Diversión",
            "Personal"});
            this.categoriaComboBox.Location = new System.Drawing.Point(116, 92);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(478, 21);
            this.categoriaComboBox.TabIndex = 6;
            // 
            // subcategoriaComboBox
            // 
            this.subcategoriaComboBox.FormattingEnabled = true;
            this.subcategoriaComboBox.Items.AddRange(new object[] {
            "Supermercado",
            "Kiosko",
            "Restaurante",
            "Taxi",
            "Bus",
            "Mototaxi",
            "Electricidad",
            "Agua",
            "Teléfono",
            "Jabón ",
            "Detergente",
            "Suavizante",
            "Azistin",
            "Cine",
            "Viaje",
            "Otros"});
            this.subcategoriaComboBox.Location = new System.Drawing.Point(116, 145);
            this.subcategoriaComboBox.Name = "subcategoriaComboBox";
            this.subcategoriaComboBox.Size = new System.Drawing.Size(478, 21);
            this.subcategoriaComboBox.TabIndex = 8;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(116, 190);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(478, 55);
            this.descripcionTextBox.TabIndex = 10;
            // 
            // nudValor
            // 
            this.nudValor.Location = new System.Drawing.Point(252, 35);
            this.nudValor.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudValor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(98, 20);
            this.nudValor.TabIndex = 12;
            this.nudValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudValor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // formapagoComboBox
            // 
            this.formapagoComboBox.FormattingEnabled = true;
            this.formapagoComboBox.Items.AddRange(new object[] {
            "Efectivo",
            "Crédito",
            "Tarjeta de Crédito"});
            this.formapagoComboBox.Location = new System.Drawing.Point(444, 38);
            this.formapagoComboBox.Name = "formapagoComboBox";
            this.formapagoComboBox.Size = new System.Drawing.Size(137, 21);
            this.formapagoComboBox.TabIndex = 14;
            // 
            // GastosDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 294);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(this.categoriaComboBox);
            this.Controls.Add(subcategoriaLabel);
            this.Controls.Add(this.subcategoriaComboBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.nudValor);
            this.Controls.Add(formapagoLabel);
            this.Controls.Add(this.formapagoComboBox);
            this.Name = "GastosDialog";
            this.Text = "Información de Gastos";
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.formapagoComboBox, 0);
            this.Controls.SetChildIndex(formapagoLabel, 0);
            this.Controls.SetChildIndex(this.nudValor, 0);
            this.Controls.SetChildIndex(valorLabel, 0);
            this.Controls.SetChildIndex(this.descripcionTextBox, 0);
            this.Controls.SetChildIndex(descripcionLabel, 0);
            this.Controls.SetChildIndex(this.subcategoriaComboBox, 0);
            this.Controls.SetChildIndex(subcategoriaLabel, 0);
            this.Controls.SetChildIndex(this.categoriaComboBox, 0);
            this.Controls.SetChildIndex(categoriaLabel, 0);
            this.Controls.SetChildIndex(this.fechaDateTimePicker, 0);
            this.Controls.SetChildIndex(fechaLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox categoriaComboBox;
        public System.Windows.Forms.ComboBox subcategoriaComboBox;
        public System.Windows.Forms.TextBox descripcionTextBox;
        public System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        public System.Windows.Forms.NumericUpDown nudValor;
        public System.Windows.Forms.ComboBox formapagoComboBox;

    }
}