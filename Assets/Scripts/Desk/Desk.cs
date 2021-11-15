using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Desk : MonoBehaviour
{
    public Transform cubeTransform;
    public float zaman;
    public Ease ease;

    void Start()
    {
        cubeTransform
            .DOScaleX(2.15f,zaman)
            .SetEase(ease)
            .SetLoops(-1, LoopType.Yoyo);

        cubeTransform
            .DOScaleZ(2.15f, zaman)
            .SetEase(ease)
            .SetLoops(-1, LoopType.Yoyo);
    }

}
