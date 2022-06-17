using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{



   public int health = 1;
    public AudioClip aclip;
    public AudioSource sclip;

    //public Camera first;
    //public Camera death;

     void Start()
    {
        sclip.clip = aclip;
    }



    void OnTriggerEnter2D(Collider2D bb)
    {
        Debug.Log("Trigger!");

        if (bb.gameObject.tag == "Enemy")

        {

            health--;
            // Destroy(this.gameObject);
            
           
        }

    }

   void Update()
    {
        if (health <= 0)
        {
            Die();
        }
    }


    void Die()
    {
        gameObject.SetActive(false);
        sclip.Play();
    }
}