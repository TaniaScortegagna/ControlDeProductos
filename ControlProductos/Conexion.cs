using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ControlProductos
{
    class Conexion
    {
        SqlConnection oConexion = new SqlConnection();
        SqlCommand oComando = new SqlCommand();
        int iSegundosParaLoguear = 0; // Define el minimo tiempo para empezar a loguear el tiempo que demoran las consultas a la bd. Si es -1, loguea todo.
        Global Global = new Global();

        public Conexion()
        {
            oConexion.ConnectionString = Global.obtenerConexion(); //(@"Data source=(local);Initial Catalog = ControlDeProductos; integrated security = True");  
            this.Conectar();
        }
        public Conexion(string sConnectionString)
        {
            try
            {

                oConexion.ConnectionString = sConnectionString;
                this.Conectar();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public Conexion(string sConnectionString, bool bConectar)
        {
            try
            {

                oConexion.ConnectionString = sConnectionString;
                this.Conectar();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool SetearConexionYConectar(string sConnectionString)
        {
            bool bOk = true;

            try
            {
                this.Desconectar();


                oConexion.ConnectionString = sConnectionString;
                this.Conectar();

            }
            catch (Exception ex)
            {
                bOk = false;
            }
            return bOk;
        }

        public bool SetearTimeoutDeComando(int timeout)
        {
            try
            {
                this.oComando.CommandTimeout = timeout;
            }
            catch
            {
                return false;
            }
            return true;
        }

        public void Conectar()
        {
            try
            {
                this.oConexion.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Desconectar()
        {

            try
            {
                this.oConexion.Close();
                this.oConexion.Dispose();
            }
            catch (Exception ex)
            {
            }
        }

        public void ComenzarTransaccion()
        {
            try
            {
                oComando.Transaction = this.oConexion.BeginTransaction();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void ComenzarTransaccion(IsolationLevel iso)
        {
            try
            {
                oComando.Transaction = this.oConexion.BeginTransaction(iso);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Commit()
        {

            oComando.Transaction.Commit();

        }
        public void RollBack()
        {


            try
            {
                if (oComando.Transaction != null)
                    oComando.Transaction.Rollback();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool EjecutarNonQuery(string pConsulta, CommandType pCommandType)
        {
            string sError = string.Empty;
            return this.EjecutarNonQuery(pConsulta, pCommandType, out sError);
        }
        public bool EjecutarNonQuery(string pConsulta, CommandType pCommandType, out string sError)
        {
            sError = string.Empty;
            bool bOk = true;

            try
            {
                oComando.CommandText = pConsulta;
                oComando.CommandType = pCommandType;
                oComando.Connection = oConexion;
                oComando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                bOk = false;
                sError = ex.Message;
                throw;
            }
            return bOk;
        }
        public int EjecutarNonQuery(string pConsulta)
        {
            String pMensaje = "";
            return EjecutarNonQuery(pConsulta, ref pMensaje);
        }
        public int EjecutarNonQueryConExcepcion(string pConsulta)
        {
            String pMensaje = "";
            return EjecutarNonQueryConExcepcion(pConsulta); //, ref pMensaje);
        }
        public int EjecutarNonQuery(string pConsulta, ref String pMensaje)
        {
            int iResultado = -1;
            DateTime dHoraInicioConsulta = DateTime.Now;

            try
            {
                oComando.CommandText = pConsulta;
                oComando.CommandType = CommandType.StoredProcedure;
                oComando.Connection = oConexion;
                iResultado = oComando.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                throw;
            }
            return iResultado;
        }

        public DataTable EjecutarQuery(string pConsulta)
        {
            DataTable tabla = null;
            DateTime dHoraInicioConsulta = DateTime.Now;

            try
            {

                oComando.CommandText = pConsulta;
                oComando.CommandType = CommandType.StoredProcedure;
                oComando.Connection = oConexion;

                // El resultado lo guardaremos en una tabla
                tabla = new DataTable();
                // Usaremos un DataAdapter para leer los datos
                SqlDataAdapter oDataAdapter = new SqlDataAdapter(oComando);
                // Llenamos la tabla con los datos leídos
                oDataAdapter.Fill(tabla);

            }
            catch (Exception ex)
            {
                throw;
            }

            return tabla;
        }
        public DataTable EjecutarQueryDataReader(string pConsulta)
        {
            DataTable tabla = null;
            DateTime dHoraInicioConsulta = DateTime.Now;

            try
            {
                oComando.CommandText = pConsulta;
                oComando.CommandType = CommandType.StoredProcedure;
                oComando.Connection = oConexion;

                // El resultado lo guardaremos en una tabla
                tabla = new DataTable();
                // Usaremos un DataReader para leer los datos
                using (SqlDataReader reader = oComando.ExecuteReader())
                {
                    tabla.Load(reader);
                }

            }
            catch (Exception ex)
            {
                throw;
            }

            return tabla;
        }
        public DataTable EjecutarQuery(string pConsulta, CommandType oTipoConsulta)
        {
            DataTable tabla = null;
            DateTime dHoraInicioConsulta = DateTime.Now;

            try
            {

                oComando.CommandText = pConsulta;
                oComando.CommandType = oTipoConsulta;
                oComando.Connection = oConexion;

                // El resultado lo guardaremos en una tabla
                tabla = new DataTable();
                // Usaremos un DataAdapter para leer los datos
                SqlDataAdapter oDataAdapter = new SqlDataAdapter(oComando);
                // Llenamos la tabla con los datos leídos
                oDataAdapter.Fill(tabla);

            }
            catch (Exception ex)
            {
                throw;
            }

            return tabla;
        }

        //public string TraerValor(string pConsulta)
        //{
            //DataTable tabla = null;
            //DateTime dHoraInicioConsulta = DateTime.Now;

            //try
            //{
            //    oComando.Connection = oConexion;
            //    oComando.CommandType = CommandType.StoredProcedure;
            //    oComando.CommandText = pConsulta;
                
                

            //    // El resultado lo guardaremos en una tabla
            //    tabla = new DataTable();
            //    // Usaremos un DataAdapter para leer los datos
            //    SqlDataAdapter oDataAdapter = new SqlDataAdapter(oComando);
            //    // Llenamos la tabla con los datos leídos
            //    oDataAdapter.Fill(tabla);

            //}
            //catch (Exception ex)
            //{
                //throw;
            //}

            //return tabla.Rows[0][0].ToString();

        //}
        public DataTable EjecutarQueryTexto(string pConsulta)
        {
            DataTable tabla = null;
            DateTime dHoraInicioConsulta = DateTime.Now;

            try
            {

                oComando.CommandText = pConsulta;
                oComando.CommandType = CommandType.Text;
                oComando.Connection = oConexion;

                // El resultado lo guardaremos en una tabla
                tabla = new DataTable();
                // Usaremos un DataAdapter para leer los datos
                SqlDataAdapter oDataAdapter = new SqlDataAdapter(oComando);
                // Llenamos la tabla con los datos leídos
                oDataAdapter.Fill(tabla);

            }
            catch (Exception ex)
            {

                throw;
            }
            return tabla;
        }
        public object EjecutarEscalar(string pConsulta)
        {
            Object oObject = null;
            DateTime dHoraInicioConsulta = DateTime.Now;

            try
            {
                oComando.CommandText = pConsulta;
                oComando.CommandType = CommandType.StoredProcedure;
                oComando.Connection = oConexion;
                oObject = oComando.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw;
            }
            return oObject;
        }

        public void BorrarParametros()
        {
            try
            {
                this.oComando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void AgregarParametro(string pCampo, string pValor)
        {
            try
            {
                this.oComando.Parameters.AddWithValue(pCampo, pValor);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void AgregarParametro(string pCampo, object oValor)
        {
            try
            {
                this.oComando.Parameters.AddWithValue(pCampo, oValor);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void AgregarParametroNull(string pCampo)
        {
            try
            {
                this.oComando.Parameters.AddWithValue(pCampo, DBNull.Value);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void AgregarParametro(string pCampo, string pValor, SqlDbType pTipo)
        {
            try
            {
                SqlParameter oParametro = new SqlParameter();
                oParametro.Value = pValor;
                oParametro.SqlDbType = pTipo;// SqlDbType.DateTime;
                oParametro.ParameterName = pCampo;
                this.oComando.Parameters.Add(oParametro);
            }
            catch (Exception ex)
            {
                throw;
            }
        }




    }
}
