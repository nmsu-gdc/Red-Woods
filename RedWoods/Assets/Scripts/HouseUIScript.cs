using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseUIScript : MonoBehaviour {

    
    public GameObject shopCanvas;// =  GameObject.FindGameObjectWithTag("ShopCanvas");
    GameObject player;
    BasicMoveScript playerScript;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        //shopCanvas = GameObject.FindGameObjectWithTag("ShopCanvas");
        shopCanvas.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Interact")) Debug.Log("Interact detected");

	}

    

    void OnCollisionStay2D( Collision2D c ) {
        
        if ( c.gameObject.tag == "Player" &&  Input.GetButtonDown("Interact")) {
            Debug.Log("Launcha da menu");
            shopCanvas.SetActive(true);
        }

    }

}
