using SistemaInventarioNet7_3.Modelos;
using SistemaInventarioNet7_3.AccesoDatos.Repositorio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventarioNet7_3.AccesoDatos.Repositorio.IRepositorio
{
    public interface ICarroCompraRepositorio : IRepositorio<CarroCompra>
    {
        void Actualizar(CarroCompra carroCompra);

    }
}
