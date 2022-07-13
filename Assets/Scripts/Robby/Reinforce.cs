using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reinforce : MonoBehaviour
{
    [SerializeField] private RobbyManager RM;
    [SerializeField] private GameObject panel;
    [SerializeField] private Text[] classText;
    [SerializeField] private Text[] ingredientText;
    [SerializeField] private Text[] priceText;
    [SerializeField] private Slider[] slider;

    public int[] classCount;
    public int[] price;
    public float[] ingredientMax;

    bool isOpen = false;

    private void Update()
    {
        classText[0].text = classCount[0] + " 클래스";
        classText[1].text = classCount[1] + " 클래스";
        classText[2].text = classCount[2] + " 클래스";
        classText[3].text = classCount[3] + " 클래스";
        classText[4].text = classCount[4] + " 클래스";
        classText[5].text = classCount[5] + " 클래스";
        classText[6].text = classCount[6] + " 클래스";
        classText[7].text = classCount[7] + " 클래스";

        ingredientText[0].text = RM.currentIngredient[0] + " / " + ingredientMax[0];
        ingredientText[1].text = RM.currentIngredient[1] + " / " + ingredientMax[1];
        ingredientText[2].text = RM.currentIngredient[2] + " / " + ingredientMax[2];
        ingredientText[3].text = RM.currentIngredient[3] + " / " + ingredientMax[3];
        ingredientText[4].text = RM.currentIngredient[4] + " / " + ingredientMax[4];
        ingredientText[5].text = RM.currentIngredient[5] + " / " + ingredientMax[5];
        ingredientText[6].text = RM.currentIngredient[6] + " / " + ingredientMax[6];
        ingredientText[7].text = RM.currentIngredient[7] + " / " + ingredientMax[7];


        priceText[0].text = "강화하기\n"+"$"+ price[0];
        priceText[1].text = "강화하기\n"+"$"+ price[1];
        priceText[2].text = "강화하기\n"+"$"+ price[2];
        priceText[3].text = "강화하기\n"+"$"+ price[3];
        priceText[4].text = "강화하기\n"+"$"+ price[4];
        priceText[5].text = "강화하기\n"+"$"+ price[5];
        priceText[6].text = "강화하기\n"+"$"+ price[6];
        priceText[7].text = "강화하기\n"+"$"+ price[7];

        slider[0].value = RM.currentIngredient[0] / ingredientMax[0];
        slider[1].value = RM.currentIngredient[1] / ingredientMax[1];
        slider[2].value = RM.currentIngredient[2] / ingredientMax[2];
        slider[3].value = RM.currentIngredient[3] / ingredientMax[3];
        slider[4].value = RM.currentIngredient[4] / ingredientMax[4];
        slider[5].value = RM.currentIngredient[5] / ingredientMax[5];
        slider[6].value = RM.currentIngredient[6] / ingredientMax[6];
        slider[7].value = RM.currentIngredient[7] / ingredientMax[7];
    }                                                
                                                     
    public void ReinforceTry(int i)                  
    {                                                
        if(RM.currentIngredient[i]>= ingredientMax[i] && RM.money>= price[i])
        {
            RM.money -= price[i];
            RM.currentIngredient[i] -= ingredientMax[i];
            price[i] *= 2;
            ingredientMax[i] *= 2;
            classCount[i] += 1;
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
