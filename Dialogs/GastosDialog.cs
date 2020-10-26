using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClasesProgramacion.Dialogs
{
    public partial class GastosDialog : baseDialog
    {
        public GastosDialog()
        {
            InitializeComponent();
        }
        protected override bool ValidarEntrada()
            {
            erp.Clear();
            if (categoriaComboBox.SelectedIndex < 0)
                return NotificacionDeValidacion("Por favor Seleccione una de las opciones de la categoría ", categoriaComboBox);

            if ( subcategoriaComboBox.SelectedIndex < 0)
                return NotificacionDeValidacion("Por favor seleccione una de las opciones de las subcategorías", subcategoriaComboBox );

            if (descripcionTextBox.Text.Trim() == string.Empty)
                return NotificacionDeValidacion("Por favor llene la descripción del gasto", descripcionTextBox);

            if (formapagoComboBox.SelectedIndex < 0)
                return NotificacionDeValidacion("Por favor elija una forma de pago", subcategoriaComboBox);
            return true;
            }

     
    }
}


