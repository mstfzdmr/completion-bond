using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace completion.bond.core
{
    public class Engine<TModel> : IEngine<TModel>
    {
        private readonly BlockingCollection<TModel> blockingCollection;

        private readonly CancellationTokenSource cancellationTokenSource;

        public Engine()
        {
            this.cancellationTokenSource = new CancellationTokenSource();
            this.blockingCollection = new BlockingCollection<TModel>();
        }

        public void Add(TModel model)
        {
            this.blockingCollection.Add(model);
        }

        public void Run()
        {
            Task.Factory.StartNew(() => { }, TaskCreationOptions.LongRunning);
        }

        public void Stop()
        {
            this.cancellationTokenSource.Cancel();
            this.blockingCollection.CompleteAdding();
            this.blockingCollection.Dispose();
        }
    }
}
