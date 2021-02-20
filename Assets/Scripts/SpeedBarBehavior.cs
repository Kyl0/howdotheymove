using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedBarBehavior : MonoBehaviour
{
    public Slider Slider;
    public Color Low;
    public Color High;
    //private Image image;


    private void Start()
    {
        //image = Slider.GetComponentInChildren<Image>();
    }
    public void SetBarLimits(float minSpeed, float maxSpeed)
    {
        Slider.maxValue = maxSpeed;
        Slider.minValue = minSpeed;
    }
    public void DisplaySpeed(float speed)
    {
        Slider.value = speed;

        //image.color = Color.Lerp(Low, High, Slider.normalizedValue);
        //Slider.fillRect.GetComponentInChildren<Image>().color = Color.Lerp(Low, High, Slider.normalizedValue);
    }

}
