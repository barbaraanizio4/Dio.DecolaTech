using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace Dio.Series
{
    public class SerieRepositorio : IRepositorio<series>
    {
        
        private List<Serie> listaSerie = new List<Serie>();

        public void Atualiza (int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Exclui (int id)
        {
            listaSerie[id].Excluir();
            //Se quiser que envie emails sempre que uma serie for excluida, aqui acrescentamos o implemento de envio de email.
        }

          public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

          public List<Serie> Lista()
        {
            return listaSerie;
        }

          public int ProximoId()
        {
            return listaSerie.Count;
        }

          public Serie RetornaPorId(int Id)
        {
            return listaSerie[id];
        }
    }
}