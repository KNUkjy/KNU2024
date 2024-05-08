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

        _dialLogText.text = "캠퍼스로 이동 시켜 줄게!";
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
        DialLogList.Add("그럼 내가 안내해줄게!");
        ButtonDialLogList.Add("응!");//1
        DialLogList.Add("메타버스 강원대학교는 춘천 소재의 강원대학교를 메타버스 환경으로 만든 곳이야!");
        ButtonDialLogList.Add("응");//2
        DialLogList.Add("여러 대학 건물들을 미리 볼 수 있고, 각 건물의 간단한 설명도 들을 수 있어!");
        ButtonDialLogList.Add("응");//3
        DialLogList.Add("만약 네가 신입생이라면 미리 캠퍼스를 체험해볼 기회가 될 수있고, 재학생이나 졸업생이라면 추억을 되짚어 볼 기회가 될 거야!");
        ButtonDialLogList.Add("응");//4
        DialLogList.Add("준비가 다 됐다면 캠퍼스로 이동해볼까?");
        ButtonDialLogList.Add("응 가자!");//5
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
