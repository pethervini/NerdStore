using NerdStore.Core.DomainObjects;
using System.Collections;
using System.Collections.Generic;

namespace NerdStore.Catalogo.Domain
{
    public class Categoria : Entity
    {
        public Categoria(string nome, int codigo)
        {
            Nome = nome;
            Codigo = codigo;
        }

        public string Nome { get; private set; }
        public int Codigo { get; private set; }

        // EF Relation
        public ICollection<Produto> Produtos { get; private set; }

        protected Categoria()
        { }

        public override string ToString()
        {
            return $"{Nome} - {Codigo}";
        }
    }

}
