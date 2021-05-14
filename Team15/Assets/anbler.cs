using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class anbler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.DOLocalRotate(new Vector3(0, 0, 360f), 0.1f, RotateMode.FastBeyond360)
      .SetEase(Ease.Linear);
      //.SetLoops(-1, LoopType.Restart);
    }
}
