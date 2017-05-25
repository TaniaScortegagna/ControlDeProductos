using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace ControlProductos
{
    class Global
    {
        public string CadenaDeConexionBd ="";
        XmlDocument oXml = new XmlDocument();

        public Global()
            {
                    
            }
        public string obtenerConexion()
        {
            oXml.Load("C:\\Config.xml");
            XmlNodeList oNodo = oXml.GetElementsByTagName("Conexion");
            this.CadenaDeConexionBd = oNodo[0].InnerText;
            return this.CadenaDeConexionBd;
        }
    }
}
