using Server;


namespace Server
{
    public class Series:Entidades
    {

        private Genero genero {get;set;}
        private string NamePiloto {get;set;}
        private int Ano {get;set;}
        private string ChefeDeEquipe {get;set;}

        private Boolean Excluido {get; set;}



        public Series(int id, Genero genero, string NamePiloto, int Ano, string ChefeDeEquipe)
        {
            this.id = id;
            this.genero= genero;
            this.Ano= Ano;
            this.ChefeDeEquipe= ChefeDeEquipe;
            this.Excluido = false;

        }

        public override string ToString()
        {
            string retorno= "";
            retorno+="genero: "+this.genero + Environment.NewLine;
            retorno+="NamePiloto: "+this.NamePiloto + Environment.NewLine;
            retorno+="Ano: "+this.Ano + Environment.NewLine;
            retorno+="ChefeDeEquipe: "+this.ChefeDeEquipe + Environment.NewLine;
            retorno+="Excluido: "+this.Excluido + Environment.NewLine;
            return retorno;     
        }

        public string RetornaPiloto()
        {
            return this.NamePiloto;
        }
          public int RetornaId()
        {
            return this.id;
        }
            
        public void Excluir()
        {   
            this.Excluido=true;

        }    
        

        
    }


    


    public enum Genero{

                AMG = 1,
                RedBull =2,
                Ferrari=3,
                Williams=4,
                McLaren=5,
                AlfaRomeo=6,
                Scuderia=7,
                Alpine=8,
                ManorRacing=9,
                TeamLotus=10,
                BmwSauber=11

            }



}
