namespace completion.bond.core
{
    public interface IEngine<TModel>
    {
        void Add(TModel model);
        void Run();
        void Stop();
    }
}
