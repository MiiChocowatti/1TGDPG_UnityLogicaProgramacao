using System.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text textAir;
    [SerializeField] private Text textScore;

    public static int air;
    public static int score;
    public static bool inWater;
    void Start()
    {
        //textAir.fontSize = 10;

        air = 100;
        score = 0;
        StartCoroutine(Air());
    }

    IEnumerator Air()
    {
        if (inWater == true)
        {
            air--;
        }
        textAir.text = "Oxygen: " + air.ToString() + "%";
        yield return new WaitForSeconds(1f);
        StartCoroutine(Air());
    }
    private void Update()
    {
        textScore.text = "Score: " + score.ToString();
    }
}
