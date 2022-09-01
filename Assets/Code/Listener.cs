using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listener : MonoBehaviour
{
    public List<Speaker> Speakers;
    public List<string> SpeakerLines;
    public TextBoxManager TBM;
    public void GetSpeakers()
    {
        for (int i = 0; i < Speakers.Count; i++)
        {
            SpeakerLines.Add(Speakers[i].Line);
        }
        CheckSpeakerCount();
    }
    public void CheckSpeakerCount()
    {
        if (SpeakerLines.Count == 3)
        {
            TBM.TextBox.color = Color.green;
            TBM.SetText(SpeakerLines);
        }
    }
    public void AddToSpeakerLines(string lines)
    {
        SpeakerLines.Add(lines);
        if(SpeakerLines.Count == 3)
        {
            TBM.TextBox.color = Color.red;

            TBM.SetText(SpeakerLines);
        }
     
    }

   

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            GetSpeakers();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            SpeakerLines.Clear();
            TBM.TextBox.text = "";

        }
    }
}
