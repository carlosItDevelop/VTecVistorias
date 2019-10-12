using System;
using System.Collections.Generic;
using System.Text;

namespace Cooperchip.VTecVistoria.Domain._4.Entities._1.Base
{
    public class EntityBase
    {
        public EntityBase()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
