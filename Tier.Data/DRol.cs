using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tier.Data
{
    public class DRol : ParentData<Dto.Rol>
    {
        #region [Constructores]
        public DRol()
            : base()
        {

        }

        public DRol(string strCnnStr)
            : base(strCnnStr)
        {

        }
        #endregion

        public override void CargarParametros(MySql.Data.MySqlClient.MySqlCommand cmd, Dto.Rol obj)
        {
            cmd.Parameters.AddRange(new MySql.Data.MySqlClient.MySqlParameter[] { 
                    new MySql.Data.MySqlClient.MySqlParameter("intAccion", uspAcciones.Insertar),
                    new MySql.Data.MySqlClient.MySqlParameter("intidrol", obj.idrol),
                    new MySql.Data.MySqlClient.MySqlParameter("strnombre", obj.nombre),
                    new MySql.Data.MySqlClient.MySqlParameter("strdescripcion", obj.descripcion),
                    new MySql.Data.MySqlClient.MySqlParameter("blnactivo", obj.activo),
                    new MySql.Data.MySqlClient.MySqlParameter("datfechacreacion", obj.fechacreacion),
                });
        }

        public override IEnumerable<Dto.Rol> RecuperarFiltrados(Dto.Rol obj)
        {
            throw new NotImplementedException();
        }

        public override bool Insertar(Dto.Rol obj)
        {
            using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand())
            {
                cmd.CommandText = "seguridad.uspGestionRoles";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                this.CargarParametros(cmd, obj);

                obj.idrol = Convert.ToInt16(base.CurrentDatabase.ExecuteScalar(cmd));

                return obj.idrol > 0;
            }
        }

        public override bool Actualizar(Dto.Rol obj)
        {
            throw new NotImplementedException();
        }

        public override bool Eliminar(Dto.Rol obj)
        {
            throw new NotImplementedException();
        }
    }
}
