using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; // ȸ�� �ӵ�
    //Random random = new Random(); // ȸ�� �ӵ� ������
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
            //Debug.Log($"���콺 Ŭ�� �Է��� �ӵ���{rotSpeed}");
            velue++;
        }

        //ȸ���ӵ���ŭ �귿�� ȸ���Ѵ�.
        transform.Rotate(0, 0, rotSpeed);
        rotSpeed *= 0.96f;
        //Debug.Log($"���콺 Ŭ�� ������ �ӵ���{rotSpeed}");

        if (transform.rotation.eulerAngles.z > 330 && transform.rotation.eulerAngles.z <= 30)        
        {
            Debug.Log("�������");
        }
        else if (transform.rotation.eulerAngles.z > 30.0 && transform.rotation.eulerAngles.z <= 90)
        {
            Debug.Log("�������");
        }
        else if (transform.rotation.eulerAngles.z > 90 && transform.rotation.eulerAngles.z <= 150)
        {
            Debug.Log("����ſ쳪��");
        }
        else if (transform.rotation.eulerAngles.z > 150 && transform.rotation.eulerAngles.z <= 210)
        {
            Debug.Log("�������");
        }
        else if (transform.rotation.eulerAngles.z > 210 && transform.rotation.eulerAngles.z <= 270)
        {
            Debug.Log("�������");
        }
        else if (transform.rotation.eulerAngles.z > 270 && transform.rotation.eulerAngles.z <= 330)
        {
            Debug.Log("�������");
        }

    }
}
