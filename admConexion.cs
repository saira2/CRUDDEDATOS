using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace ClasesProgramacion
{
    class admConexion
    {
          //  Dar acceso publico al objeto para administrar la conexion de la BD //
        public MySqlConnection oConexion;

        /*Funcion para abrir una conexion, si el estado de la misma es abierto entonces que esta sea cerrada para abrir una nueva conexion*/
        public bool AbrirConexion()
        { 
        bool conectado = false;
        string servidor = "localhost", puerto = "3306";
        string usuario = "root", BD = "clasesvirtuales";
        string cadenaConexion = string.Format ("datasource={0}; port={1}; username={2}; database={3}", servidor, puerto, usuario, BD);
           {
            try
            {
                if (oConexion != null && oConexion.State == ConnectionState.Open)
                    oConexion.Close(); 

                oConexion = new MySqlConnection(cadenaConexion);
                oConexion.Open();
                conectado = true;
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Exception.Message, "Error en conexion",MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                conectado = false;
            }
           }
                return conectado;

            }
  
    /* Funcion que recibe una sql para hacer una peticion select a la base de datos y luego vamos a poblar una tabla dentro de un DataSet*/
        public bool SelectData(string SQL, DataTable tabla)
    {
        bool ejecucionCorrecta = false;
        if (this.AbrirConexion() == true)
            {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(SQL, oConexion);
                da.Fill(tabla);
                ejecucionCorrecta = true;
                oConexion.Close();
           }
            catch(MySqlException Exception)
            {
                MessageBox.Show(Exception.Message, "Error en SQl", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ejecucionCorrecta = false; 
               
            }

            }
        return ejecucionCorrecta;
    }

        /* Funcion para ejecutar instrucciones SQl de accion insert , update, delete*/
        public bool AcccionSQL( string SQL)
        {
             bool ejecucionCorrecta = false;
        if (this.AbrirConexion() == true)
            {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL, oConexion);
                cmd.ExecuteNonQuery();
                ejecucionCorrecta = true;
                oConexion.Close();
           }
            catch(MySqlException Exception)
            {
                MessageBox.Show(Exception.Message, "Error en SQl de accion", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ejecucionCorrecta = false; 
            }
            }
        return ejecucionCorrecta;
    }
    }

  }      
    
 