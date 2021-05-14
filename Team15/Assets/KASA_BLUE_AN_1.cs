using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class KASA_BLUE_AN_1 : MonoBehaviour
{
    bool activetriger1 = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (BOSS_Reisame.GAZOTriger1 == true && activetriger1 == true)
        {
            gameObject.SetActive(true);
            transform.DOLocalRotate(new Vector3(0, 0, 360f), 0.1f, RotateMode.FastBeyond360)
      .SetEase(Ease.Linear);
            activetriger1 = false;
        }
        if(BOSS_Reisame.GAZOTriger1 == false)
        {
            gameObject.SetActive(false);
        }
    }
}
