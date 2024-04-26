using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaNike.Models
{
    public class Productos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; } 
        public int Precio { get; set; }
        public string Categoria { get; set; }
        public string Subcategoria { get; set; }    
        
    }
}
