using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDirection : MonoBehaviour
{
    //public PuckMovement puckMovement;
    public float reflectionAngle;
   

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Puck"))
        {
            Rigidbody2D rb = other.gameObject.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                Vector2 velocity = rb.velocity.normalized;
                Vector2 normal = (other.transform.position - transform.position).normalized;
                Vector2 direction = Vector2.Reflect(velocity, normal).normalized;

                rb.velocity = direction * rb.velocity.magnitude;
            }
        }
    }
}
