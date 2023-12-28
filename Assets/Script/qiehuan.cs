using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qiehuan : MonoBehaviour
{
    public GameObject ii;
    public GameObject oo;

    public void OnButton()
    {
        ii.SetActive(false);
        oo.SetActive(true);
    }
}
