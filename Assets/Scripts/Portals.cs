using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portals : MonoBehaviour
{

    [SerializeField] Transform destination;

    public Transform GetDestination()
    {
        return destination;
    }
































  /* [SerializeField] Transform destination;

    public bool isPurpleL;
    public float distance = 0.2f;

    
    void Start()
    {
        if (isPurpleL == false)
        {
            destination = GameObject.FindGameObjectWithTag("Portal R").GetComponent<Transform>();
        }
        else
        {
            destination = GameObject.FindGameObjectWithTag("Portal L").GetComponent<Transform>();
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (Vector2.Distance(transform.position, other.transform.position) > distance)
        {
            if (other.tag == "Puck")
            {
                other.transform.position = new Vector2(destination.position.x, destination.position.y);
            }
        }
    }

    void Update()
    {
        
    }*/
}
