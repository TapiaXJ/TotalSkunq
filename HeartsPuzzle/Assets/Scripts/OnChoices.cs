using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OnChoices : MonoBehaviour {

    public Button startButton;
    public Button endButton;

	private void Start()
	{
        startButton.onClick.AddListener(RestartGame);
        endButton.onClick.AddListener(ExitGame);
	}

    private void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    private void ExitGame()
    {
        Application.Quit();
    }
}
