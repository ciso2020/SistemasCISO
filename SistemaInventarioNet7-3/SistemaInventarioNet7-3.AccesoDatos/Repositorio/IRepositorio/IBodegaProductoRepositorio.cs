using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaInventarioNet7_3.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventarioNet7_3.AccesoDatos.Repositorio.IRepositorio
{
    public interface IBodegaProductoRepositorio : IRepositorio<BodegaProducto>
    {
        void Actualizar(BodegaProducto bodegaProducto);

  
    }
}
