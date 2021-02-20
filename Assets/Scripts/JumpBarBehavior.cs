using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpBarBehavior : MonoBehaviour
{
    public Slider Slider;
    public Color Low;
    public Color High;
    //private Image image;


    private void Start()
    {
        //image = Slider.GetComponentInChildren<Image>();
    }
    public void SetBarLimits(float minJump, float maxJump)
    {
        Slider.maxValue = maxJump;
        Slider.minValue = minJump;
    }
    public void DisplayJump(float jump)
    {
        Slider.value = jump;

        //image.color = Color.Lerp(Low, High, Slider.normalizedValue);
        //Slider.fillRect.GetComponentInChildren<Image>().color = Color.Lerp(Low, High, Slider.normalizedValue);
    }
}
