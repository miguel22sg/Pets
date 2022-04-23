using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad3
{
    public class C_Entidad3
    {
        private int _IDCOMIDA;
        private string _NOMBRE;
        private string _MARCA;
        private int _PRECIO;
        private string _CANTIDAD;

        public int IDCOMIDA { get => _IDCOMIDA; set => _IDCOMIDA = value; }
        public string NOMBRE { get => _NOMBRE; set => _NOMBRE = value; }
        public string MARCA { get => _MARCA; set => _MARCA = value; }
        public int PRECIO { get => _PRECIO; set => _PRECIO = value; }
        public string CANTIDAD { get => _CANTIDAD; set => _CANTIDAD = value; }
    }
}
