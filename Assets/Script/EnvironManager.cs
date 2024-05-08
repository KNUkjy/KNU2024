using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnvironManager : MonoBehaviour
{
    public Material DayMaterial;
    public Material NightMaterial;
    public GameObject MainCam;
    public GameObject DirectionLight;
    public GameObject SmartPhone;
    public AudioClip[] BgmList;
    public int currAudio = 0;
    private AudioSource BGMAudio;
    public TextMeshProUGUI NowPlaying;
    public List<GameObject> ParticleList = new List<GameObject>();
    public List<GameObject> DecoList = new List<GameObject>();
    private Quaternion dayQuater= Quaternion.Euler(50, -30, 0);
    private Quaternion nightQuater = Quaternion.Euler(0, 0, 0);
    void SmartPhoneCheck() //스마트폰을 할 때는 정지한 상태에서!
    {
        if (SmartPhone.activeSelf == true)
        {
            Time.timeScale = 0;
        }
        if (SmartPhone.activeSelf == false)
        {
            Time.timeScale = 1;
        }
    }
    public void Daychange()
    {
        RenderSettings.skybox = DayMaterial;
        MainCam.GetComponent<Skybox>().material = DayMaterial;
        RenderSettings.ambientIntensity = 1.0f;
        DirectionLight.transform.rotation = dayQuater;
    }
    public void nightchange()
    {
        RenderSettings.skybox = NightMaterial;
        MainCam.GetComponent<Skybox>().material = NightMaterial;
        RenderSettings.ambientIntensity = 0.5f;
        DirectionLight.transform.rotation = nightQuater;
    }
    public void particleOff()
    {
        for (int i = 0; i<ParticleList.Count; i++)
        {
            ParticleList[i].SetActive(false);
        }
    }
    public void DecoOff()
    {
        for (int i = 0; i < DecoList.Count; i++)
        {
            DecoList[i].SetActive(false);
        }
    }
    public void gomDuri()
    {
        particleOff();
        ParticleList[0].SetActive(true);
        ParticleList[0].GetComponent<ParticleSystem>().Play();
    }
    public void Spring()
    {
        particleOff();
        ParticleList[1].SetActive(true);
        ParticleList[1].GetComponent<ParticleSystem>().Play();
    }
    public void Summer()
    {
       particleOff();
       ParticleList[2].SetActive(true);
       ParticleList[2].GetComponent<ParticleSystem>().Play();
    }
    public void Fall()
    {
        particleOff();
        ParticleList[3].SetActive(true);
        ParticleList[3].GetComponent<ParticleSystem>().Play();
    }
    public void Winter()
    {
        particleOff();
        ParticleList[4].SetActive(true);
        ParticleList[4].GetComponent<ParticleSystem>().Play();
    }
    public void Bloosom()
    {
        if (DecoList[0].activeSelf == false) DecoList[0].SetActive(true);
        else DecoList[0].SetActive(false);
    }
    public void Lamp()
    {
        if (DecoList[1].activeSelf == false) DecoList[1].SetActive(true);
        else DecoList[1].SetActive(false);
    }
    public void BGMPlay()
    {
        currAudio = 0;
        BGMAudio.clip = BgmList[currAudio];
        BGMAudio.Play();
        MusicName();
    }
    public void PrevPlay()
    {
        currAudio--;
        if (currAudio == -1) currAudio = 0;
        BGMAudio.Stop();
        BGMAudio.clip = BgmList[currAudio];
        BGMAudio.Play();
        MusicName();
    }
    public void NextPlay()
    {
        currAudio++;
        if (currAudio == 3) currAudio = 0;
        BGMAudio.Stop();
        BGMAudio.clip = BgmList[currAudio];
        BGMAudio.Play();
        MusicName();
    }
    public void StopPlay()
    {
        BGMAudio.Stop();
    }
    public void MusicName()
    {

        if (currAudio == 0) NowPlaying.text = "Swing Rabbit ! Swing !";
        else if (currAudio == 1) NowPlaying.text = "How it Began";
        else if (currAudio == 2) NowPlaying.text = "찬란한 빛";
    }
    void Start()
    {
        SmartPhone.SetActive(false);
        gomDuri();
        DecoOff();
        BGMAudio = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        SmartPhoneCheck();
    }
}
