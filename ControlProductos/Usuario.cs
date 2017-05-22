using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlProductos
{
    class Usuario
    {
        public int idusuario { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public int tipo { get; set; }
        public Usuario() { }

        public Usuario(int pidusuario, string pusuario, string pclave, int ptipo)
        {
            this.idusuario = pidusuario;
            this.usuario = pusuario;
            this.clave = pclave;
            this.tipo = ptipo;

        }

        public bool BuscarUsuario()
        {
            bool estaOk = false;
            Conexion cnn = new Conexion();
            
            string pConsulta = "";
            //CommandType pCommandType = CommandType.Text;
            //pConsulta = string.Format("consultarUnUsuario");

            pConsulta = string.Format(@"SELECT IdUsuario 
                                    FROM Usuarios 
                                    WHERE Usuario = '{0}' AND Clave ='{1}'",
                        this.usuario, this.clave);

            DataTable resultado = cnn.EjecutarQuery(pConsulta, CommandType.Text);

            
            //string a = cnn.TraerValor(pConsulta);

            cnn.Desconectar();

            return resultado.Rows.Count > 0;

        }
   }
}
