using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedBarBehavior : MonoBehaviour
{
    public Slider Slider;
    public Color Low;
    public Color High;

    public void DisplaySpeed(float speed)
    {
        Slider.value = speed;

        Slider.fillRect.GetComponentInChildren<Image>().color = Color.Lerp(Low, High, Slider.normalizedValue);
    }

}
