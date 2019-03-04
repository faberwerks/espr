using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
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
        FindObjectOfType<PlayerAttribute>().BuyFood();
    }

    public void EatFood()
    {
        FindObjectOfType<PlayerAttribute>().EatFood();
    }

    public void Sleep()
    {
        FindObjectOfType<PlayerAttribute>().Sleep();
    }

    public void BuyMed()
    {
        FindObjectOfType<PlayerAttribute>().BuyMed(20);
    }

    public void Play()
    {
        FindObjectOfType<GameManager>().ChangeCycle();
        FindObjectOfType<PlayerAttribute>().Play();
    }

    public void AddFood()
    {
        FindObjectOfType<BuyValue>().Add();
    }

    public void SubstractFood()
    {
        FindObjectOfType<BuyValue>().Substract();
    }
}
