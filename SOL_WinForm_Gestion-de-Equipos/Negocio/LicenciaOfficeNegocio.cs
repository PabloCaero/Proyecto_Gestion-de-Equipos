using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class LicenciaOfficeNegocio
    {
        public List<LicenciaOffice> listar()
        {
            List<LicenciaOffice> lista = new List<LicenciaOffice>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select A.ID, A.IDCartonOffice, A.FechaCarga, A.Numero, B.Numero as CartonOffice From LicenciasOffice A, LicenciasCartonOffice B Where A.IDCartonOffice = B.ID");
                datos.ejecturaLectura();

                while (datos.Lector.Read())
                {
                    LicenciaOffice aux = new LicenciaOffice();
                    aux.IDLicenciaOffice = (int)datos.Lector["ID"];
                    aux.CartonOffice = new LicenciaCartonOffice();
                    aux.CartonOffice.IDLicenciaCartonOffice = (int)datos.Lector["IDCartonOffice"];
                    aux.CartonOffice.Numero = (string)datos.Lector["CartonOffice"];
                    aux.Numero = (string)datos.Lector["Numero"];
                    aux.FechaCarga = new DateTime();
                    aux.FechaCarga = (DateTime)datos.Lector["FechaCarga"]; //REVISAR PORQUE NO SE SI ESTA BIEN
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
        public void agregar(LicenciaOffice nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into LicenciasOffice (IDCartonOffice, FechaCarga, Numero) values (@IDCartonOffice, @FechaCarga, @Numero)");
                datos.setearParametros("@IDCartonOffice", nuevo.CartonOffice.IDLicenciaCartonOffice);
                datos.setearParametros("@FechaCarga", nuevo.FechaCarga);
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

        public void modificar(LicenciaOffice nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update LicenciasOffice set IDCartonOffice = @IDCartonOffice, FechaCarga = @FechaCarga, Numero = @Numero Where ID = " + nuevo.IDLicenciaOffice + "");
                datos.setearParametros("@IDCartonOffice", nuevo.CartonOffice.IDLicenciaCartonOffice);
                datos.setearParametros("@FechaCarga", nuevo.FechaCarga);
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

        public void eliminar(LicenciaOffice nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete From LicenciasOffice Where ID = " + nuevo.IDLicenciaOffice + "");
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

        public List<LicenciaOffice> buscarxID(LicenciaOffice buscar)
        {
            List<LicenciaOffice> lista = new List<LicenciaOffice>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select A.ID, A.IDCartonOffice, A.FechaCarga, A.Numero, B.Numero as CartonOffice From LicenciasOffice A, LicenciasCartonOffice B Where A.IDCartonOffice = B.ID and A.ID = '" + buscar.IDLicenciaOffice + "'");
                datos.ejecturaLectura();

                while (datos.Lector.Read())
                {
                    LicenciaOffice aux = new LicenciaOffice();
                    aux.IDLicenciaOffice = (int)datos.Lector["ID"];
                    aux.CartonOffice = new LicenciaCartonOffice();
                    aux.CartonOffice.IDLicenciaCartonOffice = (int)datos.Lector["IDCartonOffice"];
                    aux.CartonOffice.Numero = (string)datos.Lector["CartonOffice"];
                    aux.Numero = (string)datos.Lector["Numero"];
                    aux.FechaCarga = new DateTime();
                    aux.FechaCarga = (DateTime)datos.Lector["FechaCarga"]; //REVISAR PORQUE NO SE SI ESTA BIEN
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
