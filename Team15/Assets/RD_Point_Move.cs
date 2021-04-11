using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class RD_Point_Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Dimensionmatter.faze9move == true)
        {
            this.transform.DOMove(new Vector3(-2.5f, -4.8f, 0f), 10f).SetEase(Ease.Linear);
        }
        if(Dimensionmatter.faze10move == true)
        {
            this.transform.DOMove(new Vector3(3, -4.8f, 0f), 10f).SetEase(Ease.Linear);
        }
    }
}
