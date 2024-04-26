using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject thePuck;
    public GameObject teleportTo;
    public GameObject teleportHere;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("TeleporterL"))
        {
            thePuck.transform.position = teleportTo.transform.position;
        }

        if (collision.gameObject.CompareTag("TeleporterR"))
        {
            thePuck.transform.position = teleportHere.transform.position;
        }
    }
}
