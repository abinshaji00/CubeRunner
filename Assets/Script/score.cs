using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
  //  public Transform player;
    public Text scoreText;
    public float Score;
    void Update()
    {
        Score+=Score;
        scoreText.text= Score.ToString("0");
    }
}
