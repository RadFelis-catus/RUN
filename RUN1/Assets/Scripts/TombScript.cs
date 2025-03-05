using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TombScript : MonoBehaviour

    
{
    public GameObject projectilePrefab;
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
        Launch();
    }
    void Launch()

    {
        Debug.Log("Instantiated");
        GameObject projectileObject = Instantiate(projectilePrefab, rigidbody2d.position + Vector2.up * 0.5f, Quaternion.identity);




        Projectile projectile = projectileObject.GetComponent<Projectile>();

        projectile.Launch(-lookDirection, 300);

        


   
    }

}
