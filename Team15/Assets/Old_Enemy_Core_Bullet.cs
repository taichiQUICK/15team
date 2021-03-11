using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Old_Enemy_Core_Bullet : MonoBehaviour
{
    public GameObject EnemyBullet_Type_3;
    float baramakicount = 0;
    float baramakikannkakuTIme = 0;
    bool baramakiteisi = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //ハダ_Pause用、Time.timeScaleが0のとき返す
        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }
        if (Enemy_Core.baramakikougeki == true && baramakiteisi == true)
        {
            baramakicount += Time.deltaTime;
            baramakikannkakuTIme += Time.deltaTime;
            if (baramakikannkakuTIme > 0.3f)
            {
                float ShotSpeed = 6;
                Vector2 vec = new Vector2(0.0f, 1.0f);
                vec = Quaternion.Euler(0, 0, Random.Range(0.0f, 360.0f)) * vec;
                vec *= ShotSpeed;
                var q = Quaternion.Euler(0, 0, -Mathf.Atan2(vec.x, vec.y) * Mathf.Rad2Deg);
                var t = Instantiate(EnemyBullet_Type_3, transform.position, q);
                t.GetComponent<Rigidbody2D>().velocity = vec;
            }

        }
        if (baramakicount > 3f)
        {
            Debug.Log("ばらまきていし");
            baramakiteisi = false;
            baramakicount = 0;
        }

    }
}
