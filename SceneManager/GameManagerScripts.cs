using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   //UI系のパーツ作るのに必要
using UnityEngine.SceneManagement;

public class GameManagerScripts : MonoBehaviour
{
    public Text countText;　//インスペクタビューで見たいからpublicをつける
    public Text timerText;
    float timer = 60.0f;

    bool isPlaying = false;     //bool型(真偽値)true or falseどちらかの値を保持

    // Start is called before the first frame update
    void Start()
    {
        isPlaying = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlaying == true)   //  trueの時にだけ以下の処理を行う
        {
            timer -= Time.deltaTime;
            timerText.text = timer.ToString("f1");
        }

        if(timer < 0)
        {
            isPlaying = false;
            timer = 0;
            timerText.text = timer.ToString("f1");
        }
    }
}
