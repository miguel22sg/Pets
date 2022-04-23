using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class C_Entidad
    {
        private int _IDANIMALES;
        private string _Nombre;
        private string _TIPO;
        private string _RAZA;
        private string _DUEÑO;
        private string _PROBLEMA;

        public int IDANIMALES { get => _IDANIMALES; set => _IDANIMALES = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string TIPO { get => _TIPO; set => _TIPO = value; }
        public string RAZA { get => _RAZA; set => _RAZA = value; }
        public string DUEÑO { get => _DUEÑO; set => _DUEÑO = value; }
        public string PROBLEMA { get => _PROBLEMA; set => _PROBLEMA = value; }
    }
}
