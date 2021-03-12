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



    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        HpSlider.value = 1080;
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