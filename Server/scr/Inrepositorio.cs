using Server;



namespace Server.scr
{
    public interface Inrepositorio <T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere (T Entidades);
        void Exclui(int id);
        void Atualiza(int id, T Entidades);
        int ProximoId();

    }
    
        
    
}