using System;

namespace Dio.Series
{
    public class Serie : EntidadeBase
    {
        //Atributos

        public Serie(string titulo, Genero genero, string descricao, int ano, bool excluido) 
        {
            this.Titulo = titulo;
                this.Genero = genero;
                this.Descricao = descricao;
                this.Ano = ano;
                this.Excluido = excluido;
               
        }
                private string Titulo {get;set;}

        private Genero Genero {get; set;}

        private string Descricao {get; set;}

        private int Ano {get; set;}

        private bool Excluido {get; set;}


        //Metodos

        public Serie (int id, Genero genero, string titulo, string descricao, int Ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de início: " + this.Ano + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido;
            return retorno;
        
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public void Excluir() {
            this.Excluido = true;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }


    }

}