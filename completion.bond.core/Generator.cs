using System;

namespace completion.bond.core
{
    public class Generator<TModel> : IGenerator<TModel>, IDisposable
    {
        private readonly IEngine<TModel> _engine;
        private bool isDisposed;
        public Generator()
        {
            this._engine = new Engine<TModel>();
            this._engine.Run();
        }

        public void Create(TModel model)
        {
            this._engine.Add(model);
        }

        public void Dispose()
        {
            this.Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.isDisposed)
            {
                if (disposing)
                {
                    this._engine.Stop();
                }
            }

            this.isDisposed = true;
        }
    }
}
