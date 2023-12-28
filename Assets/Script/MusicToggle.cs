using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicToggle : MonoBehaviour
{
    public Toggle toggleMusic;
    public AudioSource audio;

    public void ToggleMusicThing()
    {
        if (toggleMusic.isOn==true) 
        {
            audio.mute = false;
        }
        else if(toggleMusic.isOn==false)
        {
            audio.mute = true;
        }
    }

}
