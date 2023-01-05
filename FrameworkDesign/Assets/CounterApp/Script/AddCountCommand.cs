using FrameworkDesign;


namespace CounterApp
{


    public struct AddCountCommand : ICommand
    {
        public void Execute()
        {
            CounterApp.Get<CounterModel>().Count.Value++;
        }
    }
}