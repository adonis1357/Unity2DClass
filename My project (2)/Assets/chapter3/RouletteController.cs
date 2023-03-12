using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; // 회전 속도
    //Random random = new Random(); // 회전 속도 랜덤값
    // Start is called before the first frame update
    int velue = 0;
    //string vleue2 = "";
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rotSpeed = 10 + velue;
            //Debug.Log($"마우스 클릭 입력중 속도는{rotSpeed}");
            velue++;
        }

        //회전속도만큼 룰렛을 회전한다.
        transform.Rotate(0, 0, rotSpeed);
        rotSpeed *= 0.96f;
        //Debug.Log($"마우스 클릭 중지됨 속도는{rotSpeed}");

        if (transform.rotation.eulerAngles.z > 330 && transform.rotation.eulerAngles.z <= 30)        
        {
            Debug.Log("운수나쁨");
        }
        else if (transform.rotation.eulerAngles.z > 30.0 && transform.rotation.eulerAngles.z <= 90)
        {
            Debug.Log("운수대통");
        }
        else if (transform.rotation.eulerAngles.z > 90 && transform.rotation.eulerAngles.z <= 150)
        {
            Debug.Log("운수매우나쁨");
        }
        else if (transform.rotation.eulerAngles.z > 150 && transform.rotation.eulerAngles.z <= 210)
        {
            Debug.Log("운수보통");
        }
        else if (transform.rotation.eulerAngles.z > 210 && transform.rotation.eulerAngles.z <= 270)
        {
            Debug.Log("운수조심");
        }
        else if (transform.rotation.eulerAngles.z > 270 && transform.rotation.eulerAngles.z <= 330)
        {
            Debug.Log("운수좋음");
        }

    }
}
