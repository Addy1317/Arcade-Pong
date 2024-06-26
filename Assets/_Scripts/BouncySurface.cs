using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SlowpokeStudio.ArcadePong
{
    public class BouncySurface : MonoBehaviour
    {
        [SerializeField] private float _bounceStrength;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Ball ball = collision.gameObject.GetComponent<Ball>();

            if (ball != null)
            {
                Vector2 normal = collision.GetContact(0).normal;
                ball.AddForce(-normal * this._bounceStrength);
            }
        }
    }
}
