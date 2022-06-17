using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*[System.Serializable]
public class Bound
{
    public float aMin, aMax, bMin, bMax;
}*/

public class BallMoveRight : MonoBehaviour {

    public float speed;
    //public Bound boundary;

    private Rigidbody2D cr;



    // Use this for initialization
    void Start () {


        cr = this.GetComponent<Rigidbody2D>();
        cr.velocity = Vector2.right * speed;


    }

    // Update is called once per frame
    void FixedUpdate () {

       // cr.position = new Vector2(Mathf.Clamp(cr.position.x, boundary.aMin, boundary.aMax), Mathf.Clamp(cr.position.y, boundary.bMin, boundary.bMax));

    }
}
