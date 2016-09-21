using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    public bool mobile = false;
    public float speed = 100;
    private bool locked;
	// Use this for initialization
	void Start () {
        locked = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!locked)
        {
            if (!mobile)
            {
                float horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
                float vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
                transform.Translate(horizontal, vertical, 0);
            }
            else
            {
                float horizontal = Input.GetAccelerationEvent(0).acceleration.x * speed * Time.deltaTime;
                float vertical = Input.GetAccelerationEvent(0).acceleration.y * speed * Time.deltaTime;
                transform.Translate(horizontal, vertical, 0);
            }
        }
	}
    public void lockMovement()
    {
        locked = true;
    }
    public void unlockMovement()
    {
        locked = false;
    }
}
