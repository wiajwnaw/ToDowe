using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class LoginEnter : MonoBehaviour
{
    public InputField username;
    public InputField password;
    public InputField rusername;
    public InputField rpassword;
    public InputField raffirmpassword;
    public GameObject rigsterpanel;
    string user;//存注册的账号
    string pass;//存注册的密码

    public GameObject My2;

    public void Start()
    {


    }
    public void OpenRigsterPanel()//打开注册的panel
    {
        rigsterpanel.SetActive(true);
        My2.SetActive(false);
    }
    public void OpenRigisterButton()
    {
        Debug.Log("1111");
        user = rusername.text;
        pass = rpassword.text;
        bool res = SQLLink.Insert(user, pass);
        if (res)
        {
            Debug.Log("注册成功");
            if (pass == raffirmpassword.text)
            {//注册密码和确认密码一致关闭界面
                rigsterpanel.SetActive(false);
            }
        }
        else
        {
            Debug.Log("注册失败");
            rusername.text = "";
            rpassword.text = "";
            raffirmpassword.text = "";

        }


        //if (pass == raffirmpassword.text)
        //{//注册密码和确认密码一致关闭界面
        //    rigsterpanel.SetActive(false);
        //}
        //else
        //{
        //    rusername.text = "";
        //    rpassword.text = "";
        //    raffirmpassword.text = "";
        //}
        //保证第二次注册为空
        rusername.text = "";
        rpassword.text = "";
        raffirmpassword.text = "";
    }
    public void ConfirmLogin()//开始游戏按钮
    {

        //if (username.text == user && password.text == pass)
        //{
        //    //跳转场景
        //    SceneManager.LoadScene(1);
        //    Debug.Log("登录成功");
        //}
        //else
        //{
        //    Debug.Log("账号或密码错误,请重新输入\n");
        //}
        bool res = SQLLink.Select(username.text, password.text);//查询数据库
        if (res)
        {
            Debug.Log("账户密码一样");
            rigsterpanel.SetActive(false);

        }
        else
        {
            Debug.Log("账户密码不一样");
        }
        //保证下一次的输入
        username.text = "";
        password.text = "";
    }
   




}
