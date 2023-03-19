using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float scorePerSecond = 1.0f / 60;
    private float score = 0.0f;

    GameObject scoerText;
    GameObject hpGauage;
    // Start is called before the first frame update
    void Start()
    {
        scoerText = GameObject.Find("score");
        hpGauage = GameObject.Find("hpGauage");
    }

    void Update()
    {
        score += scorePerSecond;
        scoerText.GetComponent<TMP_Text>().text = "scoer : " + score;
    }

        public void DecreaseHP()
    {
        hpGauage.GetComponent<Image>().fillAmount -= 0.25f;        
    }
}
