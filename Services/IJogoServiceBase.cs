namespace ApiCatalogoJogos.Services
{
    public class IJogoServiceBase
    {
        Task<List<JogoViewModel>> Obter(int pagina, int quantidade);
    }
}