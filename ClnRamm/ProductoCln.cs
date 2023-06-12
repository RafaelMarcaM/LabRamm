
using CadRamm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnRamm
{
    public class ProductoCln
    {
        public static int insertar(Producto producto)
        {
            using (var contexto = new LabRammEntities())
            {
                contexto.Producto.Add(producto);
                contexto.SaveChanges();
                return producto.id;
            }
        }

        public static int actualizar(Producto producto)
        {
            using (var contexto = new LabRammEntities())
            {
                var existente = contexto.Producto.Find(producto.id);
                existente.codigo = producto.codigo;
                existente.descripcion = producto.descripcion;
                existente.unidadMedida = producto.unidadMedida;
                existente.existencias = producto.existencias;
                existente.precioVenta = producto.precioVenta;
                existente.usuarioRegistro = producto.usuarioRegistro;
                return contexto.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {            using (var contexto = new LabRammEntities())
            {
                var existente = contexto.Producto.Find(id);
                existente.registroActivo = false;
                existente.usuarioRegistro = usuarioRegistro;
                return contexto.SaveChanges();
            }
        }

        public static Producto get(int id)
        {
            using (var contexto = new LabRammEntities())
            {
                return contexto.Producto.Find(id);
            }
        }

        public static List<Producto> listar()
        {
            using (var contexto = new LabRammEntities())
            {
                return contexto.Producto.Where(x => x.registroActivo.Value).ToList();
            }
        }

        public static List<paProductoListar_Result> listarPa(string parametro)
        {
            using (var contexto = new LabRammEntities())
            {
                return contexto.paProductoListar(parametro).ToList();
            }
        }
    }
}
