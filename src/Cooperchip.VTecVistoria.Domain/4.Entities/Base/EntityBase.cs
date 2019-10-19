
using System;

namespace Cooperchip.VTecVistoria.Domain._4.Entities.Base
{
    public class EntityBase
    {
        /// <summary>
        /// Entidade básica,de onde todos os models devem herdar.
        /// </summary>
        protected EntityBase()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }

        public override bool Equals(object obj)
        {
            var compareTo = obj as EntityBase;
            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;

            return Id.Equals(compareTo.Id);
        }

        public static bool operator ==(EntityBase a, EntityBase b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);

        }

        public static bool operator !=(EntityBase a, EntityBase b)
        {
            return !(a==b);
        }

        public int GetHasCode()
        {
            return (GetType().GetHashCode() * 13) + Id.GetHashCode();
        }

        public override string ToString()
        {
            return GetType().Name + "[Id=" + Id +  "]";
        }

        // Todo: Vou dar um Override no metodo Equals, que é um método que toda classe possui.
        // Todo: Por que? Porque a forma de comparar um objeto com outro é muito relativa. Lembrando que uma entidade possui identidade. Portanto para uma entidade ser igual a outra ela precisa ser do mesmo tipo e possuir o mesmo Id.



        // Todo: O campo DataCadastro deve ser incluído automaticamente, mas não deve ser alterado. Este processo será implementado no contexto da aplicação.
    }
}
