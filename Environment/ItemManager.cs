using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public Text itemText;
    int item;

    void Start()
    {
        item = PlayerPrefs.GetInt("item");    
        itemText.text = item.ToString();

        //if(PlayerPrefs.HasKey("highScore") == true)  //指定した名前で保存したデータがある場合はtrue,逆はfalse   
        //{
        //    highScore = PlayerPrefs.GetInt("highScore");    //データの代入
        //    if (highScore < item)   
        //    {
        //        highScore = item;
        //        PlayerPrefs.SetInt("highScore", highScore); //ハイスコアの更新

        //    }
        //}
        //else                           //保存データがなかった場合(全くの初期データだった場合容赦なくデータ入れる的な？)
        //{
        //    highScore = item;
        //    PlayerPrefs.SetInt("highScore", highScore);
        //}
        //highScoreText.text = highScore.ToString();
    }

    // Start is called before the first frame update

}
