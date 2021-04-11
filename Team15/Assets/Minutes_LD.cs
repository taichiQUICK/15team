using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minutes_LD : MonoBehaviour
{
    public GameObject EnemyBullet_Type_1;
    public GameObject L_D_Point;
    float timeA = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeA += Time.deltaTime;
        if (1f < timeA)
        {
            {
                float ShotSpeed = 5f;//弾速初速
                var pos = this.gameObject.transform.position;
                var t = Instantiate(EnemyBullet_Type_1, this.transform.position, Quaternion.identity) as GameObject;
                Vector2 vec = L_D_Point.transform.position - pos;
                vec.Normalize();
                vec *= ShotSpeed;
                t.GetComponent<Rigidbody2D>().velocity = vec;
                timeA = 0f;
            }
        }
    }
}
