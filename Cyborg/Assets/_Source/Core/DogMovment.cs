using UnityEngine;

namespace _Source.Core
{
    public class DogMovment : MonoBehaviour
    {
        public Rigidbody body;
        public float moveForce = 10f;
        
        void Update()
        {
            MoveForward();
        }

        void MoveForward()
        {
            body.AddForce(Vector3.forward * moveForce, ForceMode.Force);
        }
    }
}
