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
        hungerDecrease = 15;
        funDecrease = 15;
        energyDecrease = 15;
    }

    public void ChangeCycle()
    {
        dayCycle++;
        //if(dayCycle % 2 == 0)
        //{
        //    foreach(GameObject place in FindObjectOfType<PlaceManager>().places)
        //    {
        //        Place placeNow = place.GetComponent<Place>();
        //        placeNow.background.GetComponent<SpriteRenderer>().sprite = placeNow.backgroundSprite[0];
        //    }
        //}
        //if (dayCycle % 2 == 1)
        //{
        //    foreach (GameObject place in FindObjectOfType<PlaceManager>().places)
        //    {
        //        Place placeNow = place.GetComponent<Place>();
        //        placeNow.background.GetComponent<SpriteRenderer>().sprite = placeNow.backgroundSprite[1];
        //    }
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
            hungerDecrease = 25;
        }
        else
        {
            hungerDecrease = 15;
        }
    }
    
}
