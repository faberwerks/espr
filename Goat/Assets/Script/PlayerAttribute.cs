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

    private bool sick;

    public Queue<Food> foods;

    public float fullHunger;
    public float fullEnergy;
    public float fullFun;

    public Image hungerBar;
    public Image energyBar;
    public Image funBar;
    public Text moneyText;

    private void Start()
    {
        foods = new Queue<Food>();
        sick = false;
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

    public void BuyFood(int value)
    {
        if (money >= 10)
        {
            for (int x = 0; x < value; x++)
            {
                money -= 10;
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
        if(food.timeLeght > 6)
        {
            sick = true;
        }
        hunger += 10;
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
        FindObjectOfType<GameManager>().ChangeCycle();
        energy += 30;
    }

    private void IsSick()
    {
        FindObjectOfType<GameManager>().IsSick(sick);
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
        fun += 20;
    }
}
