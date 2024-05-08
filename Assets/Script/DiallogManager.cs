using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DiallogManager : MonoBehaviour
{
    public string DialLog;
    public string[] DialLogList;
    public int currDialLog;
    public GameObject Cavas;
    public GameObject DialPannel;
    public TextMeshProUGUI DialLogText;
    public GameObject CampusImage;
    public RectTransform currTrans;
    public static DiallogManager _DiallogManager = null;

    public void MinimapPos()
    {
        if (currDialLog == 0 || currDialLog == 1) currTrans.anchoredPosition = new Vector3(200, 235, 0); 
        if (currDialLog == 2 || currDialLog == 3) currTrans.anchoredPosition = new Vector3(-5, 95, 0); 
        if (currDialLog == 4 || currDialLog == 5) currTrans.anchoredPosition = new Vector3(-70, 165, 0);
        if (currDialLog == 6 || currDialLog == 7) currTrans.anchoredPosition = new Vector3(155, 165, 0);
        if (currDialLog == 8 || currDialLog == 9) currTrans.anchoredPosition = new Vector3(25, 165, 0);
        if (currDialLog == 10 || currDialLog == 11) currTrans.anchoredPosition = new Vector3(-215, -115, 0);
        if (currDialLog == 12 || currDialLog == 13) currTrans.anchoredPosition = new Vector3(-215, 20, 0);
        if (currDialLog == 14 || currDialLog == 15) currTrans.anchoredPosition = new Vector3(-80, -160, 0);
        if (currDialLog == 16 || currDialLog == 17) currTrans.anchoredPosition = new Vector3(135, 80, 0);
        if (currDialLog == 18 || currDialLog == 19) currTrans.anchoredPosition = new Vector3(145, 120, 0);
        if (currDialLog == 20 || currDialLog == 21) currTrans.anchoredPosition = new Vector3(200, 235, 0);
        if (currDialLog == 22 || currDialLog == 23) currTrans.anchoredPosition = new Vector3(195, 120, 0);
        if (currDialLog == 24 || currDialLog == 25) currTrans.anchoredPosition = new Vector3(-120, -105, 0);
        if (currDialLog == 26 || currDialLog == 27) currTrans.anchoredPosition = new Vector3(-220, 95, 0);
        if (currDialLog == 28 || currDialLog == 29) currTrans.anchoredPosition = new Vector3(-265, -135, 0);
    }
    void Start()
    {
        _DiallogManager = this;
        TextAsset textFile = Resources.Load("Diallog") as TextAsset;
        //StringReader strReader = new StringReader(textFile.text);
        DialLogList = textFile.text.Split("\n");
        currTrans.anchoredPosition = new Vector3(0, 0, 0);
        CampusImage.SetActive(false);
    }
    void Update()
    {
       
    }
}
