using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int dayCycle;

    public float hungerDecrease;
    public float funDecrease;
    public float energyDecrease;

    private void Start()
    {
        hungerDecrease = 10;
        funDecrease = 10;
        energyDecrease = 10;
    }

    public void ChangeCycle()
    {
        dayCycle++;
        //if(dayCycle%3 == 0)
        //{
        //    EraseBg();
        //    morningBg.SetActive(true);
        //}
        //else if (dayCycle % 3 == 1)
        //{
        //    EraseBg();
        //    afternoonBg.SetActive(true);
        //}
        //else if (dayCycle % 3 == 2)
        //{
        //    EraseBg();
        //    nightBg.SetActive(true);
        //}
        FindObjectOfType<PlayerAttribute>().FoodSpoil();
        FindObjectOfType<PlayerAttribute>().hunger -= hungerDecrease;
        FindObjectOfType<PlayerAttribute>().fun -= funDecrease;
        FindObjectOfType<PlayerAttribute>().energy -= energyDecrease;
    }

    private void EraseBg()
    {
        //morningBg.SetActive(false);
        //afternoonBg.SetActive(false);
        //nightBg.SetActive(false);
    }

    public void IsSick(bool sick)
    {
        if(sick)
        {
            hungerDecrease = 15;
        }
        else
        {
            hungerDecrease = 10;
        }
    }
}
