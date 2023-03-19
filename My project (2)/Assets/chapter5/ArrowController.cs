using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;
    GameObject gameManager;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        gameManager = GameObject.Find("GameManager");

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.03f, 0);

        if(transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        // 충돌 판정
        Vector2 p1 = transform.position;
        Vector2 p2 = player.transform.position;
        Vector2 dir = p1 - p2;
        
        float d = dir.magnitude;

        float r1 = 0.5f;
        float r2 = 1.0f;

        if(d < r1 + r2)
        {
            player.GetComponent<CatController>().isBlink = true;
            gameManager.GetComponent<GameManager>().DecreaseHP();            
            Destroy(gameObject);
        }
    }
}
