using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneMenu : MonoBehaviour
{
    public void sampleScene()
    {
    	SceneManager.LoadScene("SampleScene");
    }

    public void rotateCube()
    {
    	SceneManager.LoadScene("RotateCube");
    }

    public void exitGame()
    {
    	Application.Quit();
    	Debug.Log("Exit button pressed");
    }
}
