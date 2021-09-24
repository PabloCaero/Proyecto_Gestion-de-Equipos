using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class EquipoNegocio
    {
        public List<Equipo> listar()
        {
            List<Equipo> lista = new List<Equipo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select E.ID, E.Ticket, E.IDTecnicoAsignado, T.Legajo, T.Apellidos, T.Nombres,  E.IDOficina, O.Nombre as Oficina, E.Nombre, E.Tipo, E.IDCPU, CP.Descripcion as CPU, E.IDGPU, GP.Descripcion as GPU,E.IDRAM, R.Descripcion as RAM, E.IDDISCO1, DIS.Descripcion as Disco1, E.IDDISCO2, DIS.Descripcion as Disco2, E.IDWIN, LW.Numero as LicenciaWindows, E.IDOFFICE, LO.Numero as LicenciaOffice, LCO.Descripcion as Cuenta From Equipos E Inner Join LicenciasOffice LO ON E.IDOFFICE = LO.ID Inner Join LicenciasCartonOffice LCO ON LO.IDCartonOffice = LCO.ID Inner Join Cuentas C ON C.ID = LCO.IDCuenta Inner Join RAMs R ON R.ID = E.IDRAM Inner Join LicenciasWindows LW ON LW.ID = E.IDWIN Inner Join Oficinas O ON O.ID = E.IDOficina Inner Join CPUs CP ON CP.ID = E.IDCPU Inner Join GPUs GP ON GP.ID = E.IDGPU Inner Join DISCOs DIS ON DIS.ID = E.IDDISCO1 and DIS.ID = E.IDDISCO2 Inner Join Tecnicos T ON T.ID = E.IDTecnicoAsignado");
                datos.ejecturaLectura();

                while (datos.Lector.Read())
                {
                    Equipo aux = new Equipo();
                    aux.IDEquipo = (int)datos.Lector["ID"];
                    aux.Ticket = (int)datos.Lector["Ticket"];

                    aux.Tecnico = new Tecnico();
                    aux.Tecnico.IDTecnico = (int)datos.Lector["IDTecnicoAsignado"];
                    aux.Tecnico.Legajo = (int)datos.Lector["Legajo"];
                    aux.Tecnico.Apellidos = (string)datos.Lector["Apellidos"];
                    aux.Tecnico.Nombres = (string)datos.Lector["Nombres"];

                    aux.Oficina = new Oficina();
                    aux.Oficina.IDOficina = (int)datos.Lector["IDOficina"];
                    aux.Oficina.Nombre = (string)datos.Lector["Oficina"];

                    aux.Tipo = (string)datos.Lector["Tipo"];

                    aux.CPU = new CPU();
                    aux.CPU.IDCPU = (int)datos.Lector["IDCPU"];
                    aux.CPU.Descripcion = (string)datos.Lector["CPU"];

                    aux.GPU = new GPU();
                    aux.GPU.IDGPU = (int)datos.Lector["IDGPU"];
                    aux.GPU.Descripcion = (string)datos.Lector["GPU"];

                    aux.RAM = new RAM();
                    aux.RAM.IDRAM = (int)datos.Lector["IDRAM"];
                    aux.RAM.Descripcion = (string)datos.Lector["RAM"];

                    aux.Disco1 = new Disco();
                    aux.Disco1.IDDisco = (int)datos.Lector["IDDISCO1"];
                    aux.Disco1.Descripcion = (string)datos.Lector["Disco1"];

                    aux.Disco2 = new Disco();
                    aux.Disco2.IDDisco = (int)datos.Lector["IDDISCO2"];
                    aux.Disco2.Descripcion = (string)datos.Lector["Disco2"];

                    aux.LicenciaWindows = new LicenciaWindows();
                    aux.LicenciaWindows.IDLicenciaWindows = (int)datos.Lector["IDWIN"];
                    aux.LicenciaWindows.Numero = (string)datos.Lector["LicenciaWindows"];

                    aux.LicenciaOffice = new LicenciaOffice();
                    aux.LicenciaOffice.IDLicenciaOffice = (int)datos.Lector["IDOFFICE"];
                    aux.LicenciaOffice.Numero = (string)datos.Lector["LicenciaOffice"];

                    aux.Cuenta = new Cuenta();
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
        public void agregar(Equipo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into Equipos(Ticket, IDTecnicoAsignado, IDOficina, Nombre, Tipo, IDCPU, IDGPU, IDRAM, IDDISCO1, IDDISCO2, IDWIN, IDOFFICE) values (@Ticket, @IDTecnicoAsignado, @IDOficina, @Nombre, @Tipo, @IDCPU, @IDGPU, @IDRAM, @IDDISCO1, @IDDISCO2, @IDWIN, @IDOFFICE)");
                datos.setearParametros("@Ticket", nuevo.Ticket);
                datos.setearParametros("@IDTecnicoAsignado", nuevo.Tecnico);
                datos.setearParametros("@IDOficina", nuevo.Oficina.IDOficina);
                datos.setearParametros("@Nombre", nuevo.Nombre);
                datos.setearParametros("@Tipo", nuevo.Tipo);
                datos.setearParametros("@IDCPU", nuevo.CPU.IDCPU);
                datos.setearParametros("@IDGPU", nuevo.GPU.IDGPU);
                datos.setearParametros("@IDRAM", nuevo.RAM.IDRAM);
                datos.setearParametros("@IDDISCO1", nuevo.Disco1.IDDisco);
                datos.setearParametros("@IDDISCO2", nuevo.Disco2.IDDisco);
                datos.setearParametros("@IDWIN", nuevo.LicenciaWindows.IDLicenciaWindows);
                datos.setearParametros("@IDWIN", nuevo.LicenciaOffice.IDLicenciaOffice);
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

        /*public void modificar(Equipo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update LicenciasCartonOffice set Descripcion = @Descripcion, IDCuenta = @IDCuenta, Numero = @Numero Where ID = " + nuevo.IDEquipo + "");
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

        public void eliminar(Equipo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete From LicenciasCartonOffice Where ID = " + nuevo.IDEquipo + "");
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

        public List<Equipo> buscarxID(Equipo buscar)
        {
            List<Equipo> lista = new List<Equipo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select A.ID, A.IDCuenta, B.Descripcion as Cuenta A.Descripcion, A.Numero From LicenciasCartonOffice WHERE A.IDCuenta = B.ID and A.ID = '" + buscar.IDEquipo + "'");
                datos.ejecturaLectura();

                while (datos.Lector.Read())
                {
                    Equipo aux = new Equipo();
                    aux.IDEquipo = (int)datos.Lector["ID"];
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

        }*/
    }
}
