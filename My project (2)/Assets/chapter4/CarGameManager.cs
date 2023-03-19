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
        if (tf && carController.speed == 0)
        {

            float length = flag.transform.position.x - car.transform.position.x;
            distanceText.GetComponent<TMP_Text>().text = "Distance : " + length.ToString("F2") + "m";
            if((RouletteController.CarCount - carController.i) > 0)
            {
                resultText.GetComponent<TMP_Text>().text = "Count : " + (RouletteController.CarCount - carController.i);
            }
            
            if (length <= 1.5f && length >= -1.5f)
            {
                Result = "win";
                tf = false;
                resultText.GetComponent<TMP_Text>().text = "Result : " + Result;
                //Debug.Log("win");
            }
            else if (length < -1.5)
            {
                Result = "lose";
                tf = false;
                resultText.GetComponent<TMP_Text>().text = "Result : " + Result;
                //Debug.Log("lose");
            }

            else if (carController.i >= RouletteController.CarCount)
            {
                Result = "lose";
                tf = false;
                resultText.GetComponent<TMP_Text>().text = "Result : " + Result;
            }
        }
    }
}
