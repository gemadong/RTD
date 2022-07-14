using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this; 
        }
        else
        {
            if (instance != this)
                Destroy(this.gameObject); 
        }
        DontDestroyOnLoad(gameObject);
    }

    public int money;
    public float[] currentIngredient;
    public int[] classCount;
    public int[] price;
    public float[] ingredientMax;
}
