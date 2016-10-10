using UnityEngine;
using System.Collections;

public class CameraBounds : MonoBehaviour {

	public RectTransform background;
	public Transform Player;
	Camera main;
	float maxX, minX, maxY, minY;

	// Use this for initialization
	void Start () {
		main = this.GetComponent<Camera> ();

		//sets min and max values of position of player based off of where the background is, + or - its size
		//and then divide that by 2 so it's just half for the max and so on
		//it also takes into account the size of the camera so that the camera won't see beyond the map and then just 
		//subtracts or adds that value to the player's position to create camera bounds
		maxX = (background.transform.position.x + background.sizeDelta.x / 2) - main.orthographicSize * main.aspect; //- main.orthographicSize * 2f;
		maxY = (background.transform.position.y + background.sizeDelta.y / 2) - main.orthographicSize; //- main.pixelHeight * 2f * main.aspect;
		minX = (background.transform.position.x - background.sizeDelta.x / 2) + main.orthographicSize * main.aspect;
		minY = (background.transform.position.y - background.sizeDelta.x / 2) + main.orthographicSize;

		//Debug.Log ("Height: " + main.orthographicSize * 2);
		//Debug.Log ("Width: " + main.orthographicSize * 2 * main.aspect);
		//Debug.Log ("maxX: " + maxX);
		//Debug.Log ("maxY: " + maxY);
	}
	
	// Update is called once per frame
	void Update () {
		
		//Updates player position with itself and the bounds defined above
		Vector3 location = Player.position;
		location.x = Mathf.Clamp (location.x, minX, maxX);
		location.y = Mathf.Clamp (location.y, minY, maxY);
		Player.position = location;
	}
}
