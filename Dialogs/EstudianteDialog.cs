using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesProgramacion.Dialogs;

namespace ClasesProgramacion.Dialogs
{
    public partial class EstudianteDialog : baseDialog
    {
        public EstudianteDialog()
        {
            InitializeComponent();
        }
        protected override bool ValidarEntrada()
        {
            erp.Clear();
            if (identidadTextBox.Text.Trim() == string.Empty)
                return NotificacionDeValidacion("Por favor escriba el numero de identidad del estudiante", identidadTextBox);
            if(sexoComboBox.SelectedIndex < 0)
                return NotificacionDeValidacion("Por favor selecciones Femenino o Masculino", sexoComboBox);
            if (nombresTextBox.Text.Trim() == string.Empty)
                return NotificacionDeValidacion("Por favor escriba el nombres completos del estudiante", nombresTextBox );
            if (apellidosTextBox.Text.Trim() == string.Empty)
                return NotificacionDeValidacion("Por favor escriba los apellidos completos del estudiante", apellidosTextBox);
            if (direccionTextBox.Text.Trim() == string.Empty)
                return NotificacionDeValidacion("Por favor escriba la dirección donde el estudiante vive", direccionTextBox );
            return true;
        }

        private void EstudianteDialog_Load(object sender, EventArgs e)
        {

        }
   
    }
}
