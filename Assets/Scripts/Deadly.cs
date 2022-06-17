using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deadly : MonoBehaviour
{

    //   void OnCollisionEnter2D(Collider2D collision)
    // {
    //   Debug.Log("Collision!");
    //}


    // int health = 1;

    void OnTriggerEnter2D(Collider2D ass)
    {
        // Debug.Log("Trigger!");

        if (ass.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }

        //health--;

        // if (health <= 0)
        //{
        //  Die();
        //}
    }

    //void Die()
    //{
    //  Destroy(gameObject);
    //}
}
