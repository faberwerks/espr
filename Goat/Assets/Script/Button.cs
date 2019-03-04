using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public int counter;

    private void Start()
    {
        counter = 0;
    }

    public void GoToScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void OpenCanvas(GameObject canvas)
    {
        canvas.SetActive(true);
    }

    public void CloseCanvas(GameObject canvas)
    {
        canvas.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void BuyFood()
    {
        if(Refusal())
        {
            return;
        }
        FindObjectOfType<PlayerAttribute>().BuyFood();
    }

    public void EatFood()
    {
        if (Refusal())
        {
            return;
        }
        FindObjectOfType<PlayerAttribute>().EatFood();
    }

    public void Sleep()
    {
        if (Refusal())
        {
            return;
        }
        FindObjectOfType<PlayerAttribute>().Sleep();
    }

    public void BuyMed()
    {
        if (Refusal())
        {
            return;
        }
        FindObjectOfType<PlayerAttribute>().BuyMed(500);
    }

    public void Play()
    {
        FindObjectOfType<GameManager>().ChangeCycle();
        FindObjectOfType<PlayerAttribute>().Play();
    }

    public void AddFood()
    {
        if (Refusal())
        {
            return;
        }
        FindObjectOfType<BuyValue>().Add();
    }

    public void SubstractFood()
    {
        if (Refusal())
        {
            return;
        }
        FindObjectOfType<BuyValue>().Substract();
    }

    public bool Refusal()
    {
        if (FindObjectOfType<State>().apathyLv >= 2)
        {
            int num = Random.Range(0, 100);
            if(counter == 0)
            {
                counter++;
                return true;
            }
            if (num > 50)
            {
                return true;
            }
            counter--;
            return false;
        }
        else if (FindObjectOfType<State>().apathyLv >= 1)
        {
            int num = Random.Range(0, 100);
            if(num > 50)
            {
                return true;
            }
            return false;
        }
        return false;
    }
}
