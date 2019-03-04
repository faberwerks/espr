using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    public int angryLv;
    public int apathyLv;
    public PlayerAttribute playerAttribute;

    private void Start()
    {
        playerAttribute = FindObjectOfType<PlayerAttribute>();
    }

    private void Update()
    {
        if (playerAttribute.energy <= 10 || playerAttribute.fun <= 10)
        {
            angryLv = 3;
        }
        else if (playerAttribute.energy <= 20 || playerAttribute.fun <= 20)
        {
            angryLv = 2;
        }
        else if (playerAttribute.energy <= 30 || playerAttribute.fun <= 30)
        {
            angryLv = 1;
        }
        else
        {
            angryLv = 0;
        }

        if (playerAttribute.hunger <= 10 || playerAttribute.fun <= 10)
        {
            apathyLv = 3;
        }
        else if (playerAttribute.hunger <= 20 || playerAttribute.fun <= 20)
        {
            apathyLv = 2;
        }
        else if (playerAttribute.hunger <= 30 || playerAttribute.fun <= 30)
        {
            apathyLv = 1;
        }
        else
        {
            apathyLv = 0;
        }
    }

}
