using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextBoxManager : MonoBehaviour
{
    public TMP_Text TextBox; 

    public void SetText(List<string> lines)
    {
        string wordsFromTheValas = "";
        if (lines.Count == 3)
        {
            for (int i = 0; i < lines.Count; i++)
            {
                wordsFromTheValas += lines[i] + '\n';
            }
            TextBox.text = wordsFromTheValas;
        }
    }
}
