using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingProgressBar : MonoBehaviour {

    
    public Slider slider;
    public Text text;
    public GameObject myObject;
    public GameObject my;

    public void LoadNextLevel()
    {
        /*StartCoroutine(LoadNextLevel());*/
    }
    IEnumerator Start()
    {
       
        
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        operation.allowSceneActivation = false;

        while (!operation.isDone)
        {
            slider.value = operation.progress;
            myObject.SetActive(false);
            my.SetActive(true);

            text.text = operation.progress * 100 + "%";
            if (operation.progress >= 0.9f)
            {
                slider.value = 1;
                text.text = "—按任意键进入游戏—";
                if (Input.anyKeyDown)
                {
                    operation.allowSceneActivation = true;
                }
            }


            yield return null;
        }
    }
}
