using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaNike.AccesoDatos.Repository.IRepository;

namespace TiendaNike.AccesoDatos.Data.Repository.IRepository
{
    public interface IContenedorTrabajo : IDisposable
    {
       

        IProductosRepository Productos { get; }
        IUsuarioRepository Usuario { get; }

        void Save();
    }
}
