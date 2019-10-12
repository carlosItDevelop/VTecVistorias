using System;
using System.Collections.Generic;
using System.Text;

namespace Cooperchip.VTecVistoria.Domain._4.Entities.Base
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
