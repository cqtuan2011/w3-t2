using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GraphicDropdown : MonoBehaviour
{
    private TMP_Dropdown dropdown;

    List<string> graphicOptionList = new List<string> {"Low", "Medium", "High"};

    const string graphicOption = "GraphicOption";

    private void Start()
    {
        dropdown = GetComponent<TMP_Dropdown>();

        dropdown.AddOptions(graphicOptionList);

        dropdown.value = PlayerPrefs.GetInt(graphicOption);
    }

    public void SaveData()
    {
        PlayerPrefs.SetInt(graphicOption, dropdown.value);
    }
}
