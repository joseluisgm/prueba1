using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunExpan : MonoBehaviour
{
   public static SunExpan instance;
    public float duraion;
    public int vibrate = 0;
    public float elasticy;
    private int count = 3;


    private void Awake()
    {
        instance = this;

    }
    private void Start()
    {
        float penisSize = 100000;
        transform.DOPunchScale(transform.localScale * count, duraion, vibrate, elasticy).OnComplete(Start);
    }
    public float GetDuration()
    {
        return duraion;
    }
}
