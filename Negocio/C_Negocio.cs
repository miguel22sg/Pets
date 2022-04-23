using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Entidad;
using Entidad2;
using Entidad3;
using Entidad4;
using Datos;



namespace Negocio
{
    public class C_Negocio
    {
     
        C_Datos objDato = new C_Datos();
        public List<C_Entidad> ListandoAnimales(String buscar)
        {
            return objDato.ListarAnimales(buscar);
        }
        public List<C_Entidad2> ListandoClientes(String buscar)
        {
            return objDato.ListarClientes(buscar);
        }
        public List<C_Entidad3>ListandoComidas(String buscar)
        {
            return objDato.ListarComidas(buscar);
        }
        public List<C_Entidad4>ListandoEquipamiento(String buscar)
        {
            return objDato.ListarEquipamiento(buscar);
        }

        public void InsertandoAnimales(C_Entidad Animales)
        {
            objDato.InsertarAnimales(Animales);
        }
        public void InsertandoClientes(C_Entidad2 Clientes)
        {
            objDato.InsertarClientes(Clientes);
        }
        public void InsertandoComidas(C_Entidad3 Comidas)
        {
            objDato.InsertarComidas(Comidas);
        }
        public void InsertandoEquipaminetos(C_Entidad4 Equipamientos)
        {
            objDato.InsertarEquipamientos(Equipamientos);
        }
        public void EditandoAnimales(C_Entidad Animales)
        {
            objDato.EditarAnimales(Animales);
        }
        public void EditandoClientes(C_Entidad2 Clientes)
        {
            objDato.EditarClientes(Clientes);
        }
        public void EditandoComidas(C_Entidad3 Comidas)
        {
            objDato.EditarComidas(Comidas);
        }
        public void EditandoEquipamiento(C_Entidad4 Equipamiento)
        {
            objDato.EditarEquipamiento(Equipamiento);
        }
        public void EliminandoAnimales(C_Entidad Animales)
        {
            objDato.EliminarAnimales(Animales);
        }
        public void EliminandoClientes(C_Entidad2 Clientes)
        {
            objDato.EliminarClientes(Clientes);
        }
        public void EliminandoComidas(C_Entidad3 Comidas)
        {
            objDato.EliminarComidas(Comidas);
        }
        public void EliminandoEquipamiento(C_Entidad4 Equipamiento)
        {
            objDato.EliminarEquipamiento(Equipamiento);
        }
            
    }
}
