// IProductosRepository.cs
using System.Collections.Generic;
using System.Web.Mvc;
using TiendaNike.AccesoDatos.Data.Repository.IRepository;
using TiendaNike.Models;

namespace TiendaNike.AccesoDatos.Repository.IRepository
{
    public interface IProductosRepository : IRepository<Productos>
    {
        void Update(Productos productos);
    }
}