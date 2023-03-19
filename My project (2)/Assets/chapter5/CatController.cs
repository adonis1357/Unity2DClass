using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    float time = 0;
    bool isOn = false;
    public bool isBlink = false;
    int blinkcount = 0;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        //if(Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    transform.Translate(-3, 0, 0);
        //}
        //if(Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    transform.Translate(3, 0, 0);
        //}
        if (isBlink)
        {
            time += Time.deltaTime;
            if (time > 0.2f)
            {
                time = 0;
                spriteRenderer.enabled = isOn;
                isOn = !isOn;
                blinkcount++;
            }

            if (blinkcount > 5)
            {
                isBlink = false;
                time = 0;
                isOn = false;
                blinkcount = 0;
            }
        }

        if (!isBlink)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-0.03f, 0, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(0.03f, 0, 0);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(0, 0.03f, 0);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(0, -0.03f, 0);
            }
        }
        
    }

    public void LButtonDown()
    {
        transform.Translate(-0.03f, 0, 0);
    }

    public void RButtonDown()
    {
        transform.Translate(0.03f, 0, 0);
    }


}
