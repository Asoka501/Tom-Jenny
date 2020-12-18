using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CController : MonoBehaviour
{
    public float speed = 5;
    public float jumpPower = 10;
    int jumpCount;

    Animator animator;
    Collider colliderTest;

    bool run;

    public AudioClip pickUpSound;
    public AudioClip jumpSound;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();  //書くのが楽かつGetComponentの処理が重複せず軽くなる
        animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Animation();
        Colider();
        GameObject.Find("Canvas").GetComponent<ScoreController>().AddScore1();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")  //Groundのタグにぶつかったときはジャンプカウントリセットする
        {
            jumpCount = 0;
        }

        if (col.gameObject.tag == "Coin")
        {
            audioSource.clip = pickUpSound;
            audioSource.Play();
            Destroy(col.gameObject);
            GameObject.Find("Canvas").GetComponent<ScoreController>().AddScore();
            GameObject.Find("Canvas").GetComponent<ItemTake>().AddItem();
        }

        if (col.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene("EndScene1");
        }
    }

    void Move()
    {
        this.transform.position += new Vector3(0, 0, speed * Time.deltaTime);

        if (Input.GetKey("left") == true)
        {
            this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("right") == true)
        {
            this.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }



        if (Input.GetKeyDown("space") == true)
        {
            Jump();
        }
    }

    public void Jump()
    {
        if (jumpCount < 1)
        {
            this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
            audioSource.clip = jumpSound;
            audioSource.Play();
            jumpCount += 1;
        }
    }

    void Colider()
    {
        if (Input.GetKey("down") == true)
        {
            var colliderTest = GetComponent<Collider>();
            colliderTest.enabled = false;
        }
        else
        {
            var colliderTest = GetComponent<Collider>();
            colliderTest.enabled = true;
        }
        
    }

    void Animation()
    {
        if (Input.GetKeyDown("space") == true)
        {
            animator.SetTrigger("jump");
        }

        if (Input.GetKeyUp("space") == true)
        {
            animator.SetBool("run", true);
        }

        if (Input.GetKeyDown("down") == true)
        {
            animator.SetTrigger("sliding");
        }

        if (Input.GetKeyUp("down") == true)
        {
            animator.SetBool("run", true);
        }
    }

}
