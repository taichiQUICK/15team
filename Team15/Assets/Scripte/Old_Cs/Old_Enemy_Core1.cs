using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Old_Enemy_Core1 : MonoBehaviour
{
    public static bool baramakikougeki = false;
    public GameObject Player;
    public GameObject EnemyBullet_Type_1;
    public GameObject EnemyBullet_Type_2;
    public GameObject EnemyBullet_Type_3;
    private float AutoTime = 0f;
    bool Triger = false;
    bool HpSwith900 = true;//ばらまきだん発生条件
    bool Stels = false; //  こいつは最初からステルス　false  trueで裏で実体化
    int count = 0;
    public Slider HpSlider;
    bool LevelOne = false; bool LevelOneTriger = true;
    bool LevelTwo = false; bool LevelTwoTriger = true;
    bool Lv3rd = false; bool Lv3rdTr = true;
    bool Lv4rd = false; bool Lv4rdTr = true;
    bool Lv5rd = false; bool Lv5rdTr = true;
    bool Lv6rd = false; bool Lv6rdTr = true;
    bool Lv7rd = false; bool Lv7rdTr = true;
    float GameTime = 0;


    float baramakikannkakuTIme = 0;
   


    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        HpSlider.value = 1080;
        // shoki();
        Player_Move.uragaseikika = true;
    }

    // Update is called once per frame
    void Update()
    {
        //ハダ_Pause用、Time.timeScaleが0のとき返す
        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }
        if (Player_Move.hennkann == true)
        {
            GameTime += Time.deltaTime;
        }
        AutoTime += Time.deltaTime;
        if (GameTime >= 1f && LevelOneTriger == true)
        {
            LevelOne = true;
            if (1.0f < AutoTime && Player_Move.hennkann == true && Stels == true && LevelOne == true)
            {
                for (int i = 0; i < 12; i++)
                {//裏面等角攻撃
                    AutoTime = 0f;
                    float ShotSpeed = 5.5f;
                    Vector2 vec = Player.transform.position - transform.position;
                    vec.Normalize();
                    vec = Quaternion.Euler(0, 0, (360 / 12) * i) * vec;
                    vec *= ShotSpeed;
                    var t = Instantiate(EnemyBullet_Type_2, transform.position, EnemyBullet_Type_2.transform.rotation);
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                }
                count++;
            }
        }
        if (GameTime >= 5f && LevelTwoTriger == true)
        {
            LevelOneTriger = false;
            LevelTwo = true;
            if (1.0f < AutoTime && LevelTwo == true)
            {
                for (int i = 0; i < 16; i++)
                {//裏面等角攻撃                      
                    AutoTime = 0f;
                    float ShotSpeed = 5.5f;
                    Vector2 vec = Player.transform.position - transform.position;
                    vec.Normalize();
                    vec = Quaternion.Euler(0, 0, (360 / 16) * i) * vec;
                    vec *= ShotSpeed;
                    var t = Instantiate(EnemyBullet_Type_2, transform.position, EnemyBullet_Type_2.transform.rotation);
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                }
                count++;
            }
        }
        if (GameTime >= 8f && Lv3rdTr == true)
        {
            LevelTwoTriger = false;
            Lv3rd = true;
            if (0.5f < AutoTime && Player_Move.hennkann == true && Stels == true && Lv3rd == true)
            {
                for (int i = 0; i < 24; i++)
                {//裏面等角攻撃
                    AutoTime = 0f;
                    float ShotSpeed = 3;
                    Vector2 vec = Player.transform.position - transform.position;
                    vec.Normalize();
                    vec = Quaternion.Euler(0, 0, (360 / 24) * i) * vec;
                    vec *= ShotSpeed;
                    var t = Instantiate(EnemyBullet_Type_2, transform.position, EnemyBullet_Type_2.transform.rotation);
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                }
                count++;
            }
        }
        if (GameTime >= 15f && Lv4rdTr == true)
        {
            Lv3rdTr = false;
            Lv4rd = true;
            if (1f < AutoTime && Player_Move.hennkann == true && Stels == true && Lv4rd == true)
            {
                for (int i = 0; i < 24; i++)
                {//裏面等角攻撃
                    AutoTime = 0f;
                    float ShotSpeed = 5.5f;
                    Vector2 vec = Player.transform.position - transform.position;
                    vec.Normalize();
                    vec = Quaternion.Euler(0, 0, (360 / 20) * i) * vec;
                    vec *= ShotSpeed;
                    var t = Instantiate(EnemyBullet_Type_2, transform.position, EnemyBullet_Type_2.transform.rotation);
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                }
                count++;
            }
        }
        if (GameTime >= 20f && Lv5rdTr == true)
        {
            Lv4rdTr = false;
            Lv5rd = true;
            if (Player_Move.hennkann == true && Stels == true && Lv5rd == true)
            {
                
                baramakikannkakuTIme += Time.deltaTime;
                if (baramakikannkakuTIme > 0.1f)
                {
                    
                    float ShotSpeed = 2;
                    Vector2 vec = new Vector2(0.0f, 1.0f);
                    vec = Quaternion.Euler(0, 0, Random.Range(0.0f, 360.0f)) * vec;
                    vec *= ShotSpeed;
                    var q = Quaternion.Euler(0, 0, -Mathf.Atan2(vec.x, vec.y) * Mathf.Rad2Deg);
                    var t = Instantiate(EnemyBullet_Type_3, transform.position, q);
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                    baramakikannkakuTIme = 0f;                  
                }
            }
        }
        if (GameTime >= 30 && Lv6rdTr == true)
        {
            Lv5rd = false;
            Lv6rd = true;
            if (0.5f < AutoTime && Player_Move.hennkann == true && Stels == true && Lv6rd == true)
            {
                for (int i = 0; i < 24; i++)
                {//裏面等角攻撃
                    AutoTime = 0f;
                    float ShotSpeed = 4;
                    Vector2 vec = Player.transform.position - transform.position;
                    vec.Normalize();
                    vec = Quaternion.Euler(0, 0, (360 / 24) * i) * vec;
                    vec *= ShotSpeed;
                    var t = Instantiate(EnemyBullet_Type_2, transform.position, EnemyBullet_Type_2.transform.rotation);
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                }
                count++;
            }
        }


        /* if (HpSlider.value < 1000 && HpSwith900 == true)
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
                if (Player_Move.uragaseikika == false && Triger == false)
                {
                    Stels = true;
                    // 実体化　裏でね
                    Triger = true;
                    GetComponent<CircleCollider2D>().enabled = true;//当たり判定
                                                                    // gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 0, 0, 100);
                    gameObject.GetComponent<SpriteRenderer>().color = new Color32(0, 0, 255, 255);

                }
            }
        }
        //  if (Input.GetKeyDown(KeyCode.H))
        {

            if (Player_Move.uragaseikika == true && Triger == true)
            {
                Stels = false;
                //  Debug.Log("表になった");
                Triger = false;
                GetComponent<CircleCollider2D>().enabled = false;//当たり判定
                gameObject.GetComponent<SpriteRenderer>().color = new Color32(0, 0, 255, 100);

            }
        }

        //死亡処理
        if (HpSlider.value == 0)
        {
            SceneManager.LoadScene("Gameover");
        }


    }
     void shoki()
    {
            GetComponent<CircleCollider2D>().enabled = false;//当たり判定
            gameObject.GetComponent<SpriteRenderer>().color = new Color32(0, 0, 255, 100);
            Debug.Log("再読み込み");

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