using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed = 3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis ("Horizontal") * speed;
		float vertical = Input.GetAxis ("Vertical") * speed;
		transform.Translate (horizontal, vertical, 0);
	}
}
