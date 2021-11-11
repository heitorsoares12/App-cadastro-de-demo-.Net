using System;

namespace DIO.Series
{
    public class Demo : EntidadeBase
    {
        // Atributos
		private Mapa Mapa { get; set; }
		private string Titulo { get; set; }
		private string Player { get; set; }
		private string Descricao { get; set; }
		private int Ano { get; set; }
        private bool Excluido {get; set;}

        // Métodos
		public Demo(int id, Mapa mapa, string player, string titulo, string descricao, int ano)
		{
			this.Id = id;
			this.Mapa = mapa;
			this.Player = player;
			this.Titulo = titulo;
			this.Descricao = descricao;
			this.Ano = ano;
            this.Excluido = false;
		}

        public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Mapa: " + this.Mapa + Environment.NewLine;
			retorno += "Player: " + this.Player + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
		}

		 public string retornaPlayer()
		{
			return this.Titulo;
		}
        public string retornaTitulo()
		{
			return this.Titulo;
		}

		public int retornaId()
		{
			return this.Id;
		}
        public bool retornaExcluido()
		{
			return this.Excluido;
		}
        public void Excluir() {
            this.Excluido = true;
        }
    }
}