﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaInventarioNet7_3.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventarioNet7_3.AccesoDatos.Configuracion
{
    public class OrdenDetalleConfiguracion : IEntityTypeConfiguration<OrdenDetalle>
    {
        public void Configure(EntityTypeBuilder<OrdenDetalle> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.OrdenId).IsRequired();
            builder.Property(x => x.ProductoId).IsRequired();
            builder.Property(x => x.Cantidad).IsRequired();
            builder.Property(x => x.Precio).IsRequired();


            /* Relaciones*/


            builder.HasOne(x => x.Orden).WithMany()
                   .HasForeignKey(x => x.OrdenId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Producto).WithMany()
                  .HasForeignKey(x => x.ProductoId)
                  .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
