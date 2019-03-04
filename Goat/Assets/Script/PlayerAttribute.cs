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

    public bool ApathyLv3;

    private bool sick;

    public Queue<Food> foods;

    public float fullHunger;
    public float fullEnergy;
    public float fullFun;

    public float energyReplenish;
    public float funReplenish;
    public float hungerReplenish;

    public Image hungerBar;
    public Image energyBar;
    public Image funBar;
    public Text moneyText;

    public GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        foods = new Queue<Food>();
        sick = false;
        energyReplenish = 45;
        funReplenish = 45;
        hungerReplenish = 30;
        fullHunger = 100;
        fullEnergy = 100;
        fullFun = 100;
    }

    private void Update()
    {
        CheckFull();
        ShoEvent();
        hungerBar.fillAmount = hunger / fullHunger;
        energyBar.fillAmount = energy / fullEnergy;
        funBar.fillAmount = fun / fullFun;
        moneyText.text = "Money: " + money.ToString();
        IsSick();
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
        if (hunger <= 0)
        {
            hunger = 0;
        }
        if (energy <= 0)
        {
            energy = 0;
        }
        if (fun <= 0)
        {
            fun = 0;
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

    public void BuyFood()
    {
        int value = FindObjectOfType<BuyValue>().value;
        if (money >= 150)
        {
            for (int x = 0; x < value; x++)
            {
                money -= 150;
                Food food = new Food();
                food.timeLeght = 0;
                foods.Enqueue(food);
            }
        }
        else
        {
            Debug.Log("money not enough");
        }
    }

    public void EatFood()
    {
        if(foods.Count <= 0)
        {
            Debug.Log("Food Empty");
            return;
        }
        
        Food food = foods.Dequeue();
        if(food.timeLeght > 4)
        {
            sick = true;
        }
        hunger += hungerReplenish;
    }

    public void FoodSpoil()
    {
        foreach(Food food in foods)
        {
            food.timeLeght += 1;
        }
    }

    public void Sleep()
    {
        gameManager.ChangeCycle();
        energy += energyReplenish;
    }

    private void IsSick()
    {
        gameManager.IsSick(sick);
    }

    public void BuyMed(int medPrice)
    {
        if(money < medPrice)
        {
            return;
        }
        money -= medPrice;
        sick = false;
    }

    public void Play()
    {
        fun += funReplenish;
    }

    private void ShoEvent()
    {
        if(gameManager.dayCycle >= 6)
        {
            FindObjectOfType<ShoEvent>().StartEvent();
        }
    }

    public void IsComingBack()
    {
        if (gameManager.dayCycle % 2 == 0)
        {
            fun -= 30;
            hunger -= 15;
            energy -= 15;
        }
        if (gameManager.dayCycle % 2 == 1)
        {
            fun -= 30;
            hunger -= 20;
            energy -= 20;
        }
    }

}
