using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoFilmes.Enum;

namespace ProjetoFilmes
{
    public class FilmeRepositorio : IRepositorio<Filmes>
    {
        private List<Filmes> listafilmes = new List<Filmes>();
        public void Atualiza(int id, Filmes entidade)
        {
            listafilmes[id] = entidade;
        }

        public void Exclui(int id)
        {
            listafilmes[id].Excluir();
        }

        public void Insere(Filmes entidade)
        {
            listafilmes.Add(entidade);
        }

        

        public List<Filmes> Lista()
        {
            return listafilmes;
        }

        public int ProximoId()
        {
            return listafilmes.Count;
        }

        public Filmes RetornaPorId(int id)
        {
            return listafilmes[id];
        }
    }
}
