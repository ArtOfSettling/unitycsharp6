using System.Threading.Tasks;
using UnityEngine;

namespace Runtime.Examples
{
    // Ok, this isn't really a csharp 6 feature, but it's pretty cool
    public class AsyncAwait : MonoBehaviour
    {
        public void Awake()
        {
            TaskEx.Run(AsynchronousMethod);
        }

        private static async Task AsynchronousMethod()
        {
            Debug.Log("Before AsynchronousMethod");
            await TaskEx.Delay(2000); // Long delay here since we don't actually have anything to do.
            Debug.Log("Middle AsynchronousMethod");
            await TaskEx.Delay(2000); // Long delay here since we don't actually have anything to do.
            Debug.Log("After AsynchronousMethod");
        }
    }
}