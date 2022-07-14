using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private GameObject panel;

    bool isOpen = false;

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

    //[SerializeField] private RobbyManager RM;

    //[SerializeField] private GameObject[] freeButten;
    //[SerializeField] private GameObject[] oneButten;
    //[SerializeField] private GameObject tenButten;

    //public int[] CoinPlus;
    //public int[] DiaPlus;

    //public int[] DrowDiaMinus;
    //public int[] CoinDiaMinus;

    //public void FreeB(int i)
    //{
    //    freeButten[i].SetActive(false);
    //    oneButten[i].SetActive(true);
    //    if (i == 0)
    //    {
    //        tenButten.SetActive(true);
    //        IV.CardDrowB(0);
    //    }
    //    else if (i == 1)
    //    {
    //        RM.coin += CoinPlus[0];
    //    }
    //    else if (i == 2)
    //    {
    //        RM.diamond += DiaPlus[0];
    //    }
    //}
    //public void OneDrow(int i)
    //{
    //    if (RM.diamond >= DrowDiaMinus[i])
    //    {
    //        RM.diamond -= DrowDiaMinus[i];
    //        if (i == 0) IV.CardDrowB(0);
    //        else if (i == 2) IV.CardDrowB(1);
    //        else if (i == 4) IV.CardDrowB(2);

    //    }
    //}
    //public void TenDrow(int i)
    //{
    //    if (RM.diamond >= DrowDiaMinus[i])
    //    {
    //        RM.diamond -= DrowDiaMinus[i];
    //        for (int a = 0; a < 10; a++)
    //        {
    //            if (i == 1) IV.CardDrowB(0);
    //            else if (i == 3) IV.CardDrowB(1);
    //            else if (i == 5) IV.CardDrowB(2);
    //        }
    //    }
    //}
    //public void OneCoin(int i)
    //{
    //    if (RM.diamond >= CoinDiaMinus[i])
    //    {
    //        RM.diamond -= CoinDiaMinus[i];
    //        RM.coin += CoinPlus[i];
    //    }
    //}
    //public void OneDia(int i)
    //{
    //    RM.diamond += DiaPlus[i];
    //}

}
