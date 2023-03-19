using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    CarGameManager carGameManager;
    public float speed = 0;
    Vector2 startPos;

    public float lenght;

    public int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        carGameManager = GetComponent<CarGameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (carGameManager.tf)
        {
            if (Input.GetMouseButtonDown(0) && speed == 0)
            {
                Debug.Log(speed);
                startPos = Input.mousePosition;
            }
            else if (Input.GetMouseButtonUp(0) && speed == 0)
            {
                Debug.Log(speed);
                Vector2 endPos = Input.mousePosition;
                lenght = endPos.x - startPos.x;                
                speed = lenght / 1000.0f;

                GetComponent<AudioSource>().Play();
                i++;
            }
        }
        transform.Translate(speed, 0, 0);
        speed *= 0.98f;
        if (Mathf.Abs(speed) < 0.01f)
        {
            speed = 0;
        }
    }
}

