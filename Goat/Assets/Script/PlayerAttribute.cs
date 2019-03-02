using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAttribute : MonoBehaviour
{
    public float hunger;
    public float energy;
    public float fun;
    public float apathy;
    public float social;

    public float fullHunger;
    public float fullEnergy;
    public float fullFun;
    public float fullApathy;

    public Image hungerBar;

    private void Start()
    {
        fullHunger = 100;
        hunger = 80;
    }

    private void Update()
    {
        hungerBar.fillAmount = hunger / fullHunger;
    }
}
