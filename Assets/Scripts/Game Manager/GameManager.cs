using DG.Tweening;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int random_number;

    [Header("Hit Boolean")]
    public bool hit_1;
    public bool hit_2;
    public bool hit_3;
    public bool hit_4;

    [Header("ID")]
    public int id;


    [Header("Mesh Renderers")]
    public MeshRenderer mr_1;
    public MeshRenderer mr_2;
    public MeshRenderer mr_3;
    public float duration;
        


    [Header("Time")]
    public float timer;
    private float starting_time;


  


    void Start()
    {
        random_number = Random.Range(0, 211);
        starting_time = timer;
    }

    void Update()
    {
        Selection();
        Timer_Counter();
    }

    private float Timer_Counter()
    {

        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Random_Number_Generator();
            timer = starting_time;
        }

        return timer;
    }

   

    public void Random_Number_Generator()
    {
        random_number = Random.Range(0, 211);
    }

    public int Selection()
    {
        if (random_number > 0)
        {
            if (random_number <= 50)
            {
                mr_1.material.DOColor(Color.green, duration);
                mr_2.material.DOColor(Color.yellow, duration);
                mr_3.material.DOColor(Color.yellow, duration);

                hit_1 = true;
                hit_2 = false;
                hit_3 = false;
                hit_4 = false;

                return id =1;
            }
        }

        if (random_number > 50)
        {
            if (random_number <= 70)
            {

                mr_1.material.DOColor(Color.red, duration);
                mr_2.material.DOColor(Color.yellow, duration);
                mr_3.material.DOColor(Color.yellow, duration);


                hit_1 = false;
                hit_2 = false;
                hit_3 = false;
                hit_4 = false;

                return id = 0;
            }
        }

        if (random_number > 70)
        {
            if (random_number <= 120)
            {

                mr_1.material.DOColor(Color.yellow, duration);
                mr_2.material.DOColor(Color.green, duration);
                mr_3.material.DOColor(Color.yellow, duration);

                hit_1 = false;
                hit_2 = true;
                hit_3 = false;
                hit_4 = false;

                return id=2;
            }
        }

        if (random_number > 120)
        {
            if (random_number <= 140)
            {
                mr_1.material.DOColor(Color.yellow, duration);
                mr_2.material.DOColor(Color.red, duration);
                mr_3.material.DOColor(Color.yellow, duration);

                hit_1 = false;
                hit_2 = false;
                hit_3 = false;
                hit_4 = false;

                return id = 0;
            }
        }

        if (random_number > 140)
        {
            if (random_number <= 190)
            {
                mr_1.material.DOColor(Color.yellow, duration);
                mr_2.material.DOColor(Color.yellow, duration);
                mr_3.material.DOColor(Color.green, duration);


                hit_1 = false;
                hit_2 = false;
                hit_3 = true;
                hit_4 = false;

                return id=3;
            }
        }

        if (random_number > 190)
        {
            if (random_number <= 210)
            {
                mr_1.material.DOColor(Color.yellow, duration);
                mr_2.material.DOColor(Color.yellow, duration);
                mr_3.material.DOColor(Color.red, duration);


                hit_1 = false;
                hit_2 = false;
                hit_3 = false;
                hit_4 = false;

                return id = 0;
            }
        }

        // Bunu 1,2,3,4 oyuncu olduğunda vur vurma şeklinde olacağı için 1'den 200'e kadar sayı tutarsın. Her 25 sayıda bir 1 vur ya da vurma 2 vur ya da vurma şeklinde ilerlersin.
        // Bunu Design Patternler ile yapmayı dene. State veya Strategy Design Pattern.
        // ID ile vurup vuramacağını kontrol edebilirsin.
        // State Design Pattern : Allow an object to alter its behaviour when its internal state changes. The object will appear to change its class.


        return random_number;
    }
}
