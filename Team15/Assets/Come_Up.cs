﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Come_Up : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.DOMove(new Vector2(-2.8f, 5f),10f).SetEase(Ease.OutCirc);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
