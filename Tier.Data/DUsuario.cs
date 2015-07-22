using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tier.Data
{
    public class DUsuario : ParentData<Dto.Usuario>
    {
        #region [Constructores]
        public DUsuario()
            : base()
        {

        }

        public DUsuario(string CnnStr)
            : base(CnnStr)
        {

        }
        #endregion

        public override IEnumerable<Dto.Usuario> RecuperarFiltrados(Dto.Usuario obj)
        {
            throw new NotImplementedException();
        }

        public override bool Insertar(Dto.Usuario obj)
        {
            throw new NotImplementedException();
        }

        public override bool Actualizar(Dto.Usuario obj)
        {
            throw new NotImplementedException();
        }

        public override bool Eliminar(Dto.Usuario obj)
        {
            throw new NotImplementedException();
        }
    }
}
