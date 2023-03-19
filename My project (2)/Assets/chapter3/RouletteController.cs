using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; // 회전 속도
    //Random random = new Random(); // 회전 속도 랜덤값
    // Start is called before the first frame update
    int velue = 0;
    public static int CarCount = 0;

    bool isRouletteTime = false;
    bool isInputCheck = false;
    //string vleue2 = "";

    void Start()
    {
        isRouletteTime = true;
    }


    // Update is called once per frame
    void Update()
    {
        if(!isRouletteTime)
        {
            return;
        }

        if (Input.GetMouseButton(0))
        {
            rotSpeed = 10 + velue;
            //Debug.Log($"마우스 클릭 입력중 속도는{rotSpeed}");
            velue++;
            
            Invoke("LoadNextScene", 2f); // n초 후에 다음을 실행
            isInputCheck = true;
        }

        //회전속도만큼 룰렛을 회전한다.
        transform.Rotate(0, 0, rotSpeed);
        rotSpeed *= 0.96f;
        //Debug.Log($"마우스 클릭 중지됨 속도는{rotSpeed}");

        if(rotSpeed < 0.001f && isInputCheck)
        {
            if (transform.rotation.eulerAngles.z > 330 && transform.rotation.eulerAngles.z <= 30)
            {
                Debug.Log("운수나쁨");
                CarCount = 2;
            }
            else if (transform.rotation.eulerAngles.z > 30.0 && transform.rotation.eulerAngles.z <= 90)
            {
                Debug.Log("운수대통");
                CarCount = 6;
            }
            else if (transform.rotation.eulerAngles.z > 90 && transform.rotation.eulerAngles.z <= 150)
            {
                Debug.Log("운수매우나쁨");
                CarCount = 1;
            }
            else if (transform.rotation.eulerAngles.z > 150 && transform.rotation.eulerAngles.z <= 210)
            {
                Debug.Log("운수보통");
                CarCount = 4;
            }
            else if (transform.rotation.eulerAngles.z > 210 && transform.rotation.eulerAngles.z <= 270)
            {
                Debug.Log("운수조심");
                CarCount = 3;
            }
            else
            {
                Debug.Log("운수좋음");
                CarCount = 5;
            }
            isRouletteTime = false;
        }
    }
    void LoadNextScene()
    {
        // 다음 씬으로 이동합니다.
        SceneManager.LoadScene("CarGame");
    }
}
