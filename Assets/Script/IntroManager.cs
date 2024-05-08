using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class IntroManager : MonoBehaviour
{
    public GameObject Pannel;
    public GameObject CamMap;
    public GameObject _Canvas;
    public GameObject _Logo;
    public TextMeshProUGUI _dialLogText;
    public TextMeshProUGUI _buttonDialText;
    public Button btn;
    public int _dialLogNum;
    public int _ButtonLogNum;
    public List<string> DialLogList = new List<string>();
    public List<string> ButtonDialLogList = new List<string>();
    public IEnumerator WaitTime()
    {
        yield return new WaitForSecondsRealtime(5.0f);
    }
    public void Map()
    {
        CamMap.SetActive(true);
    }
    public void MoveScence()
    {
        StartCoroutine(ScenceMove());
    }

    public IEnumerator ScenceMove()
    {

        _dialLogText.text = "ķ�۽��� �̵� ���� �ٰ�!";
        AsyncOperation op = SceneManager.LoadSceneAsync("Campus");
        float timer = 0.0f;
        while (!op.isDone)
        {
            timer += Time.deltaTime;
            yield return null;
            _Logo.SetActive(true);
            _Canvas.SetActive(false);
            if (timer < 1.0f)
            {
                _Logo.GetComponent<Image>().color = new Color(1f, 1f, 1f, (timer / 0.7f));
            }
            else
            {
                _Logo.GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                op.allowSceneActivation = true;
                yield break;
            }
        }
    }
    public void DialLog()
    {
        DialLogList.Add("�׷� ���� �ȳ����ٰ�!");
        ButtonDialLogList.Add("��!");//1
        DialLogList.Add("��Ÿ���� �������б��� ��õ ������ �������б��� ��Ÿ���� ȯ������ ���� ���̾�!");
        ButtonDialLogList.Add("��");//2
        DialLogList.Add("���� ���� �ǹ����� �̸� �� �� �ְ�, �� �ǹ��� ������ ���� ���� �� �־�!");
        ButtonDialLogList.Add("��");//3
        DialLogList.Add("���� �װ� ���Ի��̶�� �̸� ķ�۽��� ü���غ� ��ȸ�� �� ���ְ�, ���л��̳� �������̶�� �߾��� ��¤�� �� ��ȸ�� �� �ž�!");
        ButtonDialLogList.Add("��");//4
        DialLogList.Add("�غ� �� �ƴٸ� ķ�۽��� �̵��غ���?");
        ButtonDialLogList.Add("�� ����!");//5
    }
    public void DialLogText()
    {
        if (_dialLogNum < DialLogList.Count)
        {
            _dialLogText.text = DialLogList[_dialLogNum];
            _buttonDialText.text = ButtonDialLogList[_ButtonLogNum];
            _dialLogNum++;
            _ButtonLogNum++;
        }
        if (_dialLogNum == 3)
        {
            btn.onClick.AddListener(Map);
        }
        if (_dialLogNum == DialLogList.Count)
        {
            btn.onClick.AddListener(MoveScence);
        }
    }
    void Start()
    {
        DialLog();
        Pannel.SetActive(false);
        CamMap.SetActive(false);
    }


    void Update()
    {

    }
}
