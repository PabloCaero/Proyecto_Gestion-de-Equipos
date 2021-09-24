using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CPUNegocio
    {
        public List<CPU> listar()
        {
            List<CPU> lista = new List<CPU>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select ID, Descripcion From CPUs");
                datos.ejecturaLectura();

                while (datos.Lector.Read())
                {
                    CPU aux = new CPU();
                    aux.IDCPU = (int)datos.Lector["ID"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void agregar(CPU nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into CPUs (Descripcion) values (@Descripcion)");
                datos.setearParametros("@Descripcion", nuevo.Descripcion);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(CPU nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update CPUs set Descripcion = @Descripcion Where ID = " + nuevo.IDCPU + "");
                datos.setearParametros("@Descripcion", nuevo.Descripcion);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar(CPU nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete From CPUs Where ID = " + nuevo.IDCPU + "");
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<CPU> buscarxID(CPU buscar)
        {
            List<CPU> lista = new List<CPU>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select ID, Descripcion From CPUs WHERE ID = '" + buscar.IDCPU + "'");
                datos.ejecturaLectura();

                while (datos.Lector.Read())
                {
                    CPU aux = new CPU();
                    aux.IDCPU = (int)datos.Lector["ID"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

            //FALTA PONER UN BUSCAR CON CONSULTA %LIKE% EN EL NOMBRE
        }
    }
}
