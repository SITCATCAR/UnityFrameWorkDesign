using FrameworkDesign;

namespace CounterApp
{

    public class CounterApp
    {
        private static IOCContainer mContainer;

        static void MakeSureContainer()
        {
            if (mContainer == null)
            {
                mContainer = new IOCContainer();
                Init();
            }
        }

        static void Init()
        {
            mContainer.Register(new CounterModel());
        }

        public static T Get<T>() where T : class
        {
            MakeSureContainer();

            return mContainer.Get<T>();
        }
    }

}