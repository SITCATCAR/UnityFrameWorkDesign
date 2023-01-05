using FrameworkDesign;

namespace CounterApp
{


    public class MultiplyCommand : ICommand
    {
        public void Execute()
        {
            CounterApp.Get<CounterModel>().Count.Value *= 2;
        }
    }
}
