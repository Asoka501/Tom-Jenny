using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StorySceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartButton()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void StartButton1()
    {
        SceneManager.LoadScene("Test");
    }

}
