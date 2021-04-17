using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class LD_Point_move : MonoBehaviour
{
    bool Triger1 = true;
    bool Triger2 = true;
    // Start is called before the first frame update
    void Start()
    {
      //  Triger1 = true;
//Triger2 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Dimensionmatter.faze9move == true &&Dimensionmatter.trigertiger == true)
        {
            if(Triger1 == true)
            {
                this.transform.DOMove(new Vector3(-3, -4.8f, 0f), 10f).SetEase(Ease.Linear);
                Dimensionmatter.trigertiger = false;
              // Triger1 = false;
            }

        }
        if (Dimensionmatter.faze10move == true && Dimensionmatter.trigertgier2 == true)
        {
            if(Triger2 == true)
            {
                this.transform.DOMove(new Vector3(-8.2f, -4.8f, 0f), 10f).SetEase(Ease.Linear);
                Dimensionmatter.trigertgier2 = false;
             //  Triger2 = false;
            }
        
        }
    }
}
