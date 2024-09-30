namespace XPe.PrjAplicado.Interop.Controllers
{
    public interface IMigrationController<TipoRetorno, TipoEntidade, TipoChave>
    {
        TipoRetorno Get(TipoChave codigo);

        TipoRetorno Get();

        TipoRetorno Post(TipoEntidade entidade);

        TipoRetorno Put(TipoChave codigo, TipoEntidade entidade);

        TipoRetorno Delete(TipoChave codigo);
    }
}
