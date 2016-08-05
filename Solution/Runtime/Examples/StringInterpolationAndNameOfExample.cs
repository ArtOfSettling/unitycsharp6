using UnityEngine;

namespace Runtime.Examples
{
    public class StringInterpolationAndNameOfExample : MonoBehaviour
    {
        public void Awake()
        {
            Debug.Log($"Called from the {nameof(Awake)} Method");
        }
    }
}