﻿using SistemaInventarioNet7_3.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventarioNet7_3.AccesoDatos.Repositorio.IRepositorio
{
    public interface IOrdenRepositorio : IRepositorio<Orden>
    {
        void Actualizar(Orden orden);
        void ActualizarEstado(int id, string ordenEstado, string pagoEstado);
        void ActualizarPagoStripeId(int id, string sessionId, string transaccionId);
    }
}
