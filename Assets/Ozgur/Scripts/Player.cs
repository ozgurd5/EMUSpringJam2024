using UnityEngine;

namespace Ozgur.Scripts
{
    public class Player : MonoBehaviour
    {
        public static Player Instance;
        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);
        }
    }
}