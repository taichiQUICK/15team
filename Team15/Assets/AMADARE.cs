using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AMADARE : MonoBehaviour
{
    float timerate;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (BOSS_Reisame.AMADARE1 == true)
        {
            timerate += Time.deltaTime;
            if (0.5f < timerate)//0.10の弾幕インターバル
            {
                timerate = 0f;
                GameObject Player_Bullet = (GameObject)Resources.Load("Rein_2");
                Instantiate(Player_Bullet, this.transform.position, Quaternion.identity);
                //   Debug.Log("弾生成");
            }
        }
    }
}
