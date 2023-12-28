using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScence : MonoBehaviour
{
    //jisuanshijian
    public float countTime = 0f;

    public Text showText;

    // Update is called once per frame
    void Update()
    {
        CountTime();
        ToBreak();
    }

    void CountTime()
    {
        countTime += Time.deltaTime;
        showText.text = countTime.ToString("f2");
        if (countTime > 11.0f)
        {
            SceneManager.LoadScene("PartTwo");
        }
    }

    void ToBreak()
    {
        if (Input.GetMouseButtonDown(0))
        {
            countTime = 11f;
        }
    }
}
