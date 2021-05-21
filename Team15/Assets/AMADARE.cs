using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AMADARE : MonoBehaviour
{
    float timerate = 0f;
    float clitetime = 0f;

    public GameObject AMADARE_1_1;
    public GameObject ReinBR;
     bool rateswth;
    bool triger1 = true;
    bool triger2 = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (BOSS_Reisame.AMADARE1 == true )
        {
            timerate += Time.deltaTime;
            clitetime += Time.deltaTime;
            if (0.65f < clitetime)
            {
                float ShotSpeed = 2f;//弾速初速
                var pos = this.gameObject.transform.position;
                var t = Instantiate(ReinBR, this.transform.position, Quaternion.identity) as GameObject;
                Vector2 vec = AMADARE_1_1.transform.position - pos;
                vec.Normalize();
                vec *= ShotSpeed;
                t.GetComponent<Rigidbody2D>().velocity = vec;
                clitetime = 0f;
            }
        }   
        }
}
