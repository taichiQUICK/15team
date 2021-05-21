using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class BOSS_Reisame : MonoBehaviour
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

    float faze3ShotSpeed = 6f;
    float faze3Rate = 0.5f;
    float faze8Rate = 2f;

    float timeA = 2f;
    float timeB = 2f;
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


    bool faze1 = false;
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


    bool EFTriger = true;
    bool DOTtriger = true;
    bool DOTtriger2 = true;
    bool DOTtriger3 = true;
    bool DOTtriger4 = true;
    bool DOTtriger5 = true;
    bool DOTtriger6 = true;
    bool DOTtriger7 = true;

    bool faze2Triger = true;

    public static bool GAZOTriger1 = true;

    public static bool faze9move = false;
    public static bool faze10move = false;
    public static bool trigertiger = false;
    public static bool trigertgier2 = false;
    public static bool trigertrgier3 = false;
    public static bool trigertrgier4 = false;
    public static bool AMADARE1 = false;

    public float firstbulletspeed;//3.5f;
    public float first_delayspeed;
    public float PopalPulalet;
    AudioSource audio;

    private float Blue_Samidare_Rate = 2f;
    private float Blue_Samidare_Speed = 3f;

    public Sprite Reisame_Blue_KASA_1;


    // static bool Fours Bullet = false
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        HpSlider.value = 3240;
        Player_Move.hennkann = false;
        Player_Move.uragaseikika = false;
        audio = this.GetComponent<AudioSource>();
        Invoke("AudioPlay", 0);

    }

    // Update is called once per frame
    void Update()
    {
        GameBossTime += Time.deltaTime;
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

        if (GameBossTime >= 2f && Triger1 == true)//ゲーム開始から二秒後に攻撃、
        {
            faze1 = true;
        }
        if (GameBossTime >= 15f && Triger2 == true)
        {
            Triger1 = false;
            faze1 = false;
            AMADARE1 = true;
            faze2 = true;
        }
        if (GameBossTime >= 20f && Triger3 == true)
        {
            Triger2 = false;
            faze2 = false;
            faze3 = true;
            AMADARE1 = false;
        }
        if (faze1 == true)
        {
            timeA += Time.deltaTime;

            if (Blue_Samidare_Rate < timeA)
            {
                for (int i = 0; i < 24; i++)
                {
                    // Debug.Log("あああ");   
                    Vector2 vec = Player.transform.position - transform.position;
                    vec.Normalize();
                    vec = Quaternion.Euler(0, 0, (360 / 24) * i) * vec;
                    vec *= Blue_Samidare_Speed;
                    var t = Instantiate(EnemyBullet_Type_1, transform.position, EnemyBullet_Type_1.transform.rotation);
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                    timeA = 0f;
                }
                count++;
            }
            if (DOTtriger == true)
            {
                var Sequence = DOTween.Sequence();

                Sequence.Append(this.transform.DOMove(new Vector3(-5f, 1.95f, 0f), 2.5f).SetEase(Ease.OutSine));
                Sequence.Append(this.transform.DOMove(new Vector3(-3.6f, 3.55f, 0f), 2.5f).SetEase(Ease.OutSine));
                Sequence.Append(this.transform.DOMove(new Vector3(-1.27f, 1.54f, 0f), 2.5f).SetEase(Ease.OutSine));
                Sequence.Append(this.transform.DOMove(new Vector3(-1.25f, 3.10f, 0f), 2.5f).SetEase(Ease.OutSine));
                Sequence.Append(this.transform.DOMove(new Vector3(-2.80f, 2.15f, 0f), 2.5f).SetEase(Ease.OutSine));
                DOTtriger = false;

                if (Blue_Samidare_Rate < timeA)
                {
                    for (int i = 0; i < 24; i++)
                    {
                        // Debug.Log("あああ");   
                        Vector2 vec = Player.transform.position - transform.position;
                        vec.Normalize();
                        vec = Quaternion.Euler(0, 0, (360 / 24) * i) * vec;
                        vec *= Blue_Samidare_Speed;
                        var t = Instantiate(EnemyBullet_Type_1, transform.position, EnemyBullet_Type_1.transform.rotation);
                        t.GetComponent<Rigidbody2D>().velocity = vec;
                        timeA = 0f;
                    }
                    count++;

                }
            }
        }
        if (faze2 == true)
        {
            timeC += Time.deltaTime;
            if (GAZOTriger1 == true)
            {
                //GameObject prefab1 = (GameObject)Resources.Load("Blue_KASA");
                //GameObject Blue_KASA = Instantiate(prefab1, this.transform.position, Quaternion.identity);
                //Dimensionmatter_sprite = gameObject.GetComponent<SpriteRenderer>();
                //Dimensionmatter_sprite.sprite = Reisame_Blue_KASA_1;

                GAZOTriger1 = false;
            }
            if (faze2Triger == true)
            {
                for (int i = 0; i < 24; i++)
                {
                    Vector2 vec = Player.transform.position - transform.position;
                    vec.Normalize();
                    vec = Quaternion.Euler(0, 0, (360 / 24) * i) * vec;
                    vec *= 1;
                    var t = Instantiate(EnemyBullet_Type_2, transform.position, EnemyBullet_Type_2.transform.rotation);
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                    faze2Triger = false;
                }
                count++;
            }
        }
        if (faze3 == true)
        {
            timeB += Time.deltaTime;
            var Sequence2 = DOTween.Sequence();
            if (DOTtriger2 == true)
            {
               
                Sequence2.Play();
                Sequence2.Append(this.transform.DOMove(new Vector3(-5, 2, 0), 2f).SetEase(Ease.OutSine));
                Sequence2.Append(this.transform.DOMove(new Vector3(0, 2, 0), 2f).SetEase(Ease.OutSine));
                Sequence2.Append(this.transform.DOMove(new Vector3(-2.32f, 0.21f, 0), 2f).SetEase(Ease.OutSine));
                DOTtriger2 = false;
            }
            if (Blue_Samidare_Rate < timeB)
                for (int i = 0; i < 24; i++)
                {
                    Vector2 vec = Player.transform.position - transform.position;
                    vec.Normalize();
                    vec = Quaternion.Euler(0, 0, (360 / 24) * i) * vec;
                    vec *= Blue_Samidare_Speed;
                    var t = Instantiate(EnemyBullet_Type_1, transform.position, EnemyBullet_Type_1.transform.rotation);
                    t.GetComponent<Rigidbody2D>().velocity = vec;
                    timeB = 0f;
                }
            count++;
        }
        {
            if (Player_Move.hennkann == true && Triger == true)//裏
            {
                Stels = true;
                // Debug.Log("裏になった");
                Triger = false;
                //   Dimensionmatter_sprite.sprite = Blue;
            }

            if (Player_Move.hennkann == false && Triger == false)//表
            {
                Stels = false;
                //  Debug.Log("表になった");
                Triger = true;
                //   Dimensionmatter_sprite.sprite = Red;
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



