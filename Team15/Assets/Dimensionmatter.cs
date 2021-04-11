using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class Dimensionmatter : MonoBehaviour
{
    public GameObject EnemyBullet_Type_1;
    public GameObject EnemyBullet_Type_2;
    public static bool baramakikougeki = false;
    public GameObject Player;
    public GameObject L_D_Point;
    public GameObject R_D_Point;
    public GameObject L_U_Point;
    public GameObject R_U_Point;
    public GameObject Trident_;
    public GameObject Trident_L;
    public GameObject Trident_R;
    // public GameObject EnemyBullet_Type_1;
    // public GameObject EnemyBullet_Type_2;
    private float AutoTime = 0f;
    bool Triger = true;
    bool HpSwith900 = true;//ばらまきだん発生条件
    bool Stels = false; //ステルス状態か否か　falseが非ステ
    int count = 0;
    public Slider HpSlider;
    float GameTime = 0;

    SpriteRenderer Dimensionmatter_sprite;
    public Sprite Red;
    public Sprite Blue;

    float faze3ShotSpeed = 6.5f;
    float faze3Rate = 0.5f;
    float faze8Rate = 2f;

    float timeA = 0f;
    float timeB = 0f;
    float timeC = 1f;
    float timeD = 1f;
    float timeE = 0f;
    float fase6Time = 0f;
    float fase7Time = 0f;
    float timeG = 0f;


    float GameBossTime = 0f;


    bool Triger1 = true;
    bool Triger2 = true;
    bool Triger3 = true;
    bool Triger4 = true;
    bool Triger5 = true;
    bool Triger6 = true;
    bool Triger7 = true;

    bool faze1 = true;
    bool faze2 = false;
    bool faze3 = false;
    bool faze4 = false;
    bool faze5 = false;
    bool faze6 = false;
    bool faze7 = false;
    bool faze8 = true;

    bool faze5Triger = true;
    bool faze5Triger2 = true;
    bool faze5Trgier3 = true;
    bool faze7Triger = true;
    bool faze7Triger2 = true;
    bool faze7Trgier3 = true;
    // static bool Fours Bullet = false
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        HpSlider.value = 1620;
        Player_Move.hennkann = false;
        Player_Move.uragaseikika = false;
        Dimensionmatter_sprite = gameObject.GetComponent<SpriteRenderer>();
        Dimensionmatter_sprite.sprite = Red;


    }

    // Update is called once per frame
    void Update()
    {
        if (Player_Move.hennkann == true)
        {
            GameTime += Time.deltaTime;
        }
        else
        {
            // Debug.Log("時間経過を停止");
        }
        //ハダ_Pause用、Time.timeScaleが0のとき返す
        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }

        GameBossTime += Time.deltaTime;
        if(GameBossTime >= 35f)
        {
            faze7 = false;
            Triger6 = false;
            faze8 = true;
        }
        if (GameBossTime >= 30f && Triger6 == true)
        {
            Triger5 = false;
            faze6 = false;
            faze7 = true;
        }
        if (GameBossTime >= 25f && Triger5 == true)
        {
            faze5 = false;
            Triger4 = false;
            faze6 = true;
        }
        if (GameBossTime >= 20f && Triger4 == true)
        {
            faze4 = false;
            Triger3 = false;
            faze5 = true;
        }
        if (GameBossTime >= 15f && Triger3 == true)
        {
            faze1 = false;
            faze3 = false;
            faze4 = true;
            Triger2 = false;
            // Debug.Log("15秒経過　フェイズ１終了");
        }
        if (GameBossTime >= 10f && Triger2 == true)
        {
            Triger1 = false;
            faze2 = false;
            faze3 = true;

            //  Debug.Log("10秒経過　フェイズ２終了");フェイズ３開始
        }
        if (GameBossTime >= 5f && Triger1 == true)
        {
            timeA += Time.deltaTime;
            faze2 = true;
            // Debug.Log("5秒経過　フェイズ２開始");
        }





        if (faze1 == true)
        {
            timeB += Time.deltaTime;
            if (0.5f < timeB)
            {
                {
                    float ShotSpeed = 5f;//弾速初速
                    var pos = this.gameObject.transform.position;
                    var t = Instantiate(EnemyBullet_Type_1, this.transform.position, Quaternion.identity) as GameObject;
                    Vector2 vec = R_D_Point.transform.position - pos;
                    vec.Normalize();
                    vec *= ShotSpeed;
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                    timeB = 0f;
                }
                {
                    float ShotSpeed = 5f;//弾速初速
                    var pos = this.gameObject.transform.position;
                    var t = Instantiate(EnemyBullet_Type_1, this.transform.position, Quaternion.identity) as GameObject;
                    Vector2 vec = L_D_Point.transform.position - pos;
                    vec.Normalize();
                    vec *= ShotSpeed;
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                    timeB = 0f;
                }
                {
                    float ShotSpeed = 5f;//弾速初速
                    var pos = this.gameObject.transform.position;
                    var t = Instantiate(EnemyBullet_Type_1, this.transform.position, Quaternion.identity) as GameObject;
                    Vector2 vec = L_U_Point.transform.position - pos;
                    vec.Normalize();
                    vec *= ShotSpeed;
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                    timeB = 0f;
                }
                {
                    float ShotSpeed = 5f;//弾速初速
                    var pos = this.gameObject.transform.position;
                    var t = Instantiate(EnemyBullet_Type_1, this.transform.position, Quaternion.identity) as GameObject;
                    Vector2 vec = R_U_Point.transform.position - pos;
                    vec.Normalize();
                    vec *= ShotSpeed;
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                    timeB = 0f;
                }
            }
        }
        if (faze2 == true)
        {
            if (1f < timeA)
            {
                {
                    float ShotSpeed = 3f;//弾速初速
                    var pos = this.gameObject.transform.position;
                    var t = Instantiate(EnemyBullet_Type_1, this.transform.position, Quaternion.identity) as GameObject;
                    Vector2 vec = Trident_.transform.position - pos;
                    vec.Normalize();
                    vec *= ShotSpeed;
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                    timeA = 0f;
                }
                {
                    float ShotSpeed = 3f;//弾速初速
                    var pos = this.gameObject.transform.position;
                    var t = Instantiate(EnemyBullet_Type_1, this.transform.position, Quaternion.identity) as GameObject;
                    Vector2 vec = Trident_L.transform.position - pos;
                    vec.Normalize();
                    vec *= ShotSpeed;
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                    timeA = 0f;
                }
                {
                    float ShotSpeed = 3f;//弾速初速
                    var pos = this.gameObject.transform.position;
                    var t = Instantiate(EnemyBullet_Type_1, this.transform.position, Quaternion.identity) as GameObject;
                    Vector2 vec = Trident_R.transform.position - pos;
                    vec.Normalize();
                    vec *= ShotSpeed;
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                    timeA = 0f;
                }
            }
        }
        if (faze3 == true && Triger2 == true)
        {
            timeC += Time.deltaTime;
            if (faze3Rate < timeC)
            {
                for (int i = 0; i < 62; i++)
                {//裏面等角攻撃
                 // AutoTime = 0f;
                    timeC = 0f;
                    // float ShotSpeed = 7;
                    Vector2 vec = Player.transform.position - transform.position;
                    vec.Normalize();
                    vec = Quaternion.Euler(0, 0, (360 / 24) * i) * vec;
                    vec *= faze3ShotSpeed;
                    var t = Instantiate(EnemyBullet_Type_2, transform.position, EnemyBullet_Type_2.transform.rotation);
                    t.GetComponent<Rigidbody2D>().velocity = vec;

                }
                count++;
            }
        }
        if (faze4 == true && Triger3 == true)
        {
            timeD += Time.deltaTime;
            this.transform.DOMove(new Vector3(0f, 1.5f, 0f), 5f).SetEase(Ease.OutSine);
            if (1f < timeD)
            {
                float ShotSpeed = 6f;//弾速初速
                var pos = this.gameObject.transform.position;
                var t = Instantiate(EnemyBullet_Type_2, this.transform.position, Quaternion.identity) as GameObject;
                Vector2 vec = Player.transform.position - pos;
                vec.Normalize();
                vec *= ShotSpeed;
                t.GetComponent<Rigidbody2D>().velocity = vec;
                timeD = 0f;
            }
        }
        if (faze5 == true)
        {
            timeE += Time.deltaTime;
            this.transform.DOMove(new Vector3(-2.8f, 1.5f, 0f), 5f).SetEase(Ease.OutSine);

            if (2f < timeE && faze5Triger == true)
            {
                {
                    float ShotSpeed = 3f;//弾速初速
                    var pos = this.gameObject.transform.position;
                    var t = Instantiate(EnemyBullet_Type_1, this.transform.position, Quaternion.identity) as GameObject;
                    Vector2 vec = Trident_.transform.position - pos;
                    vec.Normalize();
                    vec *= ShotSpeed;
                    t.GetComponent<Rigidbody2D>().velocity = vec;

                }
                {
                    float ShotSpeed = 3f;//弾速初速
                    var pos = this.gameObject.transform.position;
                    var t = Instantiate(EnemyBullet_Type_1, this.transform.position, Quaternion.identity) as GameObject;
                    Vector2 vec = Trident_L.transform.position - pos;
                    vec.Normalize();
                    vec *= ShotSpeed;
                    t.GetComponent<Rigidbody2D>().velocity = vec;

                }
                {
                    float ShotSpeed = 3f;//弾速初速
                    var pos = this.gameObject.transform.position;
                    var t = Instantiate(EnemyBullet_Type_1, this.transform.position, Quaternion.identity) as GameObject;
                    Vector2 vec = Trident_R.transform.position - pos;
                    vec.Normalize();
                    vec *= ShotSpeed;
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                    faze5Triger = false;
                }
            }
            if (4f < timeE && faze5Triger2 == true)
            {
                for (int i = 0; i < 24; i++)
                {//裏面等角攻撃
                 // AutoTime = 0f;
                    timeC = 0f;
                    float ShotSpeed = 5;
                    Vector2 vec = Player.transform.position - transform.position;
                    vec.Normalize();
                    vec = Quaternion.Euler(0, 0, (360 / 24) * i) * vec;
                    vec *= ShotSpeed;
                    var t = Instantiate(EnemyBullet_Type_2, transform.position, EnemyBullet_Type_2.transform.rotation);
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                    faze5Triger2 = false;
                }
                count++;
            }
            if (4.9f > timeE && faze5Trgier3 == true)
            {
                GameObject prefab = (GameObject)Resources.Load("KOKI_L");
                GameObject KOKI_R = Instantiate(prefab, this.transform.position, Quaternion.identity);
                faze5Trgier3 = false;
            }
        }
        if (faze6 == true)
        {
            fase6Time += Time.deltaTime;
            this.transform.DOMove(new Vector3(-5.6f, 1.5f, 0f), 5f).SetEase(Ease.OutSine);
            if (1f < fase6Time)
            {
                float ShotSpeed = 6f;//弾速初速
                var pos = this.gameObject.transform.position;
                var t = Instantiate(EnemyBullet_Type_2, this.transform.position, Quaternion.identity) as GameObject;
                Vector2 vec = Player.transform.position - pos;
                vec.Normalize();
                vec *= ShotSpeed;
                t.GetComponent<Rigidbody2D>().velocity = vec;
                fase6Time = 0f;
            }
        }
        if(faze7 == true)
        {
            fase7Time += Time.deltaTime;
            this.transform.DOMove(new Vector3(-2.8f, 1.5f, 0f), 5f).SetEase(Ease.OutSine);
            if (2f < fase7Time && faze7Triger == true)
            {
                {
                    float ShotSpeed = 3f;//弾速初速
                    var pos = this.gameObject.transform.position;
                    var t = Instantiate(EnemyBullet_Type_1, this.transform.position, Quaternion.identity) as GameObject;
                    Vector2 vec = Trident_.transform.position - pos;
                    vec.Normalize();
                    vec *= ShotSpeed;
                    t.GetComponent<Rigidbody2D>().velocity = vec;

                }
                {
                    float ShotSpeed = 3f;//弾速初速
                    var pos = this.gameObject.transform.position;
                    var t = Instantiate(EnemyBullet_Type_1, this.transform.position, Quaternion.identity) as GameObject;
                    Vector2 vec = Trident_L.transform.position - pos;
                    vec.Normalize();
                    vec *= ShotSpeed;
                    t.GetComponent<Rigidbody2D>().velocity = vec;

                }
                {
                    float ShotSpeed = 3f;//弾速初速
                    var pos = this.gameObject.transform.position;
                    var t = Instantiate(EnemyBullet_Type_1, this.transform.position, Quaternion.identity) as GameObject;
                    Vector2 vec = Trident_R.transform.position - pos;
                    vec.Normalize();
                    vec *= ShotSpeed;
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                    faze7Triger = false;
                }
            }
            if (4f < fase7Time && faze7Triger2 == true)
            {
                for (int i = 0; i < 24; i++)
                {//裏面等角攻撃
                 // AutoTime = 0f;
                    timeC = 0f;
                    float ShotSpeed = 5;
                    Vector2 vec = Player.transform.position - transform.position;
                    vec.Normalize();
                    vec = Quaternion.Euler(0, 0, (360 / 24) * i) * vec;
                    vec *= ShotSpeed;
                    var t = Instantiate(EnemyBullet_Type_2, transform.position, EnemyBullet_Type_2.transform.rotation);
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                    faze7Triger2 = false;
                }
                count++;
            }
            if (4.9f > fase7Time && faze7Trgier3)
            {
                GameObject prefab = (GameObject)Resources.Load("KOKI_R");
                GameObject KOKI_R = Instantiate(prefab, this.transform.position, Quaternion.identity);
                faze7Trgier3 = false;
            }
        }
        if(faze8 == true)
        {
            timeG += Time.deltaTime;
            if (faze8Rate < timeG)
            {
                for (int i = 0; i < 24; i++)
                {//裏面等角攻撃
                 // AutoTime = 0f;
                    timeG = 0f;
                    float ShotSpeed = 8;
                    Vector2 vec = Player.transform.position - transform.position;
                    vec.Normalize();
                    vec = Quaternion.Euler(0, 0, (360 / 24) * i) * vec;
                    vec *= ShotSpeed;
                    GameObject prefab = (GameObject)Resources.Load("STOP_Bullet_Obj");
                    GameObject STOP_Bullet_Obj = Instantiate(prefab, this.transform.position, Quaternion.identity);
                    STOP_Bullet_Obj.GetComponent<Rigidbody2D>().velocity = vec;

                }
                count++;
            }
        }
















        {
            if (Player_Move.hennkann == true && Triger == true)
            {
                faze3ShotSpeed = 3f;
                faze3Rate = 1f;
                Stels = true;
                // Debug.Log("裏になった");
                Triger = false;
                Dimensionmatter_sprite.sprite = Blue;
            }
        }
        if (Player_Move.hennkann == false && Triger == false)
        {
            faze3ShotSpeed = 6.5f;
            faze3Rate = 0.5f;
            Stels = false;
            //  Debug.Log("表になった");
            Triger = true;
            Dimensionmatter_sprite.sprite = Red;
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
            HpSlider.value -= 1f;
        }
        if (collision.gameObject.tag == "URA_Player_Bullet")
        {
            HpSlider.value -= 2f;
        }
    }
}
