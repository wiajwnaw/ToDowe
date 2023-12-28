using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign : MonoBehaviour
{
    public GameObject myObject;//需要控制的物体
    void Update()
    {
        if (gameObject.activeSelf)
        {

        }
        else
        {
            myObject.SetActive(!myObject.activeSelf);//切换物体的显示和隐藏状态
        }
    }
}
