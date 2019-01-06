namespace completion.bond.core
{
    public interface IGenerator<TModel>
    {
        void Create(TModel model);
    }
}
