using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float velocidade;
	public GameObject PlayerUm;
	public GameObject PlayerDois;

	private Rigidbody2D rb1;
	private Rigidbody2D rb2;

	// Use this for initialization
	void Start () {
    	rb1 = PlayerUm.GetComponent<Rigidbody2D> ();
    	rb2 = PlayerDois.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	 void FixedUpdate (){
        rb1.velocity = new Vector2 (0, Input.GetAxis ("p1Vertical") * velocidade);
        rb2.velocity = new Vector2 (0, Input.GetAxis ("p2Vertical") * velocidade);
    }
	
}
