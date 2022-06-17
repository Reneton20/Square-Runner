using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MadSquareMovement : MonoBehaviour {

    public float speed;

    private Rigidbody2D sq;

	// Use this for initialization
	void Start () {


        sq = this.GetComponent<Rigidbody2D>();
        sq.velocity = Vector2.right * speed;

    }
	
	// Update is called once per frame
	void Update () {

        //sq.velocity = Vector2.right * speed;

    }
}
