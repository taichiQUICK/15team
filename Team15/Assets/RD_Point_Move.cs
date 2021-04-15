using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class RD_Point_Move : MonoBehaviour
{
    bool Triger1 = true;
    bool Triger2 = true;
    // Start is called before the first frame update
    void Start()
    {
        Triger2 = true;
        Triger1 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Dimensionmatter.faze9move == true)
        {
            if(Triger1 == true)
            {
                this.transform.DOMove(new Vector3(-2.5f, -4.8f, 0f), 10f).SetEase(Ease.Linear);
                Triger1 = false;
            }
           
        }
        if(Dimensionmatter.faze10move == true)
        {
            if(Triger2 == true)
            {
                this.transform.DOMove(new Vector3(3, -4.8f, 0f), 10f).SetEase(Ease.Linear);
                Triger2 = false;
            }
        
        }
    }
}
