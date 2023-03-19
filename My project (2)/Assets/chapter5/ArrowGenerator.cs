using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject ArrowPrefab;
    float span = 1.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            GameObject go = Instantiate(ArrowPrefab);

            int px = Random.Range(-6, 7);

            // 3 수치만큼 떨어지게 수정
            //if (px < -4.5) 
            //{
            //    px = -6;
            //}
            //else if (px >= -4.5 && px < -1.5)
            //{
            //    px = -3;
            //}
            //else if (px >= -1.5 && px < 1.5)
            //{
            //    px = 0;
            //}
            //else if (px >= 1.5 && px < 4.5)
            //{
            //    px = 3;
            //}
            //else
            //{
            //    px = 6;
            //}
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
