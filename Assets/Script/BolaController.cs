using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaController : MonoBehaviour {

	private Rigidbody2D rb2D;

	public float x;
	public float y;

	public bool jogando;
	public int PontosP1;
	public int PontosP2;

	private GameManager GMS;

	// Use this for initialization
	void Start () {

		rb2D = GetComponent<Rigidbody2D>();
		GMS = GameObject.Find ("GameManager").GetComponent<GameManager> ();


		x = Random.Range( -12f, 12f);
		y = Random.Range( -12f, 12f);

		rb2D.velocity = new Vector2(x, y);
		
	}
	
	// Update is called once per frame
    void Update () {
        if (jogando == true) {
        if (rb2D.velocity.x < 12f && rb2D.velocity.x > -12f) {
        if (rb2D.velocity.x >= 0) {
        rb2D.velocity = new Vector2 (12f, rb2D.velocity.y);
        } else {
    	 rb2D.velocity = new Vector2 (-12f, rb2D.velocity.y);
        }
        	}
			
 
        if (rb2D.velocity.y < 12f && rb2D.velocity.y > -12f) {
        if (rb2D.velocity.y >= 0) {
        rb2D.velocity = new Vector2 (rb2D.velocity.x, 12f);
        } else {
        rb2D.velocity = new Vector2 (rb2D.velocity.x, -12f);
        } 
        	}
            	}
 
    	if(Input.GetKeyDown(KeyCode.Space) && jogando == false){
            Start ();
    	}
        	}
        void OnTriggerEnter2D(Collider2D outro){
            if (outro.gameObject.tag == "ParedeDir") {
             rb2D.velocity = Vector2.zero;
             transform.position = new Vector3(0,0,0);
             jogando = false;
			 GMS.pontuacao2 += 1;
			 }
            if (outro.gameObject.tag == "ParedeEsq") {
            rb2D.velocity = Vector2.zero;
            transform.position = new Vector3(0,0,0);
            jogando = false;
			GMS.pontuacao1 += 1;

        }
    }
}
