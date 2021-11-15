using UnityEngine;
using DG.Tweening;

public class ScoreManager : MonoBehaviour
{

    public float score = 0;

    public void On_Score_Incremantion(float incremantion)
    {
        score += incremantion;
    }


}
