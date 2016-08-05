using UnityEngine;

namespace Runtime.Examples
{
    public class ExpressionBodiedMembers : MonoBehaviour
    {
        private Vector2 BottomLeft { get; } = new Vector2(0.0f, 0.0f);
        private Vector2 UpperRight { get; } = new Vector2(10.0f, 10.0f);

        private Vector2 Size() => BottomLeft + UpperRight;

        public void Awake()
        {
            Debug.Log(Size());
        }
    }
}