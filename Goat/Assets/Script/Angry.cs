using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Angry : MonoBehaviour
{
    public PlayerAttribute playerAttribute;

    private void Start()
    {
        playerAttribute = FindObjectOfType<PlayerAttribute>();
    }

    private void Update()
    {
        if(playerAttribute.hunger <= 30)
        {

        }
    }
}
