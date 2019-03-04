using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int dayCycle;

    public float hungerDecrease;
    public float funDecrease;
    public float energyDecrease;

    public float starvingCounter;
    public float dyingCounter;

    private void Start()
    {
        starvingCounter = 0;
        dyingCounter = 0;
        hungerDecrease = 15;
        funDecrease = 15;
        energyDecrease = 15;
    }

    public void ChangeCycle()
    {
        
        FindObjectOfType<State>().UpdateState();
        FindObjectOfType<PlayerAttribute>().FoodSpoil();
        FindObjectOfType<PlayerAttribute>().hunger -= hungerDecrease;
        FindObjectOfType<PlayerAttribute>().fun -= funDecrease;
        FindObjectOfType<PlayerAttribute>().energy -= energyDecrease;
        dayCycle++;
        CheckDead();
        Dead();
        if (dayCycle % 2 == 0)
        {
            FindObjectOfType<ShoEvent>().StartEvent();
            foreach (GameObject place in FindObjectOfType<PlaceManager>().places)
            {
                if (place.GetComponent<PlaceText>() != null && place.GetComponent<PlaceText>().places.background.GetComponent<SpriteRenderer>() != null)
                {
                    place.GetComponent<PlaceText>().places.background.GetComponent<SpriteRenderer>().sprite = place.GetComponent<PlaceText>().places.backgroundSprite[0];
                }
                
            }
        }
        if (dayCycle % 2 == 1)
        {

            foreach (GameObject place in FindObjectOfType<PlaceManager>().places)
            {
                if (place.GetComponent<PlaceText>() != null && place.GetComponent<PlaceText>().places.background.GetComponent<SpriteRenderer>() != null)
                {
                    place.GetComponent<PlaceText>().places.background.GetComponent<SpriteRenderer>().sprite = place.GetComponent<PlaceText>().places.backgroundSprite[1];
                }
            }
        }
       
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

    public void CheckDead()
    {
        if(FindObjectOfType<PlayerAttribute>().energy <= 0)
        {
            dyingCounter++;
        }
        if (FindObjectOfType<PlayerAttribute>().hunger <= 0)
        {
            starvingCounter++;
        }
    }

    public void Dead()
    {
       if(dyingCounter >= 2)
        {
            SceneManager.LoadScene(0);
        }
        if (starvingCounter >= 2)
        {
            SceneManager.LoadScene(0);
        }
    }
    
}
