using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class LicenciaWindowsNegocio
    {
        public List<LicenciaWindows> listar()
        {
            List<LicenciaWindows> lista = new List<LicenciaWindows>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select ID, Descripcion, Numero From LicenciasWindows");
                datos.ejecturaLectura();

                while (datos.Lector.Read())
                {
                    LicenciaWindows aux = new LicenciaWindows();
                    aux.IDLicenciaWindows = (int)datos.Lector["ID"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Numero = (string)datos.Lector["Numero"];
             
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
        public void agregar(LicenciaWindows nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into LicenciasWindows (Descripcion, Numero) values (@Descripcion, @Numero)");
                datos.setearParametros("@Descripcion", nuevo.Descripcion);
                datos.setearParametros("@Numero", nuevo.Numero);
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

        public void modificar(LicenciaWindows nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update LicenciasWindows set Descripcion = @Descripcion, Numero = @Numero Where ID = " + nuevo.IDLicenciaWindows + "");
                datos.setearParametros("@Descripcion", nuevo.Descripcion);
                datos.setearParametros("@Numero", nuevo.Numero);
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

        public void eliminar(LicenciaWindows nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete From LicenciasWindows Where ID = " + nuevo.IDLicenciaWindows + "");
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

        public List<LicenciaWindows> buscarxID(LicenciaWindows buscar)
        {
            List<LicenciaWindows> lista = new List<LicenciaWindows>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select ID, Descripcion, Numero From LicenciasWindows WHERE ID = '" + buscar.IDLicenciaWindows + "'");
                datos.ejecturaLectura();

                while (datos.Lector.Read())
                {
                    LicenciaWindows aux = new LicenciaWindows();
                    aux.IDLicenciaWindows = (int)datos.Lector["ID"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Numero = (string)datos.Lector["Numero"];
                    
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
