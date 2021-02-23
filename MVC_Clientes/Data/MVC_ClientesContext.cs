using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Clientes.Models;

namespace MVC_Clientes.Data
{
    public class MVC_ClientesContext : DbContext
    {
        public MVC_ClientesContext (DbContextOptions<MVC_ClientesContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Clientes.Models.Cliente> Cliente { get; set; }
    }
}
