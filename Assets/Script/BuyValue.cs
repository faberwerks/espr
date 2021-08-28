using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyValue : MonoBehaviour
{
    public int value;
    public Text valueText;

    private void Start()
    {
        value = 1;
    }

    private void Update()
    {
        valueText.text = value.ToString();
    }

    public void Add()
    {
        if(value * 150 <= FindObjectOfType<PlayerAttribute>().money-150)
        {
            value++;
        }
    }

    public void Substract()
    {
        if(value > 1)
        {
            value--;
        }
    }
}
