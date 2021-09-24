using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class TecnicoNegocio
    {
        public List<Tecnico> listar()
        {
            List<Tecnico> lista = new List<Tecnico>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select ID, Legajo, Apellidos, Nombres Descripcion From Tecnicos");
                datos.ejecturaLectura();

                while (datos.Lector.Read())
                {
                    Tecnico aux = new Tecnico();
                    aux.IDTecnico = (int)datos.Lector["ID"];
                    aux.Legajo = (int)datos.Lector["Legajo"];
                    aux.Nombres = (string)datos.Lector["Apellidos"];
                    aux.Apellidos = (string)datos.Lector["Nombres"];
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
        public void agregar(Tecnico nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into Tecnicos (Legajo, Apellidos, Nombres) values (@ID, @Legajo, @Apellidos, @Nombres)");
                datos.setearParametros("@Legajo", nuevo.Legajo);
                datos.setearParametros("@Apellidos", nuevo.Apellidos);
                datos.setearParametros("@Nombres", nuevo.Nombres);
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

        public void modificar(Tecnico nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update Tecnicos set Legajo = @Legajo, Apellidos = @Apellidos, Nombres = @Nombres Where ID = " + nuevo.IDTecnico + "");
                datos.setearParametros("@Legajo", nuevo.Legajo);
                datos.setearParametros("@Apellidos", nuevo.Apellidos);
                datos.setearParametros("@Nombres", nuevo.Nombres);
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

        public void eliminar(Tecnico nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete From Tecnicos Where ID = " + nuevo.IDTecnico + "");
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

        public List<Tecnico> buscarxID(Tecnico buscar)
        {
            List<Tecnico> lista = new List<Tecnico>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select ID, Legajo, Apellidos, Nombres Descripcion From Tecnicos WHERE ID = '" + buscar.IDTecnico + "'");
                datos.ejecturaLectura();

                while (datos.Lector.Read())
                {
                    Tecnico aux = new Tecnico();
                    aux.IDTecnico = (int)datos.Lector["ID"];
                    aux.Legajo = (int)datos.Lector["Legajo"];
                    aux.Nombres = (string)datos.Lector["Apellidos"];
                    aux.Apellidos = (string)datos.Lector["Nombres"];
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
