using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiderScript : MonoBehaviour
{

    public float speed;

    public bool vertical;

    public float changeTime = 3.0f;
    Rigidbody2D rigidbody2D;

    float timer;

    int direction = 1;
    bool broken = true;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

        timer = changeTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (!broken)

        {

            return;

        }
        timer -= Time.deltaTime;




        if (timer < 0)

        {

            direction = -direction;

            timer = changeTime;

        }
    }
    void FixedUpdate()
    {
        if (!broken)

        {

            return;

        }
        Vector2 position = rigidbody2D.position;



        if (vertical)

        {

            position.x = position.x + Time.deltaTime * speed * direction;

            

        }

        else

        {

            position.y = position.y + Time.deltaTime * speed * direction;

            

        }



        rigidbody2D.MovePosition(position);
    }
}
