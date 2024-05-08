using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InfoDialLog : MonoBehaviour
{
    
    public TextMeshProUGUI DialText;
    public string[] DialList;
    public int CurrInfo;
    private GameObject DialManager;
    [SerializeField] private GameObject DialLogPannel;
    public void OnMouseDown()
    { 
        if (gameObject.name.Contains("NursingInfo"))
        {
            DialLogPannel.SetActive(true);
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog;
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog = 0;//다음 숫자는 단과대학 정보
            DisPlayDialLog();
            DialManager.GetComponent<DiallogManager>().MinimapPos();
        }
        else if (gameObject.name.Contains("BusinessInfo"))
        {
            DialLogPannel.SetActive(true);
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog;
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog = 2;
            DisPlayDialLog();
            DialManager.GetComponent<DiallogManager>().MinimapPos();
        }
        else if (gameObject.name.Contains("AgricultureInfo"))
        {
            DialLogPannel.SetActive(true);
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog;
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog = 4;
            DisPlayDialLog();
            DialManager.GetComponent<DiallogManager>().MinimapPos();
        }
        else if (gameObject.name.Contains("AnimalInfo"))
        {
            DialLogPannel.SetActive(true);
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog;
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog = 6;
            DisPlayDialLog();
            DialManager.GetComponent<DiallogManager>().MinimapPos();
        }
        else if (gameObject.name.Contains("ArtInfo"))
        {
            DialLogPannel.SetActive(true);
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog;
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog = 8;
            DisPlayDialLog();
            DialManager.GetComponent<DiallogManager>().MinimapPos();
        }
        else if (gameObject.name.Contains("EngineeringInfo"))
        {
            DialLogPannel.SetActive(true);
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog;
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog = 10;
            DisPlayDialLog();
            DialManager.GetComponent<DiallogManager>().MinimapPos();
        }
        else if (gameObject.name.Contains("EduInfo"))
        {
            DialLogPannel.SetActive(true);
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog;
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog = 12;
            DisPlayDialLog();
            DialManager.GetComponent<DiallogManager>().MinimapPos();
        }
        else if (gameObject.name.Contains("SocietyInfo"))
        {
            DialLogPannel.SetActive(true);
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog;
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog = 14;
            DisPlayDialLog();
            DialManager.GetComponent<DiallogManager>().MinimapPos();
        }
        else if (gameObject.name.Contains("ForestInfo"))
        {
            DialLogPannel.SetActive(true);
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog;
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog = 16;
            DisPlayDialLog();
            DialManager.GetComponent<DiallogManager>().MinimapPos();
        }
        else if (gameObject.name.Contains("PharmacyInfo"))
        {
            DialLogPannel.SetActive(true);
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog;
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog = 18;
            DisPlayDialLog();
            DialManager.GetComponent<DiallogManager>().MinimapPos();
        }
        else if (gameObject.name.Contains("MedicalInfo"))
        {
            DialLogPannel.SetActive(true);
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog;
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog = 20;
            DisPlayDialLog();
            DialManager.GetComponent<DiallogManager>().MinimapPos();
        }
        else if (gameObject.name.Contains("BioscienceInfo"))
        {
            DialLogPannel.SetActive(true);
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog;
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog = 22;
            DisPlayDialLog();
            DialManager.GetComponent<DiallogManager>().MinimapPos();
        }
        else if (gameObject.name.Contains("HumanitieInfo"))
        {
            DialLogPannel.SetActive(true);
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog;
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog = 24;
            DisPlayDialLog();
            DialManager.GetComponent<DiallogManager>().MinimapPos();
        }
        else if (gameObject.name.Contains("NaturalInfo"))
        {
            DialLogPannel.SetActive(true);
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog;
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog = 26;
            DisPlayDialLog();
            DialManager.GetComponent<DiallogManager>().MinimapPos();
        }
        else if (gameObject.name.Contains("ITInfo"))
        {
            DialLogPannel.SetActive(true);
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog;
            CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog = 28;
            DisPlayDialLog();
            DialManager.GetComponent<DiallogManager>().MinimapPos();
        }
    }
  
    public void DialLogNext()
    {
        CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog;
        CurrInfo++;
        DisPlayDialLog();
    }
    public void DisPlayDialLog()
    {
        DialText.text = DialList[CurrInfo];
    }
    void PannelChk()
    {
        if (DialLogPannel.activeSelf == true) GameObject.Find("Player").GetComponent<CharacterMove>().enabled = false;
        if (DialLogPannel.activeSelf == false) GameObject.Find("Player").GetComponent<CharacterMove>().enabled = true;
    }
    void Start()
    {
        DialManager = GameObject.Find("DiallogManager");
        //CurrInfo = DialManager.GetComponent<DiallogManager>().currDialLog;
        DialText = DialManager.GetComponent<DiallogManager>().DialLogText;
        TextAsset textFile = Resources.Load("Diallog") as TextAsset;
        DialList = textFile.text.Split("\n");
        DialLogPannel = DialManager.GetComponent<DiallogManager>().DialPannel;
        DialLogPannel.SetActive(false);
    }

 
    void Update()
    {
        PannelChk();
    }
}
