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
}
