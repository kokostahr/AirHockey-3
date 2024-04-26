using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckTeleportation : MonoBehaviour
{
    GameObject currentTeleporter;
   
  

   
    void Update()
    {
        if (currentTeleporter != null)
        {
            transform.position = currentTeleporter.GetComponent<Portals>().GetDestination().position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Teleporter"))
        {
            currentTeleporter = collision.gameObject;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Teleporter"))
        {
            if (collision.gameObject == currentTeleporter)
            {
                currentTeleporter = null;
            }
        }
    }
}
