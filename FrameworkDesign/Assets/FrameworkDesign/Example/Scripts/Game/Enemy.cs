
using UnityEngine;

namespace FrameworkDesign.Example
{
    public class Enemy : MonoBehaviour
    {
        // Start is called before the first frame update
        private void OnMouseDown()
        {

            Destroy(gameObject);

            new KillEnemyCommand().Execute();

        }
    }

}