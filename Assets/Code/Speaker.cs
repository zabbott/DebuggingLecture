using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Speaker : MonoBehaviour
{
    public string Line;
    public Listener Listener;

    public void Start()
    {
        //get listener
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Listener.AddToSpeakerLines(Line);
        }
    }
}
