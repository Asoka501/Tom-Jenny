using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Goal : MonoBehaviour
{
    //Inspectorでキャラクターとゴールオブジェクトの指定を出来る様にします。
    public GameObject chara;
    public GameObject gameclea;

    public AudioClip goalSound;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //もしゴールオブジェクトのコライダーに接触した時の処理。
        if (other.name == chara.name)
        {
            //ゲームクリアテキストを表示させてキャラクターを非表示にします。
            gameclea.GetComponent<Text>();
            gameclea.SetActive(true);
            audioSource.clip = goalSound;
            audioSource.Play();


        }
    }

}

