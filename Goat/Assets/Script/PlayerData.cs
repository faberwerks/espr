using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{

    public float hunger;
    public float energy;
    public float fun;
    public float social;
    public float money;
    public int dayCycle;

    public PlayerData (PlayerAttribute player)
    {
        hunger = player.hunger;
        energy = player.energy;
        fun = player.fun;
        social = player.social;
        money = player.money;
    }

    public PlayerData (GameManager player)
    {
        dayCycle = player.dayCycle;
    }

}
