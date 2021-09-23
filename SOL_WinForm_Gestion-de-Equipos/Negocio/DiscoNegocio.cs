using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class DiscoNegocio
    {
        public List<Disco> listar()
        {
            List<Disco> lista = new List<Disco>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select ID, Descripcion From DISCOs");
                datos.ejecturaLectura();

                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();
                    aux.IDDisco = (int)datos.Lector["ID"];
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
        public void agregar(Disco nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into Discos (Descripcion) values (@Descripcion)");
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

        public void modificar(Disco nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update DISCOs set Descripcion = @Descripcion Where ID = " + nuevo.IDDisco + "");
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

        public void eliminar(Disco nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete From DISCOs Where ID = " + nuevo.IDDisco + "");
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

        public List<Disco> buscarxID(Disco buscar)
        {
            List<Disco> lista = new List<Disco>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select ID, Descripcion From Discos WHERE ID = '" + buscar.IDDisco + "'");
                datos.ejecturaLectura();

                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();
                    aux.IDDisco = (int)datos.Lector["ID"];
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
