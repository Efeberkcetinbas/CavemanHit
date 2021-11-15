using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RandomColors : MonoBehaviour
{
    Color c;

    [SerializeField]
    MeshRenderer mr;

    void Start()
    {
        //Animate();
    }

   /* void Animate()
    {
        c = GetRandomColor();
        mr.material
        .DOColor(c, 1)
        .OnComplete(Animate);
        
    }*/

    public void Set_Random_Color()
    {
        c = GetRandomColor();
        mr.material.DOColor(c, .2f);
    }

     Color GetRandomColor()
    {
        return new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
    }

}
