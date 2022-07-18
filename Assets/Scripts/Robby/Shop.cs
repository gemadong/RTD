using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject[] dailyPanel;
    [SerializeField] private Text[] currentItemText;
    [SerializeField] private Text[] PriceText;
    [SerializeField] private Text[] dailyPriceText;
    [SerializeField] private Text[] nameText;
    [SerializeField] private int[] itemPrice;
    [SerializeField] private int[] moneyPuls;
    [SerializeField] private string[] itemName;
    [SerializeField] private bool[] dailyItem;

    public List<int> dailyCount;
    
    bool isOpen = false;

    private void Start()
    {
        for(int i = 0; i < 6; i++)
        {
            dailyItem[i] = false;
        }
        DailyShop();
    }

    private void Update()
    {
        for (int i = 0; i < 6; i++)
        {
            currentItemText[i].text = "º¸À¯ " + Singleton.instance.currentItem[i].ToString() + " °³";
            PriceText[i].text = "$" + itemPrice[i];
        }
    }

    public void DailyShop()
    {
        for(int i = 0; i <6; i++)
        {
            int R = Random.Range(0, 6);
            nameText[i].text = itemName[R];
            dailyPriceText[i].text = "$" + itemPrice[R];
            dailyCount.Add(R);
        }

    }
    public void DailyBuyItem(int i)
    {
        if (!dailyItem[i] && Singleton.instance.money >= itemPrice[dailyCount[i]])
        {
            Singleton.instance.money -= itemPrice[dailyCount[i]];
            Singleton.instance.currentItem[dailyCount[i]]++;
            dailyPanel[i].SetActive(true);
            dailyItem[i] = true;
        }
    }
    public void BuyItem(int i )
    {
        if(Singleton.instance.money >= itemPrice[i])
        {
            Singleton.instance.money -= itemPrice[i];
            Singleton.instance.currentItem[i]++;

        }
    }

    public void BuyMoney(int i)
    {
        Singleton.instance.money += moneyPuls[i];
    }

    public void OpenPanel()
    {
        if (isOpen)
        {
            panel.SetActive(false);
            isOpen = false;
        }
        else
        {
            panel.SetActive(true);
            isOpen = true;
        }
    }

    
}
