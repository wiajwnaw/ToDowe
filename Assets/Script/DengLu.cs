using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xiaoshi : MonoBehaviour
{
    public GameObject myObject;
    
    private void OnDisable()
    {
        myObject.SetActive(true);//切换物体的显示和隐藏状态
    }

}
