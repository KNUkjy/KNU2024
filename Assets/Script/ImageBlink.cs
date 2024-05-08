using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageBlink : MonoBehaviour
{
    [SerializeField] Image CurrentPosition;
    private Color newColor;
    // Use this for initialization
    void Start()
    {
        
        newColor = CurrentPosition.color;

    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentPosition != null)
        {
            newColor.a = Mathf.PingPong(Time.time, 0.8f);
            CurrentPosition.color = newColor;
        }
    }
}