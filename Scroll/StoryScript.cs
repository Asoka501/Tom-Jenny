using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StoryScript : MonoBehaviour
{

    //　テキストのスクロールスピード
    [SerializeField]
    private float textScrollSpeed = 30;
    //　テキストの制限位置
    [SerializeField]
    private float limitPosition = 700f;
    //　エンドロールが終了したかどうか
    private bool isStopEndRoll;
    //　シーン移動用コルーチン
    private Coroutine endRollCoroutine;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        //　エンドロールが終了した時
        if (isStopEndRoll)
        {
            endRollCoroutine = StartCoroutine(GoToNextScene());
        }
        else
        {
            //　エンドロール用テキストがリミットを越えるまで動かす
            if (transform.position.y <= limitPosition)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + textScrollSpeed * Time.deltaTime, 0);
            }
            else
            {
                isStopEndRoll = true;
            }
        }
    }
    IEnumerator GoToNextScene()
    {
        //　4秒間待つ
        yield return new WaitForSeconds(4);

            StopCoroutine(endRollCoroutine);
            SceneManager.LoadScene("Test");

        yield return null;
    }
}
