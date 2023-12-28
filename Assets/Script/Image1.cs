using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image1 : MonoBehaviour
{
    SpriteRenderer sr;
    
    //存放音频的数组
    public AudioClip[] audios;
    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        //默认播放第二个音频
        this.GetComponent<AudioSource>().clip = audios[0];
        this.GetComponent<AudioSource>().Play();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            this.GetComponent<AudioSource>().clip = audios[0];
            this.GetComponent<AudioSource>().Play();
        }

    } 
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            this.GetComponent<AudioSource>().clip = audios[0];
            this.GetComponent<AudioSource>().Stop();
        }

    }
    
   
}
