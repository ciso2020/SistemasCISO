﻿using SistemaInventarioNet7_3.AccesoDatos.Data;
using SistemaInventarioNet7_3.AccesoDatos.Repositorio.IRepositorio;
using SistemaInventarioNet7_3.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventarioNet7_3.AccesoDatos.Repositorio
{
    public class CarroCompraRepositorio : Repositorio<CarroCompra>, ICarroCompraRepositorio
    {

        private readonly ApplicationDbContext _db;

        public CarroCompraRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Actualizar(CarroCompra carroCompra)
        {           
          _db.Update(carroCompra);
        }
    }
}
