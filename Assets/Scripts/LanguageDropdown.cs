using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LanguageDropdown : MonoBehaviour
{
    private TMP_Dropdown dropdown;

    List<string> languageOptionList = new List<string> { "English", "Vietnamese", "Chinese" };

    const string languageOption = "LanguageOption";

    private void Start()
    {
        dropdown = GetComponent<TMP_Dropdown>();

        dropdown.AddOptions(languageOptionList);

        dropdown.value = PlayerPrefs.GetInt(languageOption);
    }

    public void SaveData()
    {
        PlayerPrefs.SetInt(languageOption, dropdown.value);
    }
}
