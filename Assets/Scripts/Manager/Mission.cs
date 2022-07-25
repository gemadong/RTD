using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mission : MonoBehaviour
{
    [SerializeField] private Setting setting;
    [SerializeField] private TutorialObjectDetector TOD;
    [SerializeField] private GameObject clearImpect;
    [SerializeField] private TimeManager TM;
    [SerializeField] private Draw draw;
    [SerializeField] private Hidden hidden;
    [SerializeField] private UpGrade upGrade;
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject Mission1panel;
    [SerializeField] private GameObject Mission2panel;
    [SerializeField] private GameObject Mission3panel;
    [SerializeField] private GameObject botton;
    [SerializeField] private Text bottonText;

    public bool ispanel = false;

    public bool isCool1 = false;
    public bool isCool2 = false;
    public bool isCool3 = false;

    public float coolTime1 = 300f;
    public float coolTime2 = 300f;
    public float coolTime3 = 300f;

    private void Update()
    {
        if (isCool1)
        {
            coolTime1 -= Time.deltaTime;
            Mission1panel.SetActive(true);
            Mission1panel.GetComponent<Image>().fillAmount = coolTime1 / 300f;
            if (coolTime1 <= 0)
            {
                StartCoroutine("ClearBotten");
                Mission1panel.GetComponent<Image>().fillAmount = 1;
                coolTime1 = 300f;
                Mission1panel.SetActive(false);
                isCool1 = false;
            }

        }
        if (isCool2)
        {
            coolTime2 -= Time.deltaTime;
            Mission2panel.SetActive(true);
            Mission2panel.GetComponent<Image>().fillAmount = coolTime2 / 300f;
            if (coolTime2 <= 0)
            {
                StartCoroutine("ClearBotten");
                Mission2panel.GetComponent<Image>().fillAmount = 1;
                coolTime2 = 300f;
                Mission2panel.SetActive(false);
                isCool2 = false;
            }
        }
        if (isCool3)
        {
            coolTime3 -= Time.deltaTime;
            Mission3panel.SetActive(true);
            Mission3panel.GetComponent<Image>().fillAmount = coolTime3 / 300f;
            if (coolTime3 <= 0)
            {
                StartCoroutine("ClearBotten");
                Mission3panel.GetComponent<Image>().fillAmount = 1;
                coolTime3 = 300f;
                Mission3panel.SetActive(false);
                isCool3 = false;
            }
        }
    }
    public void IsPanel()
    {
        if (!ispanel)
        {
            if(hidden.ispanel==true) hidden.IsPanel();
            if(upGrade.ispanel==true) upGrade.IsPanel();
            if(draw.ispanel==true) draw.IsPanel();
            if (setting.ispanel == true) setting.IsPanel();
            if (TOD != null)
            {
                if(TOD.tutorialCount == 14)
                {
                    TOD.TutorialPanel();
                }
            }
            panel.SetActive(true);
            ispanel = true;
        }
        else
        {
            panel.SetActive(false);
            ispanel = false;
        }
    }
    IEnumerator ClearBotten()
    {
        Color reColor = botton.GetComponent<Image>().color;
        botton.GetComponent<Image>().color = Color.yellow;
        bottonText.color = Color.yellow;
        clearImpect.SetActive(true);
        if (TM.isSpeed == 1) yield return new WaitForSeconds(0.3f);
        if (TM.isSpeed == 2) yield return new WaitForSeconds(0.6f);
        if (TM.isSpeed == 3) yield return new WaitForSeconds(0.9f);
        botton.GetComponent<Image>().color = reColor;
        bottonText.color = reColor;
        clearImpect.SetActive(false);
    }
}
