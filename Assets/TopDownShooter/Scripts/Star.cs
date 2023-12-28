using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public GameObject myObject;//需要控制的物体
    public GameObject muic1;
    public GameObject muic2;
    void Update()
    {
        //if (gameObject.activeSelf==false)
        //{
            
        //}
    }
    private void OnDisable()
    {
        myObject.SetActive(true);//切换物体的显示和隐藏状态
        muic1.SetActive(false);
        muic2.SetActive(true);

    }


}
