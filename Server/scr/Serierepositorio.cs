using Server;
using System.Collections.Generic;


namespace Server.scr
{
    public class Serierepositorio : Inrepositorio<Series>
    {

        private List<Series> ListaSeries = new List<Series>();
        public void Atualiza(int id, Series Entidades)
        {
            ListaSeries[id] = Entidades;
        }

        public void Exclui(int id)
        {
            ListaSeries[id].Excluir();  
        }

        public void Insere(Series Entidades)
        {
            ListaSeries.Add(Entidades);
        }

        public List<Series> Lista()
        {
            return ListaSeries;
        }

        public int ProximoId()
        {
           return ListaSeries.Count;
        }

        public Series RetornaPorId(int id)
        {
           return ListaSeries[id];
        }
    }
}