using UnityEngine;
using System.Collections;

public class Muice : MonoBehaviour
{

    public AudioSource play;
    //点击按钮音效
    public void chick()
    {
        play.Play();
    }
}