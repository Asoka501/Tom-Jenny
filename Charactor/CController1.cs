using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CController1 : MonoBehaviour
{
    public float speed = 3;
    public float jumpPower = 6;
    int jumpCount;

    Animator animator;
    Collider colliderTest;

    public AudioClip jumpSound;

    AudioSource audioSource;

    bool run;

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
    }

    void Move()
    {
        


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

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")  //Groundのタグにぶつかったときはジャンプカウントリセットする
        {
            jumpCount = 0;
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
