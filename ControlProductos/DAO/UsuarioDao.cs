using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlProductos
{
    class UsuarioDao
    {
        public UsuarioDao() { }


        public bool BuscarUsuario(string pUsuario,string pClave )
        {
            bool estaOk = false;
            Conexion cnn = new Conexion();
            
            string pConsulta = "";
            //CommandType pCommandType = CommandType.Text;
            //pConsulta = string.Format("consultarUnUsuario");

            pConsulta = string.Format(@"SELECT IdUsuario 
                                    FROM Usuarios 
                                    WHERE Usuario = '{0}' AND Clave ='{1}'",
                        pUsuario, pClave);

            DataTable resultado = cnn.EjecutarQuery(pConsulta, CommandType.Text);

            
            //string a = cnn.TraerValor(pConsulta);

            cnn.Desconectar();

            return resultado.Rows.Count > 0;

        }
   }
}
