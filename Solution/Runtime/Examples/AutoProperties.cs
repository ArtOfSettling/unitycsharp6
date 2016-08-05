using UnityEngine;

namespace Runtime.Examples
{
    public class AutoProperties : MonoBehaviour
    {
        private static Vector3 ReadonlyProperty { get; } = new Vector3(0.1f, 0.5f, 1.0f);
        private string Property { get; set; } = "No need for a backing store";

        public void Awake()
        {
            Debug.Log(ReadonlyProperty);
            Debug.Log(Property);
        }
    }
}