using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Usuario
    {
        public static ML.Result GetByIdTienda(int idTienda)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.ExamenMilanoContext context = new DL.ExamenMilanoContext())
                {
                    var query = context.Usuarios.FromSqlRaw($"UsuarioGetByIdTienda {idTienda}").ToList();
                    if(query != null)
                    {
                        result.Objects = new List<object>();
                        foreach(var item in query)
                        {
                            ML.Usuario usuario = new ML.Usuario();
                            usuario.NumeroEmpleado = item.NumeroEmpleado;
                            usuario.Nombre = item.Nombre;
                            usuario.TiendaAsignada.IdTienda = item.IdTiendaAsignada;

                            result.Objects.Add(usuario);
                        }
                        result.Correct = true;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Message = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
    }
}
