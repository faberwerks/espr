using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoEvent : MonoBehaviour
{
    public void StartEvent()
    {
        if(FindObjectOfType<GameManager>().dayCycle % 2 == 1)
        {
            FindObjectOfType<PlayerAttribute>().energyReplenish = 10;
        }
    }
}
