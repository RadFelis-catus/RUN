using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TombScript : MonoBehaviour

    
{
    public GameObject projectilePrefab;
    public float fireDelay = 2f;
    private float timeSinceLastShot = 0f;
    Vector2 lookDirection = new Vector2(1, 0);
    Rigidbody2D rigidbody2d;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastShot += Time.deltaTime;
        if(timeSinceLastShot>= fireDelay)
        {
        Launch();
            timeSinceLastShot = 0f;
        }
        
    }
    void Launch()

    {
        Debug.Log("Instantiated");
        GameObject projectileObject = Instantiate(projectilePrefab, rigidbody2d.position + Vector2.up * 0.5f, Quaternion.identity);




        Projectile projectile = projectileObject.GetComponent<Projectile>();

        projectile.Launch(-lookDirection, 300);

        


   
    }

}
