using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndSceneManager : MonoBehaviour
{
    public Text lastScoreText;
    public Text highScoreText;
    int highScore;
    int lastScore;

    void Start()
    {
        lastScore = PlayerPrefs.GetInt("score");    
        lastScoreText.text = lastScore.ToString();

        if(PlayerPrefs.HasKey("highScore") == true)  //指定した名前で保存したデータがある場合はtrue,逆はfalse   
        {
            highScore = PlayerPrefs.GetInt("highScore");    //データの代入
            if (highScore < lastScore)   
            {
                highScore = lastScore;
                PlayerPrefs.SetInt("highScore", highScore); //ハイスコアの更新

            }
        }
        else                           //保存データがなかった場合(全くの初期データだった場合容赦なくデータ入れる的な？)
        {
            highScore = lastScore;
            PlayerPrefs.SetInt("highScore", highScore);
        }
        highScoreText.text = highScore.ToString();
    }

    // Start is called before the first frame update
    public void RetryButton()
    {
        SceneManager.LoadScene("StartScene");
    }

}
