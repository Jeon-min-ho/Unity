using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowControllers : MonoBehaviour
{
    public float moveStep = 0.07f;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -moveStep, 0);

        if(transform.position.y < -7f)
        {
            Destroy(gameObject);
        }

        //충돌 판정
        Vector2 p1 = transform.position;
        Vector2 p2 = player.transform.position;
        Vector2 dir = p1 - p2;
        float distance = dir.magnitude;

        if(distance < p1 + p2)
        {
            Destroy(gameObject);
        }
    }
}
