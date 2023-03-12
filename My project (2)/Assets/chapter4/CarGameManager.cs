using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CarGameManager : MonoBehaviour
{
    CarController carController;

    GameObject car;
    GameObject flag;
    GameObject distanceText;
    GameObject resultText;
    string Result = "";
    public bool tf = true;
    // Start is called before the first frame update
    void Start()
    {
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        distanceText = GameObject.Find("Distance");
        resultText = GameObject.Find("Result");

        carController = car.GetComponent<CarController>();
    }

    // Update is called once per frame
    void Update()

    {
        if (tf)
        {
            if (carController.i >= 5)
            {
                Result = "lose";
                tf = false;
                resultText.GetComponent<TMP_Text>().text = "Result : " + Result;
            }

            float length = flag.transform.position.x - car.transform.position.x;
            distanceText.GetComponent<TMP_Text>().text = "Distance : " + length.ToString("F2") + "m";
            if (length <= 0.5f && length >= 0.0f)
            {
                Result = "win";
                tf = false;
                resultText.GetComponent<TMP_Text>().text = "Result : " + Result;
                //Debug.Log("win");            
            }
            if (length < 0)
            {
                Result = "lose";
                tf = false;
                resultText.GetComponent<TMP_Text>().text = "Result : " + Result;
                //Debug.Log("lose");
            }
        }
    }
}
