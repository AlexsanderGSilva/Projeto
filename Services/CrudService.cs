using System;
using System.Collections.Generic;
using MinhaAplicacao.Models; // Importe as classes Livro e Brinquedo do namespace MinhaAplicacao.Models

namespace MinhaAplicacao.Services
{
    public class CrudService
    {
        private List<Livro> livros = new List<Livro>(); // Lista para armazenar os livros
        private List<Brinquedo> brinquedos = new List<Brinquedo>(); // Lista para armazenar os brinquedos

        // Métodos CRUD para Livros
        public void CriarLivro(Livro livro)
        {
            livros.Add(livro);
        }

        public List<Livro> ObterTodosLivros()
        {
            return livros;
        }

        public Livro ObterLivroPorId(int id)
        {
            return livros.Find(l => l.Id == id);
        }

        public void AtualizarLivro(Livro livroAtualizado)
        {
            int index = livros.FindIndex(l => l.Id == livroAtualizado.Id);
            if (index != -1)
            {
                livros[index] = livroAtualizado;
            }
            else
            {
                throw new InvalidOperationException("Livro não encontrado para atualização");
            }
        }

        public void ExcluirLivro(int id)
        {
            livros.RemoveAll(l => l.Id == id);
        }

        // Métodos CRUD para Brinquedos
        public void CriarBrinquedo(Brinquedo brinquedo)
        {
            brinquedos.Add(brinquedo);
        }

        public List<Brinquedo> ObterTodosBrinquedos()
        {
            return brinquedos;
        }

        public Brinquedo ObterBrinquedoPorId(int id)
        {
            return brinquedos.Find(b => b.Id == id);
        }

        public void AtualizarBrinquedo(Brinquedo brinquedoAtualizado)
        {
            int index = brinquedos.FindIndex(b => b.Id == brinquedoAtualizado.Id);
            if (index != -1)
            {
                brinquedos[index] = brinquedoAtualizado;
            }
            else
            {
                throw new InvalidOperationException("Brinquedo não encontrado para atualização");
            }
        }

        public void ExcluirBrinquedo(int id)
        {
            brinquedos.RemoveAll(b => b.Id == id);
        }
    }
}
