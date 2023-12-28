using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchaudio : MonoBehaviour
{
    //存放音频的数组
    public AudioClip[] audios;
    void Start()
    {
        //默认播放第二个音频
        this.GetComponent<AudioSource>().clip = audios[1];
        this.GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            this.GetComponent<AudioSource>().clip = audios[0];
            this.GetComponent<AudioSource>().Play();
        }
     
      
    }
}
