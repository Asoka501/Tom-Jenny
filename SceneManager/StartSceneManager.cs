using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneManager : MonoBehaviour
{

    // Start is called before the first frame update
    public void StartButton0()
    {
        SceneManager.LoadScene("StartScene");
    }
    public void StartButton()
    {
        SceneManager.LoadScene("Story");
    }

    public void StartButton1()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void StartButton2()
    {
        SceneManager.LoadScene("Cregit");
    }
}
