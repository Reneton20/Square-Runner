using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*[System.Serializable]
public class Bound
{
    public float aMin, aMax, bMin, bMax;
}*/

public class SquareMove : MonoBehaviour
{

    public float speed;
    // public Bound boundary;

    private Rigidbody2D rd;

    // Use this for initialization
    void Start()
    {

        rd = this.GetComponent<Rigidbody2D>();

    }

    //Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rd.velocity = movement * speed;

        //  rd.position = new Vector2(Mathf.Clamp(rd.position.x, boundary.aMin, boundary.aMax), Mathf.Clamp(rd.position.y, boundary.bMin, boundary.bMax));
    }
}
