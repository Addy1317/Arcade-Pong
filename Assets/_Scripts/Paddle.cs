using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SlowpokeStudio.ArcadePong
{
    public class Paddle : MonoBehaviour
    {
        [SerializeField] internal float speed = 10.0f;
        protected Rigidbody2D rigidbody2d;

        private void Awake()
        {
            rigidbody2d = GetComponent<Rigidbody2D>();
        }
    }
}