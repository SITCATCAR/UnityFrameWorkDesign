
using UnityEngine;

namespace FrameworkDesign.Example
{

    public class IOCExample : MonoBehaviour
    {
        void Start()
        {
            //创建一个 IOC 容器
            var container = new IOCContainer();

            //注册一个实例
            container.Register(new BluetoothManager());

            //根据类型获取实例
            var bluetoothManager = container.Get<BluetoothManager>();

            //实例方法调用
            bluetoothManager.Connect();

        }

        public class BluetoothManager
        {
            public void Connect()
            {
                Debug.Log("蓝牙连接成功");
            }
        }

    }

}
