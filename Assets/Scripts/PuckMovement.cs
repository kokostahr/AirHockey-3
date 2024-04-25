using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckMovement : MonoBehaviour
{
    public float puckSpeed = 10f;

    //A bool that will be used to determine which player starts, depending on who hit the puck before scoring
    //When this bool is true, the puck should move toward player 1
    public bool playerWanStart = true;
    
    public Rigidbody2D rigidBody2D;

    //SINCE I made a custom function, I'll need to use Invoke so that I can call the function under Start
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        StartCoroutine(Begin());
        //Invoke("PuckMoves", 2); 
    }

    //creating another custom function to reset the ball with each goal
    void ResetPuck()
    {
        //Don't want the puck to move unnecessarily, temporarily lock it in place using vector co-ordinates
        rigidBody2D.velocity = new Vector2(0, 0);
        //The puck should move back to the centre after a goal is scored
        transform.position = new Vector2(0, 0);
    }

    //Invoke isn't working for some reason, so I'll use a coroutine to call PuckMoves and ResetPuck
    public IEnumerator Begin()
    {
        ResetPuck();
        yield return new WaitForSeconds(5);
        //Now the puck will move ONLY to the right for player 1 T^T, only when the bool is true
        if (playerWanStart == true)
        {
            PuckMoves(new Vector2(1, 0));
        }
        else
        {
            PuckMoves(new Vector2(-1, 0));
        }
    }

    //creating a function for the (random) movement of the puck. Need to ask why this didn't end up working ;(
    public void PuckMoves(Vector2 direction)
    {
        direction = direction.normalized;
        rigidBody2D.velocity = direction * puckSpeed;
    }

    
   
}


//Setting up the bonus points system. The puck movement will also speed up when it travels through a bonus point. 
/* private void OnTriggerEnter2D(Collider2D collision)
 {
     //Puck speeds up when it travels through bonus point. The player who hit the paddle last gains a point
     if (collision.tag == "Bonus" && collision.gameObject.name == "Paddle 1")
     {
         //Need assistance, the puck isn't speeding up when it passes through the bonus
         /*puckSpeed = extraSpeed;
         extraSpeed = startSpeed + 3f;
         //Here i tried to write code that links to the player that hit the paddle last, and would give an extra point if the puck passes through the Bonus
         //But I am scared thst the paddles may get deleted too, as I want the bonus point region to disappear after the puck has passed through. 
         scoreTally.PlayerWanGoal();
         float delayTime = 0.5f;
         Destroy(collision.gameObject, delayTime);

         Debug.Log("Bonus for Wan");
     }
    else if(collision.tag == "Bonus" && collision.gameObject.name == "Paddle 2")
     {
         scoreTally.PlayerTooGoal();
         float delayedTime = 0.5f;
         Destroy(collision.gameObject, delayedTime);
         Debug.Log("Bonus for Too");
     }
 }*/