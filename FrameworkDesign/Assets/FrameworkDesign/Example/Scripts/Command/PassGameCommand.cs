using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrameworkDesign.Example
{


    public struct PassGameCommand : ICommand
    {
        public void Execute()
        {
            GamePassEvent.Trigger();
        }
    }
}