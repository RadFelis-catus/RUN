using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rigidbody2d;
    void Awake()

    {

        rigidbody2d = GetComponent<Rigidbody2D>();

    }
    public void Launch(Vector2 direction, float force)

    {

        rigidbody2d.AddForce(direction * force);

    }


    // Update is called once per frame
    void Update()
    {
        if (transform.position.magnitude > 1000.0f)

        {

            Destroy(gameObject);
            Debug.Log("Destroyed");

        }
    }
}
