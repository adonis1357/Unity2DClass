using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; // ȸ�� �ӵ�
    //Random random = new Random(); // ȸ�� �ӵ� ������
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
            //Debug.Log($"���콺 Ŭ�� �Է��� �ӵ���{rotSpeed}");
            velue++;
            
            Invoke("LoadNextScene", 2f); // n�� �Ŀ� ������ ����
            isInputCheck = true;
        }

        //ȸ���ӵ���ŭ �귿�� ȸ���Ѵ�.
        transform.Rotate(0, 0, rotSpeed);
        rotSpeed *= 0.96f;
        //Debug.Log($"���콺 Ŭ�� ������ �ӵ���{rotSpeed}");

        if(rotSpeed < 0.001f && isInputCheck)
        {
            if (transform.rotation.eulerAngles.z > 330 && transform.rotation.eulerAngles.z <= 30)
            {
                Debug.Log("�������");
                CarCount = 2;
            }
            else if (transform.rotation.eulerAngles.z > 30.0 && transform.rotation.eulerAngles.z <= 90)
            {
                Debug.Log("�������");
                CarCount = 6;
            }
            else if (transform.rotation.eulerAngles.z > 90 && transform.rotation.eulerAngles.z <= 150)
            {
                Debug.Log("����ſ쳪��");
                CarCount = 1;
            }
            else if (transform.rotation.eulerAngles.z > 150 && transform.rotation.eulerAngles.z <= 210)
            {
                Debug.Log("�������");
                CarCount = 4;
            }
            else if (transform.rotation.eulerAngles.z > 210 && transform.rotation.eulerAngles.z <= 270)
            {
                Debug.Log("�������");
                CarCount = 3;
            }
            else
            {
                Debug.Log("�������");
                CarCount = 5;
            }
            isRouletteTime = false;
        }
    }
    void LoadNextScene()
    {
        // ���� ������ �̵��մϴ�.
        SceneManager.LoadScene("CarGame");
    }
}
