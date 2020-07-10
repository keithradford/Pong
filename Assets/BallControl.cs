using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
	public Rigidbody2D rb2d;

	void GoBall(){
		int rand = Random.Range(0, 4);
		if(rand == 0){
			rb2d.velocity = new Vector2(5f, -5f);
		}
		else if(rand == 1){
			rb2d.velocity = new Vector2(-5f, -5f);
		}
		else if(rand == 2){
			rb2d.velocity = new Vector2(5f, 5f);
		}
		else{
			rb2d.velocity = new Vector2(-5f, 5f);
		}
	}

	void ResetBall(){
		rb2d.velocity = Vector2.zero;
		transform.position = Vector2.zero;
	}

	void RestartGame(){
		ResetBall();
		Invoke("GoBall", 1);
	}

	void OnCollisionEnter2D(Collision2D coll){
		if(coll.collider.CompareTag("Player")){
			Vector2 vel;
			vel.x = rb2d.velocity.x;
			vel.y = (rb2d.velocity.y / 2) + (coll.collider.attachedRigidbody.velocity.y / 3);
			rb2d.velocity = vel;
		}
	}

    // Start is called before the first frame update
    void Start()
    {
    	rb2d = GetComponent<Rigidbody2D>();
    	Invoke("GoBall", 2);
    }
}
