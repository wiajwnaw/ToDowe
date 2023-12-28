using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class login : MonoBehaviour
{
    public InputField UsernameInput;//用户名
    public InputField PasswordInput;//密码
    public Text Mistake;//错误提示
    public Text Register;//完成提示
    public Text Z;//单单账号正确
    public Text G;//账号错误
    public Text C;//单单密码正确
    public Text E;//密码错误
    public GameObject my;
    public GameObject oo;
    bool a = false;

    public void OnButton()//提交按钮点击事件
    {
        string un = UsernameInput.text;//获取输入账号
        string pw = PasswordInput.text;//获取输入密码
        if (un == "123" && pw == "abc")//判断是否输入正确
        {
            Register.gameObject.SetActive(true);//完成提示
            Z.gameObject.SetActive(true);//完成提示
            C.gameObject.SetActive(true);//完成提示
            a = true;
            StartCoroutine(Disappear());//调用协程  
            
            
        }
        else
        {
            Mistake.gameObject.SetActive(true);//完成提示
            StartCoroutine(Disappear());//调用协程
        }
        if (un == "123" && pw != "abc") //判断是否输入正确
        {
            Z.gameObject.SetActive(true);//完成提示
            E.gameObject.SetActive(true);//密码输入错误提示

            StartCoroutine(Disappear());//调用协程

        }
       
        if (pw == "abc" && un != "123")
        {
            C.gameObject.SetActive(true);//完成提示
            G.gameObject.SetActive(true);//账号输入错误提示
            StartCoroutine(Disappear());//调用协程
        }
      

    }
    IEnumerator Disappear()//协程
    {
        yield return new WaitForSeconds(3);//出现3秒
        Mistake.gameObject.SetActive(false);//提示错误消失
        Register.gameObject.SetActive(false);//提示成功消失
        Z.gameObject.SetActive(false);//提示成功消失
        G.gameObject.SetActive(false);//提示成功消失
        C.gameObject.SetActive(false);//提示成功消失
        E.gameObject.SetActive(false);//提示成功消失
        if (a == true)
        {
            my.SetActive(false);
            oo.SetActive(true);

        }
        
    }
}
