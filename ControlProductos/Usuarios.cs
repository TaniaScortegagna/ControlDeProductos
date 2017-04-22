using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ControlProductos
{
    class Usuarios: Conexion
    {
        private String usuario;
        private String contraseña;

        public Usuarios()
        {
            usuario = string.Empty;
            contraseña = string.Empty;
            this.sql = string.Empty;

        }

        public String Usuario
        { 
            get {
                return this.usuario;
            }
            set {
                this.usuario = value;
            }
        
        }
        public String Contraseña
        { 
            get{
                return this.contraseña;
            }
            set {
                this.contraseña = value;
            }            
        }

        public bool Buscar()
        {
            bool Resultado = false;
            this.sql = string.Format(@"SELECT IdUsuario 
                                    FROM Usuarios 
                                    WHERE Usuario = '{0}' AND Clave ='{1}'",
                                    this.usuario, this.contraseña);
           this.comandosql = new SqlCommand(this.sql,this.cnn);
           this.Conectar();
           SqlDataReader Reg = null;
           Reg = this.comandosql.ExecuteReader();
           if(Reg.Read())
               {
               Resultado = true;
               this.mensaje = "Bievenido";
                }
            else
               {
                this.mensaje ="Datos Incorrectos";
                }
           this.Desconectar();
            return Resultado;

        }




    }
}
