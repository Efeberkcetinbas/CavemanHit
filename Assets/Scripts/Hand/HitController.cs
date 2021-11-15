using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HitController : MonoBehaviour
{

    Sequence seq;
    Ray ray;
    RaycastHit hit;
    
    [Header("Rotation Controller")]
    [SerializeField] private float rotation_x;
    [SerializeField] private float rotation_y;
    [SerializeField] private float rotation_z;
    [SerializeField] private float rotation_Old_x;
    [SerializeField] private float rotation_Old_y;
    [SerializeField] private float rotation_Old_z;
    [SerializeField] private float rotation_Time;

    [SerializeField] private GameObject Head;

    public Camera camera;
    [SerializeField] private float camera_time;

    public int id;


    void Start()
    {
        
    }

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray,out hit))
        {

            if (Input.GetMouseButtonDown(0))
            {
                if (hit.collider.gameObject==Head)
                {
                    if (this.id == FindObjectOfType<GameManager>().id)
                    {
                        seq = DOTween.Sequence();
                        seq.AppendInterval(.2f);
                        //seq.Append(transform.DOScaleY(3f, .2f));
                        seq.Append(transform.DORotate(new Vector3(rotation_x, rotation_y, rotation_z), rotation_Time).OnComplete(() => transform.DORotate(new Vector3(rotation_Old_x, rotation_Old_y, rotation_Old_z), rotation_Time)));
                        //FindObjectOfType<AudionManager>().Play_Sound("WoodHit");
                        seq.Join(camera.transform.DOMoveZ(-24, camera_time).OnComplete(() => camera.transform.DOMoveZ(-25f, 0.5f)));
                        FindObjectOfType<AudionManager>().Play_Sound("CavemanHit");
                        //seq.AppendInterval(.2f);
                        //seq.Append(transform.DOScaleY(2, .2f));
                        /*seq.AppendInterval(.5f);
                        seq.Append(transform.DOShakeScale(.2f, 1f, 10, 90f, true));*/
                    }

                    else
                    {
                        Debug.Log("GAME OVER");
                    }
                }
            }
        }
    }
}
