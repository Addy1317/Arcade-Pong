using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SlowpokeStudio.ArcadePong
{
    public class Ball : MonoBehaviour
    {
        [SerializeField] private float _speed = 100f;
        private Rigidbody2D _rigidbody2D;

        private void Awake()
        {
         _rigidbody2D = GetComponent<Rigidbody2D>();       
        }
        private void Start()
        {
            AddStartForce();
        }

        private void AddStartForce()
        {
            float x = Random.value < 0.5f ? -1.0f : 1.0f;
            float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);
         
            Vector2 direction = new Vector2(x, y);
            _rigidbody2D.AddForce(direction * this._speed);

        }
    }
}