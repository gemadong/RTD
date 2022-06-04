using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextViewer : MonoBehaviour
{
    [SerializeField] Text playerHPText;
    [SerializeField] Text playerGoldText;
    [SerializeField] PlayerHP playerHP;
    [SerializeField] PlayerGold playerGold;

    private void Update()
    {
        playerHPText.text = "HP : " + playerHP.CurrentHP + "/" + playerHP.MaxHP;
        playerGoldText.text = "Gold : " + playerGold.CurrentGold.ToString();
    }
}
