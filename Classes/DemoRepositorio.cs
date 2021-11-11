using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
	public class DemoRepositorio : IRepositorio<Demo>
	{
        private List<Demo> listaDemo = new List<Demo>();
		public void Atualiza(int id, Demo objeto)
		{
			listaDemo[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaDemo[id].Excluir();
		}

		public void Insere(Demo objeto)
		{
			listaDemo.Add(objeto);
		}

		public List<Demo> Lista()
		{
			return listaDemo;
		}

		public int ProximoId()
		{
			return listaDemo.Count;
		}

		public Demo RetornaPorId(int id)
		{
			return listaDemo[id];
		}
	}
}