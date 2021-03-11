using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Core_Bullet : MonoBehaviour
{
    public GameObject EnemyBullet_Type_2;
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
        if (Enemy_Core.baramakikougeki == true)
        {
            // float Baramaki5count = 0;
            // Baramaki5count += Time.deltaTime;
            // Baramaki5count = 0f;

            float ShotSpeed = 6;
            Vector2 vec = new Vector2(0.0f, 1.0f);
            vec = Quaternion.Euler(0, 0, Random.Range(0.0f, 360.0f)) * vec;
            vec *= ShotSpeed;
            var q = Quaternion.Euler(0, 0, -Mathf.Atan2(vec.x, vec.y) * Mathf.Rad2Deg);
            var t = Instantiate(EnemyBullet_Type_2, transform.position, q);
            t.GetComponent<Rigidbody2D>().velocity = vec;
          //  Enemy_Core.baramakikougeki = false;
                Debug.Log("ばらまき");         
        }
        
    }
}
