using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Aplicacion
{
    class context:DbContext
    {
        public DbSet<Objetos> Tabla { get; set; }
        
    }
}
