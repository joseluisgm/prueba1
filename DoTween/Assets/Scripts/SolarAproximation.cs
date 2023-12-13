using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarAproximation : MonoBehaviour
{
    public float duration = 5;
    public GameObject nearTarget;
    public GameObject farTarget;
    public Ease easyTypeNear;
    public Ease easyTypeFar;


    private void Start()
    {
        Near();
    }

    public void Near()
    {
     transform.DOLocalMove(farTarget.transform.localPosition,duration,false).SetEase(easyTypeNear).OnComplete(Far);
    }

    public void Far()
    {
        transform.DOLocalMove(nearTarget.transform.localPosition, duration, false).SetEase(easyTypeFar).OnComplete(Near);

    }
}
