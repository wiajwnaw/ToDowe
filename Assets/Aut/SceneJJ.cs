using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneJJ : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}
	public void My()//第一个场景 
	{
		SceneManager.LoadScene(0);
	}
	public void MainMenu() //第二个场景
	{
		SceneManager.LoadScene(1);
	}
	public void Loading() //第二个场景
	{
		SceneManager.LoadScene(2);
	}
	public void GameScens() //第二个场景
	{
		SceneManager.LoadScene(2);
	}
}

