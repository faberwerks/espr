using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAttribute : MonoBehaviour
{
    public float hunger;
    public float energy;
    public float fun;
    public float social;

    public float fullHunger;
    public float fullEnergy;
    public float fullFun;

    public Image hungerBar;
    public Image energyBar;
    public Image funBar;

    private void Start()
    {
        fullHunger = 100;
        fullEnergy = 100;
        fullFun = 100;
    }

    private void Update()
    {
        
        hungerBar.fillAmount = hunger / fullHunger;
        energyBar.fillAmount = energy / fullEnergy;
        funBar.fillAmount = fun / fullFun;
    }

    private void CheckFull()
    {
        if (hunger >= fullHunger)
        {
            hunger = fullHunger;
        }
        if (energy >= fullEnergy)
        {
            energy = fullEnergy;
        }
        if (fun >= fullFun)
        {
            fun = fullFun;
        }
        
    }
}
