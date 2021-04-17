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
    public GameObject Bigboll_Red;
    public GameObject EnemyBullet_URABULU;
    public GameObject Trident_bullet;
    public static bool baramakikougeki = false;
    public GameObject Player;
    public GameObject L_D_Point;
    public GameObject R_D_Point;
    public GameObject L_U_Point;
    public GameObject R_U_Point;
    public GameObject L_Eria;
    public GameObject R_Eria;
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

    float faze3ShotSpeed = 6f;
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
    float timeH = 0f;
    float TimeI = 0f;
    float timeJ = 0f;
    float timeK = 0f;
    float timeL = 0f;
    float timeN = 0f;
    float timeP = 0f;

    float DOTtimer1 = 0f;
    float firstrate = 0.5f;

    float GameBossTime = 0f;
    float ShotSpeedTTT = 4f;


    bool Triger1 = true;
    bool Triger2 = true;
    bool Triger3 = true;
    bool Triger4 = true;
    bool Triger5 = true;
    bool Triger6 = true;
    bool Triger7 = true;
    bool Triger8 = true;
    bool Triger9 = true;
    bool Triger10 = true;
    bool Triger11 = true;
    bool Triger12 = true;
    bool Triger13 = true;
    bool Triger14 = true;
    bool Triger15 = true;


    bool faze1 = true;
    bool faze2 = false;
    bool faze3 = false;
    bool faze4 = false;
    bool faze5 = false;
    bool faze6 = false;
    bool faze7 = false;
    bool faze8 = false;
    bool faze9 = false;
    bool faze10 = false;
    bool faze11 = false;
    bool faze12 = false;
    bool faze13 = false;
    bool faze14 = false;
    bool faze15 = false;

    bool faze5Triger = true;
    bool faze5Triger2 = true;
    bool faze5Trgier3 = true;
    bool faze7Triger = true;
    bool faze7Triger2 = true;
    bool faze7Trgier3 = true;
    bool faze9Triger = true;
    bool faze10Trifer = true;
    bool EFTriger = true;
    bool DOTtriger = true;
    bool DOTtriger2 = true;
    bool DOTtriger3 = true;
    bool DOTtriger4 = true;
    bool DOTtriger5 = true;
    bool DOTtriger6 = true;
    bool DOTtriger7 = true;


    public static bool faze9move = false;
    public static bool faze10move = false;
    public static bool trigertiger = false;
    public static bool trigertgier2 = false;
    public static bool trigertrgier3 = false;
    public static bool trigertrgier4 = false;

    public float firstbulletspeed;//3.5f;
    public float first_delayspeed;
    public float PopalPulalet;
    AudioSource audio;
    // static bool Fours Bullet = false
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        HpSlider.value = 1080;
        Player_Move.hennkann = false;
        Player_Move.uragaseikika = false;
        //faze9move = true;
        //  faze10move = true;
        trigertiger = false;
        trigertgier2 = false;
        trigertrgier3 = false;
        trigertrgier4 = false;
        faze9move = false;
        faze10move = false;
        Dimensionmatter_sprite = gameObject.GetComponent<SpriteRenderer>();
        Dimensionmatter_sprite.sprite = Red;
        audio = this.GetComponent<AudioSource>();
        Invoke("AudioPlay", 0);

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
            audio.Pause();
            return;
        }
        else
        {
            audio.UnPause();
        }

        GameBossTime += Time.deltaTime;
        if (GameBossTime >= 90 && Triger14 == true)
        {
            Triger13 = false;
            faze13 = false;
            HpSlider.value = 0;
            Debug.Log("時間で倒した");
            Triger14 = false;
            //   faze14 = true;
        }
        if (GameBossTime >= 75 && Triger13 == true)
        {
            Triger12 = false;
            faze12 = false;
            faze13 = true;
        }
        if (GameBossTime >= 65 && Triger12 == true)
        {
            Triger11 = false;
            faze12 = true;
            faze11 = false;
        }
        if (GameBossTime >= 60 && Triger11 == true)
        {
            Triger10 = false;
            faze11 = true;
            faze10 = false;
        }
        if (GameBossTime >= 50f && Triger10 == true)
        {
            faze9 = false;
            Triger8 = false;
            Triger9 = false;
            faze10 = true;
            //  Debug.Log("skaaaa");

        }
        if (GameBossTime >= 45f && Triger9 == true)
        {
            faze8 = false;
        }
        if (GameBossTime >= 40f && Triger8 == true)
        {
            Triger7 = false;
            faze9 = true;

        }
        if (GameBossTime >= 35f && Triger7 == true)
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
            if (firstrate < timeB)
            {
                {
                    if (Player_Move.hennkann == false)
                    {
                        //float ShotSpeed = 1f;//弾速初速
                        var pos = this.gameObject.transform.position;
                        var t = Instantiate(EnemyBullet_Type_1, this.transform.position, Quaternion.identity) as GameObject;
                        Vector2 vec = R_D_Point.transform.position - pos;
                        vec.Normalize();
                        vec *= firstbulletspeed;
                        t.GetComponent<Rigidbody2D>().velocity = vec;
                        timeB = 0f;
                    }
                }
                {
                    if (Player_Move.hennkann == false)
                    {
                        var pos = this.gameObject.transform.position;
                        var t = Instantiate(EnemyBullet_Type_1, this.transform.position, Quaternion.identity) as GameObject;
                        Vector2 vec = L_D_Point.transform.position - pos;
                        vec.Normalize();
                        vec *= firstbulletspeed;
                        t.GetComponent<Rigidbody2D>().velocity = vec;
                        timeB = 0f;
                    }
                }
                {
                    if (Player_Move.hennkann == false)
                    {
                        var pos = this.gameObject.transform.position;
                        var t = Instantiate(EnemyBullet_Type_1, this.transform.position, Quaternion.identity) as GameObject;
                        Vector2 vec = L_U_Point.transform.position - pos;
                        vec.Normalize();
                        vec *= firstbulletspeed;
                        t.GetComponent<Rigidbody2D>().velocity = vec;
                        timeB = 0f;
                    }
                }
                {
                    if (Player_Move.hennkann == false)
                    {
                        var pos = this.gameObject.transform.position;
                        var t = Instantiate(EnemyBullet_Type_1, this.transform.position, Quaternion.identity) as GameObject;
                        Vector2 vec = R_U_Point.transform.position - pos;
                        vec.Normalize();
                        vec *= firstbulletspeed;
                        t.GetComponent<Rigidbody2D>().velocity = vec;
                        timeB = 0f;
                    }
                }
                {
                    if (Player_Move.hennkann == true)
                    {
                        //float ShotSpeed = 1f;//弾速初速
                        var pos = this.gameObject.transform.position;
                        var t = Instantiate(EnemyBullet_URABULU, this.transform.position, Quaternion.identity) as GameObject;
                        Vector2 vec = R_D_Point.transform.position - pos;
                        vec.Normalize();
                        vec *= first_delayspeed;
                        t.GetComponent<Rigidbody2D>().velocity = vec;
                        timeB = 0f;
                    }
                }
                {
                    if (Player_Move.hennkann == true)
                    {
                        var pos = this.gameObject.transform.position;
                        var t = Instantiate(EnemyBullet_URABULU, this.transform.position, Quaternion.identity) as GameObject;
                        Vector2 vec = L_D_Point.transform.position - pos;
                        vec.Normalize();
                        vec *= first_delayspeed;
                        t.GetComponent<Rigidbody2D>().velocity = vec;
                        timeB = 0f;
                    }
                }
                {
                    if (Player_Move.hennkann == true)
                    {
                        var pos = this.gameObject.transform.position;
                        var t = Instantiate(EnemyBullet_URABULU, this.transform.position, Quaternion.identity) as GameObject;
                        Vector2 vec = L_U_Point.transform.position - pos;
                        vec.Normalize();
                        vec *= first_delayspeed;
                        t.GetComponent<Rigidbody2D>().velocity = vec;
                        timeB = 0f;
                    }
                }
                {
                    if (Player_Move.hennkann == true)
                    {
                        var pos = this.gameObject.transform.position;
                        var t = Instantiate(EnemyBullet_URABULU, this.transform.position, Quaternion.identity) as GameObject;
                        Vector2 vec = R_U_Point.transform.position - pos;
                        vec.Normalize();
                        vec *= first_delayspeed;
                        t.GetComponent<Rigidbody2D>().velocity = vec;
                        timeB = 0f;
                    }
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
                    var t = Instantiate(Trident_bullet, this.transform.position, Quaternion.identity) as GameObject;
                    Vector2 vec = Trident_.transform.position - pos;
                    vec.Normalize();
                    vec *= ShotSpeed;
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                    timeA = 0f;
                }
                {
                    float ShotSpeed = 3f;//弾速初速
                    var pos = this.gameObject.transform.position;
                    var t = Instantiate(Trident_bullet, this.transform.position, Quaternion.identity) as GameObject;
                    Vector2 vec = Trident_L.transform.position - pos;
                    vec.Normalize();
                    vec *= ShotSpeed;
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                    timeA = 0f;
                }
                {
                    float ShotSpeed = 3f;//弾速初速
                    var pos = this.gameObject.transform.position;
                    var t = Instantiate(Trident_bullet, this.transform.position, Quaternion.identity) as GameObject;
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
                for (int i = 0; i < 24; i++)
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

            if (DOTtriger2 == true)
            {
                this.transform.DOMove(new Vector3(0f, 1.5f, 0f), 5f).SetEase(Ease.OutSine);
                DOTtriger2 = false;
            }
            if (1f < timeD && Player_Move.hennkann == false)
            {
                // float ShotSpeed = 4f;//弾速初速
                var pos = this.gameObject.transform.position;
                var t = Instantiate(EnemyBullet_Type_2, this.transform.position, Quaternion.identity) as GameObject;
                Vector2 vec = Player.transform.position - pos;
                vec.Normalize();
                vec *= PopalPulalet;
                t.GetComponent<Rigidbody2D>().velocity = vec;
                timeD = 0f;
            }
            if (1f < timeD && Player_Move.hennkann == true)
            {
                // float ShotSpeed = 4f;//弾速初速
                var pos = this.gameObject.transform.position;
                var t = Instantiate(Bigboll_Red, this.transform.position, Quaternion.identity) as GameObject;
                Vector2 vec = Player.transform.position - pos;
                vec.Normalize();
                vec *= PopalPulalet;
                t.GetComponent<Rigidbody2D>().velocity = vec;
                timeD = 0f;
            }
        }
        if (faze5 == true)
        {
            timeE += Time.deltaTime;

            if (DOTtriger3 == true)
            {
                this.transform.DOMove(new Vector3(-2.8f, 1.5f, 0f), 5f).SetEase(Ease.OutSine);
                DOTtriger3 = false;
            }
            if (2f < timeE && faze5Triger == true)
            {
                {
                    float ShotSpeed = 3f;//弾速初速
                    var pos = this.gameObject.transform.position;
                    var t = Instantiate(Trident_bullet, this.transform.position, Quaternion.identity) as GameObject;
                    Vector2 vec = Trident_.transform.position - pos;
                    vec.Normalize();
                    vec *= ShotSpeed;
                    t.GetComponent<Rigidbody2D>().velocity = vec;

                }
                {
                    float ShotSpeed = 3f;//弾速初速
                    var pos = this.gameObject.transform.position;
                    var t = Instantiate(Trident_bullet, this.transform.position, Quaternion.identity) as GameObject;
                    Vector2 vec = Trident_L.transform.position - pos;
                    vec.Normalize();
                    vec *= ShotSpeed;
                    t.GetComponent<Rigidbody2D>().velocity = vec;

                }
                {
                    float ShotSpeed = 3f;//弾速初速
                    var pos = this.gameObject.transform.position;
                    var t = Instantiate(Trident_bullet, this.transform.position, Quaternion.identity) as GameObject;
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
                    //  float ShotSpeed = 5;
                    Vector2 vec = Player.transform.position - transform.position;
                    vec.Normalize();
                    vec = Quaternion.Euler(0, 0, (360 / 24) * i) * vec;
                    vec *= faze3ShotSpeed;
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
            //  DOTtimer1 += Time.deltaTime;         
            if (DOTtriger == true)
            {
                this.transform.DOMove(new Vector3(-5.6f, 1.5f, 0f), 5f).SetEase(Ease.OutSine);
                DOTtriger = false;
            }
            if (1f < fase6Time && Player_Move.hennkann == false)
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
            if (1f < fase6Time && Player_Move.hennkann == true)
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
        if (faze7 == true)
        {
            fase7Time += Time.deltaTime;

            if (DOTtriger4 == true)
            {
                this.transform.DOMove(new Vector3(-2.8f, 1.5f, 0f), 5f).SetEase(Ease.OutSine);
                DOTtriger4 = false;
            }
            if (2f < fase7Time && faze7Triger == true)
            {
                {
                    float ShotSpeed = 3f;//弾速初速
                    var pos = this.gameObject.transform.position;
                    var t = Instantiate(Trident_bullet, this.transform.position, Quaternion.identity) as GameObject;
                    Vector2 vec = Trident_.transform.position - pos;
                    vec.Normalize();
                    vec *= ShotSpeed;
                    t.GetComponent<Rigidbody2D>().velocity = vec;

                }
                {
                    float ShotSpeed = 3f;//弾速初速
                    var pos = this.gameObject.transform.position;
                    var t = Instantiate(Trident_bullet, this.transform.position, Quaternion.identity) as GameObject;
                    Vector2 vec = Trident_L.transform.position - pos;
                    vec.Normalize();
                    vec *= ShotSpeed;
                    t.GetComponent<Rigidbody2D>().velocity = vec;

                }
                {
                    float ShotSpeed = 3f;//弾速初速
                    var pos = this.gameObject.transform.position;
                    var t = Instantiate(Trident_bullet, this.transform.position, Quaternion.identity) as GameObject;
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
        if (faze8 == true)
        {
            timeG += Time.deltaTime;
            if (faze8Rate < timeG && Player_Move.hennkann == true)
            {
                // ShotSpeedTTT += 1f;
                for (int i = 0; i < 24; i++)
                {//裏面等角攻撃
                 // AutoTime = 0f;
                    timeG = 0f;
                    float ShotSpeedTTT = 4f;
                    Vector2 vec = Player.transform.position - transform.position;
                    vec.Normalize();
                    vec = Quaternion.Euler(0, 0, (360 / 24) * i) * vec;
                    vec *= ShotSpeedTTT;
                    GameObject prefab = (GameObject)Resources.Load("STOP_Bullet_Obj");
                    GameObject STOP_Bullet_Obj = Instantiate(prefab, this.transform.position, Quaternion.identity);
                    STOP_Bullet_Obj.GetComponent<Rigidbody2D>().velocity = vec;

                }
                count++;
            }

        }
        if (faze9 == true)
        {
            this.transform.DOMove(new Vector3(-2.8f, -3f, 0f), 10f).SetEase(Ease.OutQuad);
            timeH += Time.deltaTime;
            if (faze9 == true && faze9Triger == true)
            {
                faze9move = true;
                trigertiger = true;
                trigertrgier3 = true;
               // trigertgier2 = true;
                faze9Triger = false;
            }
            if (0.5f < timeH && Player_Move.hennkann == false)
            {
                {
                    var pos = this.gameObject.transform.position;
                    GameObject prefab = (GameObject)Resources.Load("MniMum 1");
                    GameObject MiniMum = Instantiate(prefab, this.transform.position, Quaternion.identity);
                    Vector2 vec = R_D_Point.transform.position - pos;
                    vec.Normalize();
                    vec *= firstbulletspeed;
                    MiniMum.GetComponent<Rigidbody2D>().velocity = vec;
                    timeH = 0f;
                }
                {
                    var pos = this.gameObject.transform.position;
                    GameObject prefab = (GameObject)Resources.Load("MniMum 1");
                    GameObject MiniMum = Instantiate(prefab, this.transform.position, Quaternion.identity);
                    Vector2 vec = L_D_Point.transform.position - pos;
                    vec.Normalize();
                    vec *= firstbulletspeed;
                    MiniMum.GetComponent<Rigidbody2D>().velocity = vec;
                    timeH = 0f;
                }
                {
                    var pos = this.gameObject.transform.position;
                    GameObject prefab = (GameObject)Resources.Load("MniMum 1");
                    GameObject MiniMum = Instantiate(prefab, this.transform.position, Quaternion.identity);
                    Vector2 vec = R_Eria.transform.position - pos;
                    vec.Normalize();
                    vec *= firstbulletspeed;
                    MiniMum.GetComponent<Rigidbody2D>().velocity = vec;
                    timeH = 0f;
                }
                {
                    var pos = this.gameObject.transform.position;
                    GameObject prefab = (GameObject)Resources.Load("MniMum 1");
                    GameObject MiniMum = Instantiate(prefab, this.transform.position, Quaternion.identity);
                    Vector2 vec = L_Eria.transform.position - pos;
                    vec.Normalize();
                    vec *= firstbulletspeed;
                    MiniMum.GetComponent<Rigidbody2D>().velocity = vec;
                    timeH = 0f;
                }
            }
            if (0.5f < timeH && Player_Move.hennkann == true)
            {
                {
                    var pos = this.gameObject.transform.position;
                    GameObject prefab = (GameObject)Resources.Load("MniMum_bule");
                    GameObject MiniMum = Instantiate(prefab, this.transform.position, Quaternion.identity);
                    Vector2 vec = R_D_Point.transform.position - pos;
                    vec.Normalize();
                    vec *= firstbulletspeed;
                    MiniMum.GetComponent<Rigidbody2D>().velocity = vec;
                    timeH = 0f;
                }
                {
                    var pos = this.gameObject.transform.position;
                    GameObject prefab = (GameObject)Resources.Load("MniMum_bule");
                    GameObject MiniMum = Instantiate(prefab, this.transform.position, Quaternion.identity);
                    Vector2 vec = L_D_Point.transform.position - pos;
                    vec.Normalize();
                    vec *= firstbulletspeed;
                    MiniMum.GetComponent<Rigidbody2D>().velocity = vec;
                    timeH = 0f;
                }
                {
                    var pos = this.gameObject.transform.position;
                    GameObject prefab = (GameObject)Resources.Load("MniMum_bule");
                    GameObject MiniMum = Instantiate(prefab, this.transform.position, Quaternion.identity);
                    Vector2 vec = R_Eria.transform.position - pos;
                    vec.Normalize();
                    vec *= firstbulletspeed;
                    MiniMum.GetComponent<Rigidbody2D>().velocity = vec;
                    timeH = 0f;
                }
                {
                    var pos = this.gameObject.transform.position;
                    GameObject prefab = (GameObject)Resources.Load("MniMum_bule");
                    GameObject MiniMum = Instantiate(prefab, this.transform.position, Quaternion.identity);
                    Vector2 vec = L_Eria.transform.position - pos;
                    vec.Normalize();
                    vec *= firstbulletspeed;
                    MiniMum.GetComponent<Rigidbody2D>().velocity = vec;
                    timeH = 0f;
                }
            }
        }
        if (faze10 == true)
        {

            if (DOTtriger5 == true)
            {
                this.transform.DOMove(new Vector3(-2.8f, 3f, 0f), 10f).SetEase(Ease.OutQuad);
                DOTtriger5 = false;
            }
            TimeI += Time.deltaTime;
            if (faze10 == true && faze10Trifer == true)
            {
                faze10move = true;
                trigertrgier4 = true;
                trigertgier2 = true;
                GameObject prefab = (GameObject)Resources.Load("KOKI_L1");
                GameObject KOKI_L = Instantiate(prefab, this.transform.position, Quaternion.identity);
                GameObject prefab1 = (GameObject)Resources.Load("KOKI_R1");
                GameObject KOKI_R = Instantiate(prefab1, this.transform.position, Quaternion.identity);

                faze10Trifer = false;
            }
            if (0.5f < TimeI && Player_Move.hennkann == false)
            {
                {
                    var pos = this.gameObject.transform.position;
                    GameObject prefab = (GameObject)Resources.Load("MniMum_bule");
                    GameObject MiniMum = Instantiate(prefab, this.transform.position, Quaternion.identity);
                    Vector2 vec = R_D_Point.transform.position - pos;
                    vec.Normalize();
                    vec *= firstbulletspeed;
                    MiniMum.GetComponent<Rigidbody2D>().velocity = vec;
                    TimeI = 0f;
                }
                {
                    var pos = this.gameObject.transform.position;
                    GameObject prefab = (GameObject)Resources.Load("MniMum_bule");
                    GameObject MiniMum = Instantiate(prefab, this.transform.position, Quaternion.identity);
                    Vector2 vec = L_D_Point.transform.position - pos;
                    vec.Normalize();
                    vec *= firstbulletspeed;
                    MiniMum.GetComponent<Rigidbody2D>().velocity = vec;
                    TimeI = 0f;
                }
                {
                    var pos = this.gameObject.transform.position;
                    GameObject prefab = (GameObject)Resources.Load("MniMum_bule");
                    GameObject MiniMum = Instantiate(prefab, this.transform.position, Quaternion.identity);
                    Vector2 vec = R_Eria.transform.position - pos;
                    vec.Normalize();
                    vec *= firstbulletspeed;
                    MiniMum.GetComponent<Rigidbody2D>().velocity = vec;
                    TimeI = 0f;
                }
                {
                    var pos = this.gameObject.transform.position;
                    GameObject prefab = (GameObject)Resources.Load("MniMum_bule");
                    GameObject MiniMum = Instantiate(prefab, this.transform.position, Quaternion.identity);
                    Vector2 vec = L_Eria.transform.position - pos;
                    vec.Normalize();
                    vec *= firstbulletspeed;
                    MiniMum.GetComponent<Rigidbody2D>().velocity = vec;
                    TimeI = 0f;
                }
            }
            if (0.5f < TimeI && Player_Move.hennkann == true)
            {
                {
                    var pos = this.gameObject.transform.position;
                    GameObject prefab = (GameObject)Resources.Load("MniMum 1");
                    GameObject MiniMum = Instantiate(prefab, this.transform.position, Quaternion.identity);
                    Vector2 vec = R_D_Point.transform.position - pos;
                    vec.Normalize();
                    vec *= firstbulletspeed;
                    MiniMum.GetComponent<Rigidbody2D>().velocity = vec;
                    TimeI = 0f;
                }
                {
                    var pos = this.gameObject.transform.position;
                    GameObject prefab = (GameObject)Resources.Load("MniMum 1");
                    GameObject MiniMum = Instantiate(prefab, this.transform.position, Quaternion.identity);
                    Vector2 vec = L_D_Point.transform.position - pos;
                    vec.Normalize();
                    vec *= firstbulletspeed;
                    MiniMum.GetComponent<Rigidbody2D>().velocity = vec;
                    TimeI = 0f;
                }
                {
                    var pos = this.gameObject.transform.position;
                    GameObject prefab = (GameObject)Resources.Load("MniMum 1");
                    GameObject MiniMum = Instantiate(prefab, this.transform.position, Quaternion.identity);
                    Vector2 vec = R_Eria.transform.position - pos;
                    vec.Normalize();
                    vec *= firstbulletspeed;
                    MiniMum.GetComponent<Rigidbody2D>().velocity = vec;
                    TimeI = 0f;
                }
                {
                    var pos = this.gameObject.transform.position;
                    GameObject prefab = (GameObject)Resources.Load("MniMum 1");
                    GameObject MiniMum = Instantiate(prefab, this.transform.position, Quaternion.identity);
                    Vector2 vec = L_Eria.transform.position - pos;
                    vec.Normalize();
                    vec *= firstbulletspeed;
                    MiniMum.GetComponent<Rigidbody2D>().velocity = vec;
                    TimeI = 0f;
                }
            }
        }
        if (faze11 == true)
        {
            timeJ += Time.deltaTime;
            if (faze3Rate < timeJ)
            {
                for (int i = 0; i < 24; i++)
                {//裏面等角攻撃
                 // AutoTime = 0f;

                    // float ShotSpeed = 7;
                    Vector2 vec = Player.transform.position - transform.position;
                    vec.Normalize();
                    vec = Quaternion.Euler(0, 0, (360 / 24) * i) * vec;
                    vec *= faze3ShotSpeed;
                    var t = Instantiate(EnemyBullet_Type_2, transform.position, EnemyBullet_Type_2.transform.rotation);
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                    timeJ = 0f;

                }
                count++;
            }
        }
        if (faze12 == true)
        {
            timeK += Time.deltaTime;
            timeL += Time.deltaTime;
            if (1f < timeK)
            {

                {
                    float ShotSpeed = 3f;//弾速初速
                    var pos = this.gameObject.transform.position;
                    var t = Instantiate(Trident_bullet, this.transform.position, Quaternion.identity) as GameObject;
                    Vector2 vec = Trident_.transform.position - pos;
                    vec.Normalize();
                    vec *= ShotSpeed;
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                    timeK = 0f;
                }
                {
                    float ShotSpeed = 3f;//弾速初速
                    var pos = this.gameObject.transform.position;
                    var t = Instantiate(Trident_bullet, this.transform.position, Quaternion.identity) as GameObject;
                    Vector2 vec = Trident_L.transform.position - pos;
                    vec.Normalize();
                    vec *= ShotSpeed;
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                    timeK = 0f;
                }
                {
                    float ShotSpeed = 3f;//弾速初速
                    var pos = this.gameObject.transform.position;
                    var t = Instantiate(Trident_bullet, this.transform.position, Quaternion.identity) as GameObject;
                    Vector2 vec = Trident_R.transform.position - pos;
                    vec.Normalize();
                    vec *= ShotSpeed;
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                    timeK = 0f;
                }
                {
                    float ShotSpeed = 6f;//弾速初速
                    var pos = this.gameObject.transform.position;
                    var t = Instantiate(EnemyBullet_Type_2, this.transform.position, Quaternion.identity) as GameObject;
                    Vector2 vec = Player.transform.position - pos;
                    vec.Normalize();
                    vec *= ShotSpeed;
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                    timeK = 0f;
                }
                if (0.5f < timeL)
                {
                    {
                        float ShotSpeed = 3f;//弾速初速
                        var pos = this.gameObject.transform.position;
                        GameObject prefab = (GameObject)Resources.Load("MniMum 1");
                        GameObject MiniMum = Instantiate(prefab, this.transform.position, Quaternion.identity);
                        Vector2 vec = R_D_Point.transform.position - pos;
                        vec.Normalize();
                        vec *= ShotSpeed;
                        MiniMum.GetComponent<Rigidbody2D>().velocity = vec;
                        timeL = 0f;
                    }
                    {
                        float ShotSpeed = 3f;//弾速初速
                        var pos = this.gameObject.transform.position;
                        GameObject prefab = (GameObject)Resources.Load("MniMum 1");
                        GameObject MiniMum = Instantiate(prefab, this.transform.position, Quaternion.identity);
                        Vector2 vec = L_D_Point.transform.position - pos;
                        vec.Normalize();
                        vec *= ShotSpeed;
                        MiniMum.GetComponent<Rigidbody2D>().velocity = vec;
                        timeL = 0f;
                    }
                    {
                        float ShotSpeed = 3f;//弾速初速
                        var pos = this.gameObject.transform.position;
                        GameObject prefab = (GameObject)Resources.Load("MniMum 1");
                        GameObject MiniMum = Instantiate(prefab, this.transform.position, Quaternion.identity);
                        Vector2 vec = R_Eria.transform.position - pos;
                        vec.Normalize();
                        vec *= ShotSpeed;
                        MiniMum.GetComponent<Rigidbody2D>().velocity = vec;
                        timeL = 0f;
                    }
                    {
                        float ShotSpeed = 3f;//弾速初速
                        var pos = this.gameObject.transform.position;
                        GameObject prefab = (GameObject)Resources.Load("MniMum 1");
                        GameObject MiniMum = Instantiate(prefab, this.transform.position, Quaternion.identity);
                        Vector2 vec = L_Eria.transform.position - pos;
                        vec.Normalize();
                        vec *= ShotSpeed;
                        MiniMum.GetComponent<Rigidbody2D>().velocity = vec;
                        timeL = 0f;
                    }
                    if(Player_Move.hennkann == false)
                    {
                        var pos = this.gameObject.transform.position;
                        var t = Instantiate(EnemyBullet_Type_2, this.transform.position, Quaternion.identity) as GameObject;
                        Vector2 vec = Player.transform.position - pos;
                        vec.Normalize();
                        vec *= PopalPulalet;
                        t.GetComponent<Rigidbody2D>().velocity = vec;
                        timeL = 0f;
                    }
                    if (Player_Move.hennkann == true)
                    {
                        var pos = this.gameObject.transform.position;
                        var t = Instantiate(Bigboll_Red, this.transform.position, Quaternion.identity) as GameObject;
                        Vector2 vec = Player.transform.position - pos;
                        vec.Normalize();
                        vec *= PopalPulalet;
                        t.GetComponent<Rigidbody2D>().velocity = vec;
                        timeL = 0f;
                    }
                }
            }
        }
        if (faze13)
        {
            timeN += Time.deltaTime;
            timeP += Time.deltaTime;
            if (1f < timeN)
            {
                for (int i = 0; i < 24; i++)
                {//裏面等角攻撃
                 // AutoTime = 0f;

                    float ShotSpeed = 7;
                    Vector2 vec = Player.transform.position - transform.position;
                    vec.Normalize();
                    vec = Quaternion.Euler(0, 0, (360 / 24) * i) * vec;
                    vec *= ShotSpeed;
                    var t = Instantiate(EnemyBullet_Type_2, transform.position, EnemyBullet_Type_2.transform.rotation);
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                    timeN = 0f;

                }
                count++;
            }
            if (0.5f < timeP && Player_Move.hennkann == false)
            {
                var pos = this.gameObject.transform.position;
                var t = Instantiate(EnemyBullet_Type_2, this.transform.position, Quaternion.identity) as GameObject;
                Vector2 vec = Player.transform.position - pos;
                vec.Normalize();
                vec *= PopalPulalet;
                t.GetComponent<Rigidbody2D>().velocity = vec;
                timeP = 0f;
            }
            if (0.5f < timeP && Player_Move.hennkann == true)
            {
                var pos = this.gameObject.transform.position;
                var t = Instantiate(Bigboll_Red, this.transform.position, Quaternion.identity) as GameObject;
                Vector2 vec = Player.transform.position - pos;
                vec.Normalize();
                vec *= PopalPulalet;
                t.GetComponent<Rigidbody2D>().velocity = vec;
                timeP = 0f;
            }
        }
















        {
            if (Player_Move.hennkann == true && Triger == true)//裏
            {
                firstrate = 1.5f;
                faze3ShotSpeed = 3f;
                faze3Rate = 1f;
                PopalPulalet = 2.5f;
                Stels = true;
                // Debug.Log("裏になった");
                Triger = false;
                Dimensionmatter_sprite.sprite = Blue;
            }

            if (Player_Move.hennkann == false && Triger == false)//表
            {
                firstrate = 0.5f;
                faze3ShotSpeed = 6f;
                faze3Rate = 0.5f;
                PopalPulalet = 5;
                Stels = false;
                //  Debug.Log("表になった");
                Triger = true;
                Dimensionmatter_sprite.sprite = Red;
            }
            //死亡処理
            if (HpSlider.value == 0)
            {
                if (EFTriger == true)
                {
                    GameObject AE = (GameObject)Resources.Load("AerialExplode");
                    Instantiate(AE, this.transform.position, Quaternion.identity);
                    EFTriger = false;
                }

                Invoke("GameClear", 2);


            }
        }
    }
        void GameClear()
        {
            SceneManager.LoadScene("Gameclear");
            Destroy(this.gameObject);
        }
        void AudioPlay()
        {
            audio.Play();
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Player_Bullet")
            {
                HpSlider.value -= 1f;
            }
            if (collision.gameObject.tag == "URA_Player_Bullet")
            {
                HpSlider.value -= 1f;//裏での自機ダメージ
            }
        }
    }


