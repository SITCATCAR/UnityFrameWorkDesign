
namespace FrameworkDesign.Example
{


    public class GameModel : Singleton<GameModel>
    {
        private GameModel() { }
        public BindableProperty<int> KillCount = new BindableProperty<int>()
        {
            Value = 0
        };
        public BindableProperty<int> Gold = new BindableProperty<int>()
        {
            Value = 0
        };
        public BindableProperty<int> Score = new BindableProperty<int>()
        {
            Value = 0
        };
        public BindableProperty<int> BestScore = new BindableProperty<int>()
        {
            Value = 0
        };


    }

}
