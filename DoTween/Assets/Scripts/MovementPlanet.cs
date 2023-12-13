using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlanet : MonoBehaviour
{
    public Transform target;
    public float duration;
    public Ease esaeType;

    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.DOMove(target.position, duration).SetEase(esaeType);
    }
}
