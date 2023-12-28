using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TweenImageColor : MonoBehaviour
{

    public float blinkSpeed;//闪烁速度
    private bool isAddAlpha;//是否增加透明度
    private float timer;//计时器
    public float timeval = 1;//时间间隔

    private Image img;//指向自身图片

    private void Start()
    {
        img = GetComponent<Image>();
        timer += Time.deltaTime;
        if (isAddAlpha)
        {
            img.color -= new Color(0, 0, 0, Time.deltaTime * blinkSpeed);
            if (timer >= timeval)
            {
                img.color = new Color(img.color.r, img.color.g, img.color.b, 0);

            }
        }
    }

    


}
