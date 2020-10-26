namespace ClasesProgramacion.Forms
{
    partial class frmGastosList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGastosList));
            this.dsClasesVirtuales = new ClasesProgramacion.Data.dsClasesVirtuales();
            this.gastosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gastosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.gastosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmbBuscarpor = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtCriterio = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSeleccionar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMostrar = new System.Windows.Forms.ToolStripButton();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsClasesVirtuales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingNavigator)).BeginInit();
            this.gastosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gastosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dsClasesVirtuales
            // 
            this.dsClasesVirtuales.DataSetName = "dsClasesVirtuales";
            this.dsClasesVirtuales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gastosBindingSource
            // 
            this.gastosBindingSource.DataMember = "Gastos";
            this.gastosBindingSource.DataSource = this.dsClasesVirtuales;
            // 
            // gastosBindingNavigator
            // 
            this.gastosBindingNavigator.AddNewItem = null;
            this.gastosBindingNavigator.BindingSource = this.gastosBindingSource;
            this.gastosBindingNavigator.CountItem = null;
            this.gastosBindingNavigator.DeleteItem = null;
            this.gastosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cmbBuscarpor,
            this.toolStripLabel2,
            this.toolStripSeparator1,
            this.txtCriterio,
            this.toolStripSeparator2,
            this.btnBuscar,
            this.toolStripSeparator3,
            this.btnSeleccionar,
            this.toolStripSeparator4,
            this.btnMostrar});
            this.gastosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gastosBindingNavigator.MoveFirstItem = null;
            this.gastosBindingNavigator.MoveLastItem = null;
            this.gastosBindingNavigator.MoveNextItem = null;
            this.gastosBindingNavigator.MovePreviousItem = null;
            this.gastosBindingNavigator.Name = "gastosBindingNavigator";
            this.gastosBindingNavigator.PositionItem = null;
            this.gastosBindingNavigator.Size = new System.Drawing.Size(633, 25);
            this.gastosBindingNavigator.TabIndex = 0;
            this.gastosBindingNavigator.Text = "bindingNavigator1";
            // 
            // gastosDataGridView
            // 
            this.gastosDataGridView.AllowUserToAddRows = false;
            this.gastosDataGridView.AllowUserToDeleteRows = false;
            this.gastosDataGridView.AutoGenerateColumns = false;
            this.gastosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gastosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.gastosDataGridView.DataSource = this.gastosBindingSource;
            this.gastosDataGridView.Location = new System.Drawing.Point(12, 41);
            this.gastosDataGridView.Name = "gastosDataGridView";
            this.gastosDataGridView.ReadOnly = true;
            this.gastosDataGridView.RowHeadersWidth = 4;
            this.gastosDataGridView.Size = new System.Drawing.Size(608, 220);
            this.gastosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "categoria";
            this.dataGridViewTextBoxColumn3.HeaderText = "Categoría";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "subcategoria";
            this.dataGridViewTextBoxColumn4.HeaderText = "Subcategoría";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn5.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn6.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "formapago";
            this.dataGridViewTextBoxColumn7.HeaderText = "Forma pago";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(77, 22);
            this.toolStripLabel1.Text = "Buscar por:";
            // 
            // cmbBuscarpor
            // 
            this.cmbBuscarpor.Items.AddRange(new object[] {
            "categoria",
            "subcategoria",
            "descripcion"});
            this.cmbBuscarpor.Name = "cmbBuscarpor";
            this.cmbBuscarpor.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(54, 22);
            this.toolStripLabel2.Text = "Criterio";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // txtCriterio
            // 
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(52, 22);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSeleccionar.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.Image")));
            this.btnSeleccionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(82, 22);
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnMostrar
            // 
            this.btnMostrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMostrar.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrar.Image")));
            this.btnMostrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(95, 22);
            this.btnMostrar.Text = "Mostrar Todo";
            this.btnMostrar.Click += new System.EventHandler(this.frmGastosList_Load);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(12, 278);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(111, 278);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(211, 278);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(545, 278);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmGastosList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(633, 313);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gastosDataGridView);
            this.Controls.Add(this.gastosBindingNavigator);
            this.Name = "frmGastosList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Gastos";
            this.Load += new System.EventHandler(this.frmGastosList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsClasesVirtuales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingNavigator)).EndInit();
            this.gastosBindingNavigator.ResumeLayout(false);
            this.gastosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gastosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.dsClasesVirtuales dsClasesVirtuales;
        private System.Windows.Forms.BindingSource gastosBindingSource;
        private System.Windows.Forms.BindingNavigator gastosBindingNavigator;
        private System.Windows.Forms.DataGridView gastosDataGridView;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cmbBuscarpor;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtCriterio;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnSeleccionar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnMostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
    }
}