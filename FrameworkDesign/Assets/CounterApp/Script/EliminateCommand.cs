
using FrameworkDesign;

namespace CounterApp
{


    public struct EliminateCommand : ICommand
    {
        public void Execute()
        {
            CounterApp.Get<CounterModel>()
            .Count.Value = 0;
        }
    }
}
