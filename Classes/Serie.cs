using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        // Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluído {get; set;}

        //Método de construtor

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluído = false;
        }

        public override string ToString()
        {
           // Environment.NewLine https://docs.microsoft.com/pt-br/dotnet/api/system.environment.newline?view=net-5.0
           string retorno = "";
           retorno += "Genero: " + this.Genero + Environment.NewLine;
           retorno += "Titulo: " + this.Titulo + Environment.NewLine;
           retorno += "Descricao: " + this.Descricao + Environment.NewLine;
           retorno += "Ano de inicio: " + this.Ano;
           retorno += "Excluido: " + this.Excluído;
           return retorno;
        }

        //Encapsulamento

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }
        public bool retornaExcluído()
        {
            return this.Excluído;
        }
        public void Excluir() {
            this.Excluído =  true;
        }
    }
}