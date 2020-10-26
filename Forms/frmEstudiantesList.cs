using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClasesProgramacion.Forms
{
    public partial class frmEstudiantesList : Form
    {
        admConexion oConexion = new admConexion(); 
        public frmEstudiantesList()
        {
            InitializeComponent();
        }

        private void frmEstudiantesList_Load(object sender, EventArgs e)
        {
            dsClasesVirtuales.Estudiantes.Clear();
            string selectSQL = "Select * from estudiantes";
            if (oConexion.SelectData(selectSQL, dsClasesVirtuales.Estudiantes) != true)
                MessageBox.Show("No se ha podido cargar ningun dato de estudiantes, contacte con el departamento de desarrollo tecnico", " Sin datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Dialogs.EstudianteDialog frmNuevo = new Dialogs.EstudianteDialog();
            frmNuevo.identidadTextBox.Focus();
            frmNuevo.ShowDialog();
           if (frmNuevo.DialogResult == DialogResult.OK)
               {
                   string sqlInsert = string.Format("insert into estudiantes(identidad,nombres,apellidos,fechanac,sexo,direccion,observacion)values( '{0}', '{1}','{2}','{3}','{4}','{5}','{6}')", frmNuevo.identidadTextBox.Text.Trim(), frmNuevo.nombresTextBox.Text.Trim(), frmNuevo.apellidosTextBox.Text.Trim(), frmNuevo.fechanacDateTimePicker.Value.ToString("yyyy-MM-dd"), frmNuevo.sexoComboBox.Text,frmNuevo.direccionTextBox.Text.Trim(), frmNuevo.observacionTextBox.Text.Trim());
               if(oConexion.AcccionSQL(sqlInsert)== true)
               { 
                   this.frmEstudiantesList_Load(null,null);
                   MessageBox.Show("La información de estudiantes ha sido almacenada correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

               }
               }
    }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (estudiantesBindingSource.Count > 0)
            {
            Dialogs.EstudianteDialog frmEditar = new Dialogs.EstudianteDialog();
            DataGridViewRow Filla = estudiantesDataGridView.CurrentRow;
            Int16 ID = Int16.Parse(Filla.Cells[0].Value.ToString());
            frmEditar.identidadTextBox.Text = Filla.Cells[1].Value.ToString();
            frmEditar.nombresTextBox.Text = Filla.Cells[2].Value.ToString();
            frmEditar.apellidosTextBox.Text = Filla.Cells[3].Value.ToString();
            frmEditar.fechanacDateTimePicker.Value = Convert.ToDateTime(Filla.Cells[4].Value);
            frmEditar.sexoComboBox.Text = Filla.Cells[5].Value.ToString();
            frmEditar.direccionTextBox.Text = Filla.Cells[6].Value.ToString();
            frmEditar.observacionTextBox.Text = Filla.Cells[7].Value.ToString();
            frmEditar.identidadTextBox.Focus();
            frmEditar.ShowDialog();
            if (frmEditar.DialogResult == DialogResult.OK)
            {
                string sqlUpdate = string.Format("update estudiantes set identidad ='{0}', nombres='{1}',apellidos='{2}',fechanac='{3}', sexo='{4}', direccion='{5}', observacion='{6}' where id={7} ",
                    frmEditar.identidadTextBox.Text.Trim(), frmEditar.nombresTextBox.Text.Trim(), frmEditar.apellidosTextBox.Text.Trim(),
                    frmEditar.fechanacDateTimePicker.Value.ToString("yyyy-MM-dd"), frmEditar.sexoComboBox.Text, frmEditar.direccionTextBox.Text.Trim(),
                    frmEditar.observacionTextBox.Text.Trim(),ID);
                if (oConexion.AcccionSQL(sqlUpdate) == true)
                {
                    this.frmEstudiantesList_Load(null, null);
                    MessageBox.Show("La información del estudiantes ha sido actualizada correctamente","Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (estudiantesBindingSource.Count > 0) 
            {
             if(MessageBox.Show("Asegurese de querer eliminar la información del estudiant, Desea eliminar permanentemente este registro?","Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.Yes)
             {
                 DataGridViewRow Filla = estudiantesDataGridView.CurrentRow;
                 Int16 ID = Int16.Parse(Filla.Cells[0].Value.ToString());
                 string sqlDelete = string.Format("delete from estudiantes where id ={0}", ID);
                 if (oConexion.AcccionSQL(sqlDelete) == true)
                 
                 {
                     this.frmEstudiantesList_Load(null, null);
                     MessageBox.Show("La informacion del estudiante ha sido borrada permanentemente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     estudiantesDataGridView.Focus();
                 }
             }
            }
            else
            {
                MessageBox.Show("No hay información para eliminar un registro", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        {
                
    }
}

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbBuscarpor.SelectedIndex < 0 )
            {
                MessageBox.Show("Debe seleccionar una de las opciones para buscar un estudiante ya sea por identidad, nombres o apellidos","Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbBuscarpor.Focus();
                return;
            }
            else
           { 
                if(txtCriterio.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Por favor escriba un criterio para realizar la busqueda de un estudiante", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCriterio.Focus();
                    return;
                }
                else
                {
                    string sqlSelect = string.Empty;
                    switch(cmbBuscarpor.SelectedIndex)
                     { 
                        case 0: //identidad 
                            sqlSelect= string.Format("select * from estudiantes where identidad ='{0}'", txtCriterio.Text.Trim());
                            break;
                        case 1: //nombres
                            sqlSelect = string.Format("select * from estudiantes where nombres like '{0}%'", txtCriterio.Text.Trim());
                            break;
                        default: //apellidos
                            sqlSelect = string.Format("select * from estudiantes where apellidos like '{0}%'", txtCriterio.Text.Trim());
                            break;

                    }
                    dsClasesVirtuales.Estudiantes.Clear();
                    if (oConexion.SelectData(sqlSelect, dsClasesVirtuales.Estudiantes) == true)
                        estudiantesDataGridView.Focus();
                }
            }

        }
    }
}