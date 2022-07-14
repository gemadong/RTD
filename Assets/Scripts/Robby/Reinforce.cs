using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reinforce : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private Text[] classText;
    [SerializeField] private Text[] ingredientText;
    [SerializeField] private Text[] priceText;
    [SerializeField] private Slider[] slider;


    bool isOpen = false;

    private void Update()
    {
        classText[0].text = Singleton.instance.classCount[0] + " 클래스";
        classText[1].text = Singleton.instance.classCount[1] + " 클래스";
        classText[2].text = Singleton.instance.classCount[2] + " 클래스";
        classText[3].text = Singleton.instance.classCount[3] + " 클래스";
        classText[4].text = Singleton.instance.classCount[4] + " 클래스";
        classText[5].text = Singleton.instance.classCount[5] + " 클래스";
        classText[6].text = Singleton.instance.classCount[6] + " 클래스";
        classText[7].text = Singleton.instance.classCount[7] + " 클래스";

        ingredientText[0].text = Singleton.instance.currentIngredient[0] + " / " + Singleton.instance.ingredientMax[0];
        ingredientText[1].text = Singleton.instance.currentIngredient[1] + " / " + Singleton.instance.ingredientMax[1];
        ingredientText[2].text = Singleton.instance.currentIngredient[2] + " / " + Singleton.instance.ingredientMax[2];
        ingredientText[3].text = Singleton.instance.currentIngredient[3] + " / " + Singleton.instance.ingredientMax[3];
        ingredientText[4].text = Singleton.instance.currentIngredient[4] + " / " + Singleton.instance.ingredientMax[4];
        ingredientText[5].text = Singleton.instance.currentIngredient[5] + " / " + Singleton.instance.ingredientMax[5];
        ingredientText[6].text = Singleton.instance.currentIngredient[6] + " / " + Singleton.instance.ingredientMax[6];
        ingredientText[7].text = Singleton.instance.currentIngredient[7] + " / " + Singleton.instance.ingredientMax[7];


        priceText[0].text = "강화하기\n"+"$"+ Singleton.instance.price[0];
        priceText[1].text = "강화하기\n"+"$"+ Singleton.instance.price[1];
        priceText[2].text = "강화하기\n"+"$"+ Singleton.instance.price[2];
        priceText[3].text = "강화하기\n"+"$"+ Singleton.instance.price[3];
        priceText[4].text = "강화하기\n"+"$"+ Singleton.instance.price[4];
        priceText[5].text = "강화하기\n"+"$"+ Singleton.instance.price[5];
        priceText[6].text = "강화하기\n"+"$"+ Singleton.instance.price[6];
        priceText[7].text = "강화하기\n"+"$"+ Singleton.instance.price[7];

        slider[0].value = Singleton.instance.currentIngredient[0] / Singleton.instance.ingredientMax[0];
        slider[1].value = Singleton.instance.currentIngredient[1] / Singleton.instance.ingredientMax[1];
        slider[2].value = Singleton.instance.currentIngredient[2] / Singleton.instance.ingredientMax[2];
        slider[3].value = Singleton.instance.currentIngredient[3] / Singleton.instance.ingredientMax[3];
        slider[4].value = Singleton.instance.currentIngredient[4] / Singleton.instance.ingredientMax[4];
        slider[5].value = Singleton.instance.currentIngredient[5] / Singleton.instance.ingredientMax[5];
        slider[6].value = Singleton.instance.currentIngredient[6] / Singleton.instance.ingredientMax[6];
        slider[7].value = Singleton.instance.currentIngredient[7] / Singleton.instance.ingredientMax[7];
    }                                                
                                                     
    public void ReinforceTry(int i)                  
    {                                                
        if(Singleton.instance.currentIngredient[i]>= Singleton.instance.ingredientMax[i] && Singleton.instance.money >= Singleton.instance.price[i])
        {
            Singleton.instance.money -= Singleton.instance.price[i];
            Singleton.instance.currentIngredient[i] -= Singleton.instance.ingredientMax[i];
            Singleton.instance.price[i] *= 2;
            Singleton.instance.ingredientMax[i] *= 2;
            Singleton.instance.classCount[i] += 1;
        }
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
