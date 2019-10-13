
using System;

namespace Cooperchip.VTecVistoria.Domain._4.Entities.Base
{
    public class EntityBase
    {
        /// <summary>
        /// Entidade básica,de onde todos os models devem herdar.
        /// </summary>
        public EntityBase()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }

        // Todo: O campo DataCadastro deve ser incluído automaticamente, mas não deve ser alterado. Este processo será implementado no contexto da aplicação.
    }
}
