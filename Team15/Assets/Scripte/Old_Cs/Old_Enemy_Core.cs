using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Old_Enemy_Core : MonoBehaviour
{
    public static bool baramakikougeki = false;
    public GameObject Player;
    public GameObject EnemyBullet_Type_1;
    public GameObject EnemyBullet_Type_2;
    private float AutoTime = 0f;
    bool Triger = true;
    bool HpSwith900 = true;//ばらまきだん発生条件
    bool Stels = false; //ステルス状態か否か　falseが非ステ
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
    //
    //赤色　太陽　の　スクリプト!!!! 本実はメイン
    //

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        HpSlider.value = 1080;
    }

    // Update is called once per frame
    void Update()
    {
        AutoTime += Time.deltaTime;
        if (Player_Move.hennkann == false)
        {
            GameTime += Time.deltaTime;
        }
        else
        {
            // Debug.Log("時間経過を停止");
        }
        if (GameTime >= 3f && LevelOneTriger == true)
        {
            LevelOne = true;
            Debug.Log("ボス始動　攻撃開始　Level1");
            if (1.5f < AutoTime && Player_Move.hennkann == false && Stels == false && LevelOne == true)
            {
                for (int i = 0; i < 8; i++)
                {//表面等角攻撃
                    AutoTime = 0f;
                    float ShotSpeed = 8;
                    Vector2 vec = Player.transform.position - transform.position;
                    vec.Normalize();
                    vec = Quaternion.Euler(0, 0, (360 / 8) * i) * vec;
                    vec *= ShotSpeed;
                    var t = Instantiate(EnemyBullet_Type_1, transform.position, EnemyBullet_Type_1.transform.rotation);
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                }
                count++;
            }
        }
        if (GameTime >= 10 && LevelTwoTriger == true)
        {
            LevelOneTriger = false;
            LevelTwo = true;
           // Debug.Log("ボスレベル上昇　Level2");
            if (1.5f < AutoTime && Player_Move.hennkann == false && Stels == false && LevelTwo == true)
            {
                for (int i = 0; i < 12; i++)
                {//表面等角攻撃
                    AutoTime = 0f;
                    float ShotSpeed = 8;
                    Vector2 vec = Player.transform.position - transform.position;
                    vec.Normalize();
                    vec = Quaternion.Euler(0, 0, (360 / 12) * i) * vec;
                    vec *= ShotSpeed;
                    var t = Instantiate(EnemyBullet_Type_1, transform.position, EnemyBullet_Type_1.transform.rotation);
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                }
                count++;
            }
        }
        if (GameTime >= 20 && Lv3rdTr == true)
        {
            LevelTwoTriger = false;
            Lv3rd = true;
            //Debug.Log("ボスレベル上昇　Level3");
            if (1.3f < AutoTime && Player_Move.hennkann == false && Stels == false && Lv3rd == true)
            {
                for (int i = 0; i < 16; i++)
                {//表面等角攻撃
                    AutoTime = 0f;
                    float ShotSpeed = 8;
                    Vector2 vec = Player.transform.position - transform.position;
                    vec.Normalize();
                    vec = Quaternion.Euler(0, 0, (360 / 16) * i) * vec;
                    vec *= ShotSpeed;
                    var t = Instantiate(EnemyBullet_Type_1, transform.position, EnemyBullet_Type_1.transform.rotation);
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                }
                count++;
            }
        }
        if (GameTime >= 30 && Lv4rdTr == true)
        {
            Lv3rdTr = false;
            Lv4rd = true;
           // Debug.Log("ボスレベル上昇　Level4");
            if (1.0f < AutoTime && Player_Move.hennkann == false && Stels == false && Lv4rd == true)
            {
                for (int i = 0; i < 20; i++)
                {//表面等角攻撃
                    AutoTime = 0f;
                    float ShotSpeed = 8;
                    Vector2 vec = Player.transform.position - transform.position;
                    vec.Normalize();
                    vec = Quaternion.Euler(0, 0, (360 / 20) * i) * vec;
                    vec *= ShotSpeed;
                    var t = Instantiate(EnemyBullet_Type_1, transform.position, EnemyBullet_Type_1.transform.rotation);
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                }
                count++;
            }
        }
        if (GameTime >= 40 && Lv5rdTr == true)
        {
            Lv4rdTr = false;
            Lv5rd = true;
           // Debug.Log("ボスレベル上昇　Level5");
            if (0.8f < AutoTime && Player_Move.hennkann == false && Stels == false && Lv5rd == true)
            {
                for (int i = 0; i < 24; i++)
                {//表面等角攻撃
                    AutoTime = 0f;
                    float ShotSpeed = 8;
                    Vector2 vec = Player.transform.position - transform.position;
                    vec.Normalize();
                    vec = Quaternion.Euler(0, 0, (360 / 24) * i) * vec;
                    vec *= ShotSpeed;
                    var t = Instantiate(EnemyBullet_Type_1, transform.position, EnemyBullet_Type_1.transform.rotation);
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                }
                count++;
            }
        }
        if (GameTime >= 50 && Lv6rdTr == true)
        {
            Lv5rdTr = false;
            Lv6rd = true;
           // Debug.Log("ボスレベル上昇　Level6");
            if (0.5f < AutoTime && Player_Move.hennkann == false && Stels == false && Lv6rd == true)
            {
                for (int i = 0; i < 24; i++)
                {//表面等角攻撃
                    AutoTime = 0f;
                    float ShotSpeed = 8;
                    Vector2 vec = Player.transform.position - transform.position;
                    vec.Normalize();
                    vec = Quaternion.Euler(0, 0, (360 / 24) * i) * vec;
                    vec *= ShotSpeed;
                    var t = Instantiate(EnemyBullet_Type_1, transform.position, EnemyBullet_Type_1.transform.rotation);
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                }
                count++;
            }
        }
        if (GameTime >= 60 && Lv7rdTr == true)
        {
            Lv6rdTr = false;
            Lv7rd = true;
          //  Debug.Log("ボスレベル上昇　Level7");
            if (0.3f < AutoTime && Player_Move.hennkann == false && Stels == false && Lv7rd == true)
            {
                for (int i = 0; i < 24; i++)
                {//表面等角攻撃
                    AutoTime = 0f;
                    float ShotSpeed = 8;
                    Vector2 vec = Player.transform.position - transform.position;
                    vec.Normalize();
                    vec = Quaternion.Euler(0, 0, (360 / 24) * i) * vec;
                    vec *= ShotSpeed;
                    var t = Instantiate(EnemyBullet_Type_1, transform.position, EnemyBullet_Type_1.transform.rotation);
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                }
                count++;
            }
        }
        //ハダ_Pause用、Time.timeScaleが0のとき返す
        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }
  
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
      /*  if (1.0f < AutoTime && Player_Move.hennkann == false && Stels == false && LevelOneTriger == false)
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


        if (0.5f < AutoTime && Player_Move.hennkann == true && Stels == false)//表面しか使用しないのでこのメソッドは使わないけど　残しておく!
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
        }*/
        /*if (HpSlider.value < 1000 && HpSwith900 == true)
        {
            Debug.Log("1000HP");
            baramakikougeki = true;
            HpSwith900 = false;
        }
        if (1051 < HpSlider.value)
        {

            baramakikougeki = false;

        }
        */


        {
            //  if (Input.GetKeyDown(KeyCode.G))
            {
                if (Player_Move.hennkann == true && Triger == true)
                {
                    Stels = true;
                    // Debug.Log("裏になった");
                    Triger = false;
                    GetComponent<CircleCollider2D>().enabled = false;//当たり判定
                    // gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 0, 0, 100);
                    gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 0, 0, 100);

                }
            }
        }
        //  if (Input.GetKeyDown(KeyCode.H))
        {

            if (Player_Move.hennkann == false && Triger == false)
            {
                Stels = false;
                //  Debug.Log("表になった");
                Triger = true;
                GetComponent<CircleCollider2D>().enabled = true;//当たり判定
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
