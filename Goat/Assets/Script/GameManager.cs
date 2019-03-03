using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int dayCycle;
    public GameObject morningBg;
    public GameObject afternoonBg;
    public GameObject nightBg;

    public void ChangeCycle()
    {
        dayCycle++;
        if(dayCycle%3 == 0)
        {
            EraseBg();
            morningBg.SetActive(true);
        }
        else if (dayCycle % 3 == 1)
        {
            EraseBg();
            afternoonBg.SetActive(true);
        }
        else if (dayCycle % 3 == 2)
        {
            EraseBg();
            nightBg.SetActive(true);
        }

        FindObjectOfType<PlayerAttribute>().hunger -= 10;
    }

    private void EraseBg()
    {
        morningBg.SetActive(false);
        afternoonBg.SetActive(false);
        nightBg.SetActive(false);
    }
}
