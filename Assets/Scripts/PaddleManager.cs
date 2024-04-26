using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleManager : MonoBehaviour
{
    [SerializeField]
    private PaddleMovement playerPaddle;

    [SerializeField]
    private AIMovement aiMovement;

    [SerializeField]
    private Transform playerResetPosition, aiResetPosition;
    public PuckMovement1 puckMovement;

    private void Start()
    {
        ResetPaddle();
    }

    public void ResetPaddle()
    {
        if (puckMovement.playerWanStart == true || puckMovement.playerWanStart == false)
        {
            playerPaddle.transform.position = playerResetPosition.position;
            aiMovement.transform.position = aiResetPosition.position;
        }

    }
}
