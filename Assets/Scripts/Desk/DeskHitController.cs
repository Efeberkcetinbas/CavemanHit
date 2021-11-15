using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DeskHitController : MonoBehaviour
{

    Sequence seq;

    [SerializeField] private float Rotation_Time;


    public Camera camera;
    [SerializeField] private float camera_time;

    [SerializeField] private ParticleSystem sphere_effect;
    [SerializeField] private ParticleSystem boom_effect;

    private void Start()
    {
        sphere_effect.Stop();
        boom_effect.Stop();
      
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finger")
        {
            FindObjectOfType<AudionManager>().Play_Sound("WoodHit");
            seq = DOTween.Sequence();

            //seq.Join(camera.transform.DOMoveZ(-21, camera_time).OnComplete(() => camera.transform.DOMoveZ(-22f, 0.5f)));
            seq.AppendInterval(.2f);
            seq.Append(transform.DOScaleY(0.05f, Rotation_Time));
            seq.AppendInterval(.2f);
            seq.Append(transform.DOScaleY(0.1f, Rotation_Time));

            //BOOM HIT Effect
            //Camera Shaker
            //Score Effect and increase Score
            //Sound Effect
            Debug.Log("TOUCH THE STICK");
            Play_Particle_System();
            FindObjectOfType<ScoreManager>().On_Score_Incremantion(100);
            FindObjectOfType<RandomColors>().Set_Random_Color();
            FindObjectOfType<GameManager>().Random_Number_Generator();


        }
    }

    public void Play_Particle_System()
    {
        sphere_effect.Play();
        boom_effect.Play();
    }


}
