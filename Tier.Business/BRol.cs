using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tier.Business
{
    public class BRol
    {
        public bool CrearRol(Dto.Rol obj)
        {
            return new Data.DRol().Insertar(obj);
        }
    }
}
