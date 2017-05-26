using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlProductos
{
    class UsuarioDao
    {
        public UsuarioDao() { }


        public bool BuscarUsuario(string pUsuario,string pClave )
        {
<<<<<<< HEAD

                    Conexion cnn = new Conexion();            
                    string pConsulta = string.Format("SP_VERIFICAR_USUARIO");
                    cnn.AgregarParametro("@Usuario", pUsuario.ToString(),SqlDbType.VarChar);
                    cnn.AgregarParametro("@Clave", pClave.ToString(), SqlDbType.VarChar);
                    DataTable resultado = cnn.EjecutarQuery(pConsulta);
                    cnn.Desconectar();
                    return resultado.Rows.Count > 0;

=======
            Conexion cnn = new Conexion();            
            string pConsulta = string.Format("SP_VERIFICAR_USUARIO");
            cnn.AgregarParametro("@Usuario", pUsuario.ToString(),SqlDbType.VarChar);
            cnn.AgregarParametro("@Clave", pClave.ToString(), SqlDbType.Int);
            DataTable resultado = cnn.EjecutarQuery(pConsulta);
            cnn.Desconectar();
            return resultado.Rows.Count > 0;
>>>>>>> origin/master

        }
   }
}
