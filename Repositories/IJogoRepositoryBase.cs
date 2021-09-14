namespace ApiCatalogoJogos.Repositories
{
    public class IJogoRepositoryBase
    {
        Task<List<Jogo>> Obter(int pagina, int quantidade);
    }
}