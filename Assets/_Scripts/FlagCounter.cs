using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FlagCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;


    private int flagCount = 0;


    private void UpdateText()
    {
        text.text = flagCount.ToString();
    }
}
