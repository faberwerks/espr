using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public void BecameGoal()
    {
        FindObjectOfType<PlayerMovement>().goal = gameObject;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "PlayerCharacter" && collision.GetComponent<PlayerMovement>().isInteracting && collision.GetComponent<PlayerMovement>().goal == gameObject)
        {
            Debug.Log("Interacting");
            collision.GetComponent<PlayerMovement>().goal = null;
            collision.GetComponent<PlayerMovement>().isInteracting = false;
            FindObjectOfType<GameManager>().ChangeCycle();
        }
    }
}
