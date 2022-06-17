using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MadSquareLeft : MonoBehaviour {

    public float speed;

    private Rigidbody2D sq;

    // Use this for initialization
    void Start () {

        sq = this.GetComponent<Rigidbody2D>();
        sq.velocity = Vector2.left * speed;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
