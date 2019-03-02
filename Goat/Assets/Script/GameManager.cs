using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int dayCycle;
    public GameObject morningBg;
    public GameObject afternoonBg;
    public GameObject nightBg;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
    }

    private void EraseBg()
    {
        morningBg.SetActive(false);
        afternoonBg.SetActive(false);
        nightBg.SetActive(false);
    }
}
