using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Entidad;
using Entidad2;
using Entidad3;
using Entidad4;
using System.IO;

namespace Datos
{
    public class C_Datos
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);


        public List<C_Entidad> ListarAnimales(String buscar)
        {
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCARANIMALES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            leerFilas = cmd.ExecuteReader();

            List<C_Entidad> listar = new List<C_Entidad>();
            while (leerFilas.Read())
            {
                listar.Add(new C_Entidad
                {
                    IDANIMALES = leerFilas.GetInt32(0),
                    Nombre = leerFilas.GetString(1),
                    TIPO = leerFilas.GetString(2),
                    RAZA = leerFilas.GetString(3),
                    DUEÑO = leerFilas.GetString(4),
                    PROBLEMA = leerFilas.GetString(5)

                });
            }
            conexion.Close();
            leerFilas.Close();
            return listar;
        }
        public List<C_Entidad2> ListarClientes(String buscar)
        {
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCARCLIENTES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            leerFilas = cmd.ExecuteReader();

            List<C_Entidad2> listar = new List<C_Entidad2>();
            while (leerFilas.Read())
            {
                listar.Add(new C_Entidad2
                {
                    IDCLIENTE = leerFilas.GetInt32(0),
                    NOMBRE = leerFilas.GetString(1),
                    APELLIDO = leerFilas.GetString(2),
                    CEDULA = leerFilas.GetString(3),
                    MASCOTA = leerFilas.GetString(4),
                    FECHAREGISTRO = leerFilas.GetString(5),
                    CORREO = leerFilas.GetString(6), 
                    TELEFONO = leerFilas.GetString(7)

                });
            }
            conexion.Close();
            leerFilas.Close();
            return listar;

        }
        public List<C_Entidad3> ListarComidas(String buscar)
        {
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCARCOMIDAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            leerFilas = cmd.ExecuteReader();

            List<C_Entidad3> listar = new List<C_Entidad3>();
            while (leerFilas.Read())
            {
                listar.Add(new C_Entidad3
                {
                    IDCOMIDA = leerFilas.GetInt32(0),
                    NOMBRE = leerFilas.GetString(1),
                    MARCA = leerFilas.GetString(2),
                    PRECIO = leerFilas.GetInt32(3),
                    CANTIDAD = leerFilas.GetString(4),
                    

                });
            }
            conexion.Close();
            leerFilas.Close();
            return listar;

        }
        public List<C_Entidad4> ListarEquipamiento(String buscar)
        {
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCAREQUIPAMIENTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            leerFilas = cmd.ExecuteReader();

            List<C_Entidad4> listar = new List<C_Entidad4>();
            while (leerFilas.Read())
            {
                listar.Add(new C_Entidad4
                {
                    IDEQUIPAMIENTO = leerFilas.GetInt32(0),
                    NOMBRE = leerFilas.GetString(1),
                    MARCA = leerFilas.GetString(2),
                    COLOR = leerFilas.GetString(3),
                    PRECIO = leerFilas.GetInt32(4),
                    

                });
            }
            conexion.Close();
            leerFilas.Close();
            return listar;

        }

        public void InsertarAnimales(C_Entidad Animales)
        {

            SqlCommand cmd = new SqlCommand("SP_INSERTARANIMALES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@NOMBRE", Animales.Nombre);
            cmd.Parameters.AddWithValue("@TIPO", Animales.TIPO);
            cmd.Parameters.AddWithValue("@RAZA", Animales.RAZA);
            cmd.Parameters.AddWithValue("@DUEÑO", Animales.DUEÑO);
            cmd.Parameters.AddWithValue("@PROBLEMA", Animales.PROBLEMA);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }
        public void InsertarClientes(C_Entidad2 Clientes)
        {

            SqlCommand cmd = new SqlCommand("SP_INSERTARCLIENTES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@NOMBRE", Clientes.NOMBRE);
            cmd.Parameters.AddWithValue("@APELLIDO", Clientes.APELLIDO);
            cmd.Parameters.AddWithValue("@CEDULA", Clientes.CEDULA);
            cmd.Parameters.AddWithValue("@MASCOTA", Clientes.MASCOTA);
            cmd.Parameters.AddWithValue("@FECHAREGISTRO", Clientes.FECHAREGISTRO);            
            cmd.Parameters.AddWithValue("@CORREO", Clientes.CORREO);
            cmd.Parameters.AddWithValue("@TELEFONO", Clientes.TELEFONO);         
            cmd.ExecuteNonQuery();
            conexion.Close();

        }
        public void InsertarComidas(C_Entidad3 Comidas)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARCOMIDAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@NOMBRE", Comidas.NOMBRE);
            cmd.Parameters.AddWithValue("@MARCA", Comidas.MARCA);
            cmd.Parameters.AddWithValue("@PRECIO", Comidas.PRECIO);
            cmd.Parameters.AddWithValue("@CANTIDAD", Comidas.CANTIDAD);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }
        public void InsertarEquipamientos(C_Entidad4 Equipamientos)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAREQUIPAMIENTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@NOMBRE", Equipamientos.NOMBRE);
            cmd.Parameters.AddWithValue("@MARCA", Equipamientos.MARCA);
            cmd.Parameters.AddWithValue("@COLOR", Equipamientos.COLOR);
            cmd.Parameters.AddWithValue("@PRECIO", Equipamientos.PRECIO);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarAnimales(C_Entidad Animales)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARANIMALES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDANIMALES", Animales.IDANIMALES);
            cmd.Parameters.AddWithValue("@NOMBRE", Animales.Nombre);
            cmd.Parameters.AddWithValue("@TIPO", Animales.TIPO);
            cmd.Parameters.AddWithValue("@RAZA", Animales.RAZA);
            cmd.Parameters.AddWithValue("@DUENO", Animales.DUEÑO);
            cmd.Parameters.AddWithValue("@PROBLEMA", Animales.PROBLEMA);
            
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarClientes(C_Entidad2 Clientes)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARCLIENTES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDCLIENTE", Clientes.IDCLIENTE);
            cmd.Parameters.AddWithValue("@NOMBRE", Clientes.NOMBRE);
            cmd.Parameters.AddWithValue("@APELLIDO", Clientes.APELLIDO);
            cmd.Parameters.AddWithValue("@CEDULA", Clientes.CEDULA);
            cmd.Parameters.AddWithValue("@MASCOTA", Clientes.MASCOTA);
            cmd.Parameters.AddWithValue("@FECHAREGISTRO", Clientes.FECHAREGISTRO);
            cmd.Parameters.AddWithValue("@CORREO", Clientes.CORREO);
            cmd.Parameters.AddWithValue("@TELEFONO", Clientes.TELEFONO);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void EditarComidas(C_Entidad3 Comidas)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARCOMIDAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDCOMIDA", Comidas.IDCOMIDA);
            cmd.Parameters.AddWithValue("@NOMBRE", Comidas.NOMBRE);
            cmd.Parameters.AddWithValue("@MARCA", Comidas.MARCA);
            cmd.Parameters.AddWithValue("@PRECIO", Comidas.PRECIO);
            cmd.Parameters.AddWithValue("@CANTIDAD", Comidas.CANTIDAD);
           
            cmd.ExecuteNonQuery();
            conexion.Close();

        }
        public void EditarEquipamiento(C_Entidad4 Equipamiento)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAREQUIPAMIENTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDEQUIPAMIENTO", Equipamiento.IDEQUIPAMIENTO);
            cmd.Parameters.AddWithValue("@NOMBRE", Equipamiento.NOMBRE);
            cmd.Parameters.AddWithValue("@MARCA", Equipamiento.MARCA);
            cmd.Parameters.AddWithValue("@COLOR", Equipamiento.COLOR);
            cmd.Parameters.AddWithValue("@PRECIO", Equipamiento.PRECIO);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EliminarAnimales(C_Entidad Animales)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARANIMALES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDANIMALES", Animales.IDANIMALES);
            cmd.ExecuteNonQuery();
            conexion.Close();



        }
        public void EliminarClientes(C_Entidad2 Clientes)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARCLIENTES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDCLIENTE", Clientes.IDCLIENTE);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }
        public void EliminarComidas(C_Entidad3 Comidas)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARCOMIDAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDCOMIDAS", Comidas.IDCOMIDA);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EliminarEquipamiento(C_Entidad4 Equipamientos)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAREQUIPAMIENTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDEQUIPAMIENTO", Equipamientos.IDEQUIPAMIENTO);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }
    }


}
