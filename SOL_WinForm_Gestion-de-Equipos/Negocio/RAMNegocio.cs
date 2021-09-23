using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class RAMNegocio
    {
        public List<RAM> listar()
        {
            List<RAM> lista = new List<RAM>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select ID, Descripcion From RAMs");
                datos.ejecturaLectura();

                while (datos.Lector.Read())
                {
                    RAM aux = new RAM();
                    aux.IDRAM = (int)datos.Lector["ID"];
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
        public void agregar(RAM nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into RAMs (Descripcion) values (@Descripcion)");
                datos.setearParametros("@Descripcion", nuevo.Descripcion)
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

        public void modificar(RAM nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update RAMs set Descripcion = @Descripcion Where ID = " + nuevo.IDRAM + "");
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

        public void eliminar(RAM nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete From RAMs Where ID = " + nuevo.IDRAM + "");
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

        public List<RAM> buscarxID(RAM buscar)
        {
            List<RAM> lista = new List<RAM>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select ID, Descripcion From RAMs WHERE ID = '" + buscar.IDRAM + "'");
                datos.ejecturaLectura();

                while (datos.Lector.Read())
                {
                    RAM aux = new RAM();
                    aux.IDRAM = (int)datos.Lector["ID"];
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
    }
}
