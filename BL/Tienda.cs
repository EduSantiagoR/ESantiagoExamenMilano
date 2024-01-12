using Microsoft.EntityFrameworkCore;
using System.Xml.XPath;

namespace BL
{
    public class Tienda
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.ExamenMilanoContext context = new DL.ExamenMilanoContext())
                {
                    var query = context.Tienda.FromSqlRaw("TiendaGetTiendasAbiertas").ToList();
                    if(query != null)
                    {
                        result.Objects = new List<object>();
                        foreach(var item in query)
                        {
                            ML.Tienda tienda = new ML.Tienda();
                            tienda.IdTienda = item.IdTienda;
                            tienda.Nombre = item.Nombre;
                            tienda.Tipo = item.Tipo;
                            tienda.Estatus = item.Estatus;
                            tienda.Regional = item.Regional;

                            result.Objects.Add(tienda);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.Message = "No se ha podido recuperar las tiendas.";
                    }
                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.Message = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
    }
}