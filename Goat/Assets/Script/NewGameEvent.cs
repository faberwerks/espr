using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGameEvent : MonoBehaviour
{
    public void StartEvent()
    {
        FindObjectOfType<PlayerAttribute>().funReplenish = 20;
    }
}
