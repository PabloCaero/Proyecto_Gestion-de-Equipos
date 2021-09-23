using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class LicenciaCartonOfficeNegocio
    {
        public List<LicenciaCartonOffice> listar()
        {
            List<LicenciaCartonOffice> lista = new List<LicenciaCartonOffice>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select A.ID, A.IDCuenta, A.Descripcion, A.Numero, B.Descripcion as Cuenta From LicenciasCartonOffice A, Cuentas B Where A.IDCuenta = B.ID");
                datos.ejecturaLectura();

                while (datos.Lector.Read())
                {
                    LicenciaCartonOffice aux = new LicenciaCartonOffice();
                    aux.IDLicenciaCartonOffice = (int)datos.Lector["ID"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Numero = (string)datos.Lector["Numero"];
                    aux.Cuenta = new Cuenta();
                    aux.Cuenta.IDCuenta = (int)datos.Lector["IDCuenta"];
                    aux.Cuenta.Descripcion = (string)datos.Lector["Cuenta"];
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
        public void agregar(LicenciaCartonOffice nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into LicenciasCartonOffice (IDCuenta, Descripcion, Numero) values (@IDCuenta, @Descripcion, @Numero)");
                datos.setearParametros("@IDCuenta", nuevo.Cuenta.IDCuenta);
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

        public void modificar(LicenciaCartonOffice nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update LicenciasCartonOffice set Descripcion = @Descripcion, IDCuenta = @IDCuenta, Numero = @Numero Where ID = " + nuevo.IDLicenciaCartonOffice + "");
                datos.setearParametros("@IDCuenta", nuevo.Cuenta.IDCuenta);
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

        public void eliminar(LicenciaCartonOffice nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete From LicenciasCartonOffice Where ID = " + nuevo.IDLicenciaCartonOffice + "");
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

        public List<LicenciaCartonOffice> buscarxID(LicenciaCartonOffice buscar)
        {
            List<LicenciaCartonOffice> lista = new List<LicenciaCartonOffice>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select A.ID, A.IDCuenta, B.Descripcion as Cuenta A.Descripcion, A.Numero From LicenciasCartonOffice WHERE A.IDCuenta = B.ID and A.ID = '" + buscar.IDLicenciaCartonOffice + "'");
                datos.ejecturaLectura();

                while (datos.Lector.Read())
                {
                    LicenciaCartonOffice aux = new LicenciaCartonOffice();
                    aux.IDLicenciaCartonOffice = (int)datos.Lector["ID"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Numero = (string)datos.Lector["Numero"];
                    aux.Cuenta = new Cuenta();
                    aux.Cuenta.IDCuenta = (int)datos.Lector["IDCuenta"];
                    aux.Cuenta.Descripcion = (string)datos.Lector["Cuenta"];
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
