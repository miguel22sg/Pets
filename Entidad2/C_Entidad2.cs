using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad2
{
    public class C_Entidad2
    {
        
        private int _IDCLIENTE;
        private string _NOMBRE;
        private string _APELLIDO;
        private string _CEDULA;
        private string _MASCOTA;
        private string _FECHAREGISTRO;
        private string _CORREO;
        private string _TELEFONO;
        
        
        
        

        public int IDCLIENTE { get => _IDCLIENTE; set => _IDCLIENTE = value; }
        public string NOMBRE { get => _NOMBRE; set => _NOMBRE = value; }
        public string APELLIDO { get => _APELLIDO; set => _APELLIDO = value; }
        public string CEDULA { get => _CEDULA; set => _CEDULA = value; }
        public string MASCOTA { get => _MASCOTA; set => _MASCOTA = value; }
        public string FECHAREGISTRO { get => _FECHAREGISTRO; set => _FECHAREGISTRO = value; }
        public string CORREO { get => _CORREO; set => _CORREO = value; }
        public string TELEFONO { get => _TELEFONO; set => _TELEFONO = value; }
        
    }
}
