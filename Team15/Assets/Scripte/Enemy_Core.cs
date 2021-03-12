﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Enemy_Core : MonoBehaviour
{
    public static bool baramakikougeki = false;
    public GameObject Player;
    public GameObject EnemyBullet_Type_1;
    public  GameObject EnemyBullet_Type_2;
    private float AutoTime = 0f;
    bool Triger = true;
    bool HpSwith900 = true;//ばらまきだん発生条件
    int count = 0;
    public Slider HpSlider;



    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        HpSlider.value = 1080;
        Player_Move.hennkann = false;
        //  GetComponent<CircleCollider2D>().enabled = true;//当たり判定
    

    }

    // Update is called once per frame
    void Update()
    {
        //ハダ_Pause用、Time.timeScaleが0のとき返す
        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }
        AutoTime += Time.deltaTime;
        /*if (1f < AutoTime)
         {
             AutoTime = 0f;
             float ShotSpeed = 5.5f;//弾速初速
             var pos = this.gameObject.transform.position;
             var t = Instantiate(EnemyBullet_Type_1,this.transform.position,Quaternion.identity) as GameObject;
             Vector2 vec = Player.transform.position - pos;
             vec.Normalize();
             vec *= ShotSpeed;
             t.GetComponent<Rigidbody2D>().velocity = vec;　
         }*/
        if (1.0f < AutoTime && Player_Move.hennkann == false)
        {
            for (int i = 0; i < 24; i++)
            {//表面等角攻撃
                AutoTime = 0f;
                float ShotSpeed = 5.5f;
                Vector2 vec = Player.transform.position - transform.position;
                vec.Normalize();
                vec = Quaternion.Euler(0, 0, (360 / 24) * i) * vec;
                vec *= ShotSpeed;
                var t = Instantiate(EnemyBullet_Type_1, transform.position, EnemyBullet_Type_1.transform.rotation);
                t.GetComponent<Rigidbody2D>().velocity = vec;
            }
            count++;
        }
        if (0.5f < AutoTime && Player_Move.hennkann == true)
        {
            for (int i = 0; i < 24; i++)
            {//裏面等角攻撃
                AutoTime = 0f;
                float ShotSpeed = 5.5f;
                Vector2 vec = Player.transform.position - transform.position;
                vec.Normalize();
                vec = Quaternion.Euler(0, 0, (360 / 24) * i) * vec;
                vec *= ShotSpeed;
                var t = Instantiate(EnemyBullet_Type_2, transform.position, EnemyBullet_Type_2.transform.rotation);
                t.GetComponent<Rigidbody2D>().velocity = vec;
            }
            count++;
        }
      /*  if (HpSlider.value < 1000 && HpSwith900 == true)
        {
            Debug.Log("1000HP");
            baramakikougeki = true;
            HpSwith900 = false;
        }
        if (1051 < HpSlider.value)
        {
         
            baramakikougeki = false;
     
        }*/



        {
            //  if (Input.GetKeyDown(KeyCode.G))
            {
                if (Player_Move.hennkann == true && Triger == true)
                {
                   // Debug.Log("裏になった");
                    Triger = false;
                    //   GetComponent<CircleCollider2D>().enabled = false;当たり判定
                    // gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 0, 0, 100);
                    gameObject.GetComponent<SpriteRenderer>().color = new Color32(0, 0, 255, 255);
                }
            }
        }
        //  if (Input.GetKeyDown(KeyCode.H))
        {

            if (Player_Move.hennkann == false && Triger == false)
            {
              //  Debug.Log("表になった");
                Triger = true;
                //  GetComponent<CircleCollider2D>().enabled = true;//当たり判定
                gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 0, 0, 255);

            }
        }

        //死亡処理
        if (HpSlider.value == 0)
        {
            SceneManager.LoadScene("Gameover");
        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player_Bullet")
        {
            HpSlider.value -= 1;
        }
        if (collision.gameObject.tag == "URA_Player_Bullet")
        {
            HpSlider.value -= 2;
        }
    }
}
