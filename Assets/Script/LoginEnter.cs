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
    string user;//��ע����˺�
    string pass;//��ע�������

    public GameObject My2;

    public void Start()
    {


    }
    public void OpenRigsterPanel()//��ע���panel
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
            Debug.Log("ע��ɹ�");
            if (pass == raffirmpassword.text)
            {//ע�������ȷ������һ�¹رս���
                rigsterpanel.SetActive(false);
            }
        }
        else
        {
            Debug.Log("ע��ʧ��");
            rusername.text = "";
            rpassword.text = "";
            raffirmpassword.text = "";

        }


        //if (pass == raffirmpassword.text)
        //{//ע�������ȷ������һ�¹رս���
        //    rigsterpanel.SetActive(false);
        //}
        //else
        //{
        //    rusername.text = "";
        //    rpassword.text = "";
        //    raffirmpassword.text = "";
        //}
        //��֤�ڶ���ע��Ϊ��
        rusername.text = "";
        rpassword.text = "";
        raffirmpassword.text = "";
    }
    public void ConfirmLogin()//��ʼ��Ϸ��ť
    {

        //if (username.text == user && password.text == pass)
        //{
        //    //��ת����
        //    SceneManager.LoadScene(1);
        //    Debug.Log("��¼�ɹ�");
        //}
        //else
        //{
        //    Debug.Log("�˺Ż��������,����������\n");
        //}
        bool res = SQLLink.Select(username.text, password.text);//��ѯ���ݿ�
        if (res)
        {
            Debug.Log("�˻�����һ��");
            rigsterpanel.SetActive(false);

        }
        else
        {
            Debug.Log("�˻����벻һ��");
        }
        //��֤��һ�ε�����
        username.text = "";
        password.text = "";
    }
   




}
