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
    public float money;

    public float fullHunger;
    public float fullEnergy;
    public float fullFun;

    public Image hungerBar;
    public Image energyBar;
    public Image funBar;
    public Text moneyText;

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
        moneyText.text = "Money: " + money.ToString();
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
    public void SavePlayers()
    {
        SaveData.SavePlayer(this);
    }

    public void LoadPlayers()
    {
        int dayCycle;

        PlayerData data = SaveData.LoadPlayer();
        hunger = data.hunger;
        energy = data.energy;
        fun = data.fun;
        social = data.social;
        money = data.money;
        dayCycle = data.dayCycle;
    }
}
