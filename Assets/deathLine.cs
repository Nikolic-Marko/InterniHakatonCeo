using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class deathLine : MonoBehaviour
{
    public GameObject grudva;
    public float moveSpeed = 1f;
    private bool moveUp = true;
   void Update()
    {
        if (moveUp)
        {
            movePlatform();
        }
    }
    void movePlatform()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime, transform.position.z);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "player")
        {
            Destroy(col.gameObject);
        }
        
    }
   
}
