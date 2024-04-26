using System;
using System.Linq;
using TiendaNike.AccesoDatos.Data.Repository.IRepository;
using TiendaNike.AccesoDatos.Repository.IRepository;
using TiendaNike.Data;
using TiendaNike.Models;

namespace TiendaNike.AccesoDatos.Data.Repository
{
    public class ProductosRepository : Repository<Productos>, IProductosRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductosRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Productos productos)
        {
            var objDesdeDb = _db.Productos.FirstOrDefault(s => s.Id == productos.Id);
            if (objDesdeDb != null)
            {
                objDesdeDb.Nombre = productos.Nombre;
                objDesdeDb.Descripcion = productos.Descripcion;
                objDesdeDb.Precio = productos.Precio;
            }
        }
    }
}
