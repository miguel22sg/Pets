using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad4
{
    public class C_Entidad4
    {
        private int _IDEQUIPAMIENTO;
        private string _NOMBRE;
        private string _MARCA;
        private string _COLOR;
        private int _PRECIO;

        public int IDEQUIPAMIENTO { get => _IDEQUIPAMIENTO; set => _IDEQUIPAMIENTO = value; }
        public string NOMBRE { get => _NOMBRE; set => _NOMBRE = value; }
        public string MARCA { get => _MARCA; set => _MARCA = value; }
        public string COLOR { get => _COLOR; set => _COLOR = value; }
        public int PRECIO { get => _PRECIO; set => _PRECIO = value; }
    }
}
