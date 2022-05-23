using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSlider : MonoBehaviour
{
    public Slider slider;

    const string music = "Music";

    public void Start()
    {
        slider.value = PlayerPrefs.GetFloat(music);
    }
    public void SaveMusicVolume()
    {
        PlayerPrefs.SetFloat(music, slider.value);
    }
}
