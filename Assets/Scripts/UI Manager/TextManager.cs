using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TextManager : MonoBehaviour
{

    [SerializeField] private Text score_text;



    void Start()
    {
        score_text.text = FindObjectOfType<ScoreManager>().score.ToString();
    }

    void Update()
    {
        score_text.text = FindObjectOfType<ScoreManager>().score.ToString();
    }
}
