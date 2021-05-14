using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class Reisame : MonoBehaviour
{
    public GameObject EnemyBullet_Type_1;
    public GameObject EnemyBullet_Type_2;
    public GameObject Bigboll_Red;
    public GameObject EnemyBullet_URABULU;
    public GameObject Trident_bullet;
    public static bool baramakikougeki = false;
    public GameObject Player;
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

        {
            if (Player_Move.hennkann == true && Triger == true)//裏
            {
                Stels = true;
                // Debug.Log("裏になった");
                Triger = false;
                Dimensionmatter_sprite.sprite = Blue;
            }

            if (Player_Move.hennkann == false && Triger == false)//表
            {
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


