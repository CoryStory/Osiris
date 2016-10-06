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
                if (Input.GetTouch(0).phase == TouchPhase.Ended)
                {
                    Vector3 goTo = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);

                    while(Vector3.Distance(this.gameObject.transform.position, goTo) > 0f)
                    {
                        this.gameObject.transform.position = Vector3.Lerp(this.gameObject.transform.position, goTo, Time.deltaTime);
                    } 
                   
                }
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
