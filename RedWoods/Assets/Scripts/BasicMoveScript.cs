using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMoveScript : MonoBehaviour {

    Rigidbody2D rb;
    bool inMenu = false;         // player movement is inactive when in menus

    public float speed;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void Update() { }


    void FixedUpdate() { 
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        if (!inMenu)
        {
            Vector2 velocity = new Vector2(horizontalMove, verticalMove) * speed * Time.deltaTime;
            rb.velocity = velocity;
        }

    }
}
