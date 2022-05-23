using UnityEngine;
using UnityEngine.UI;

public class SoundSlider : MonoBehaviour
{
    public Slider slider;

    const string sound = "Sound";

    public void Start()
    {
        slider.value = PlayerPrefs.GetFloat(sound);
    }
    public void SaveSoundVolume()
    {
        PlayerPrefs.SetFloat(sound, slider.value);
    }
}
