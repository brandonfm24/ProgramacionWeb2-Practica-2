
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaNike.AccesoDatos.Data.Repository.IRepository;
using TiendaNike.AccesoDatos.Repository.IRepository;
using TiendaNike.Data;

namespace TiendaNike.AccesoDatos.Data.Repository
{
    public class ContenedorTrabajo : IContenedorTrabajo
    {
        private readonly ApplicationDbContext _context;

        public ContenedorTrabajo(ApplicationDbContext context)
        {
            _context = context;
            Usuario = new UsuarioRepository(_context);
            Productos = new ProductosRepository(_context);


        }
        public IUsuarioRepository Usuario { get; set; }
        public IProductosRepository Productos { get; private set; }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

}
