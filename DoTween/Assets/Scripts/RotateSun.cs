using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSun : MonoBehaviour
{
    public float duration;

    private void Start()
    {
        FirstHalfLoop();
    }
    public void FirstHalfLoop()
    {
        transform.DORotate(new Vector3(0, 180, 0), duration).SetEase(Ease.Linear).SetLoops(-1,LoopType.Incremental);
    }

   
}
