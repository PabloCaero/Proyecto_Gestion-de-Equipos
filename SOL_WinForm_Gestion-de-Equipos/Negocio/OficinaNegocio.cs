using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class OficinaNegocio
    {
        public List<Oficina> listar()
        {
            List<Oficina> lista = new List<Oficina>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select ID, Nombre From Oficinas");
                datos.ejecturaLectura();

                while (datos.Lector.Read())
                {
                    Oficina aux = new Oficina();
                    aux.IDOficina = (int)datos.Lector["ID"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
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
        public void agregar(Oficina nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into Oficinas (Nombre) values (@Nombre)");
                datos.setearParametros("@Nombre", nuevo.Nombre);
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

        public void modificar(Oficina nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update Oficinas set Nombre = @Nombre Where ID = " + nuevo.IDOficina + "");
                datos.setearParametros("@Nombre", nuevo.Nombre);
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

        public void eliminar(Oficina nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete From Oficinas Where ID = " + nuevo.IDOficina + "");
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

        public List<Oficina> buscarxID(Oficina buscar)
        {
            List<Oficina> lista = new List<Oficina>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select ID, Nombre From Oficinas WHERE ID = '" + buscar.IDOficina + "'");
                datos.ejecturaLectura();

                while (datos.Lector.Read())
                {
                    Oficina aux = new Oficina();
                    aux.IDOficina = (int)datos.Lector["ID"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
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
