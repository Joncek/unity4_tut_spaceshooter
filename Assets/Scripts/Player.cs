using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	private Transform myTransform;
	private Transform movePlayer;
	private int screenWidth; 
	private int screenHeight;
	
	public int playerSpeed = 5;
	
	// Variable to reference prefab. prefab = (reusable) gameobject
	public GameObject ProjectileFab;
	
	// Use this for initialization
	void Start () {
		
		screenWidth = Screen.width;
		screenHeight = Screen.height;
		Debug.Log("Screen: " + screenWidth + "x" + screenHeight, this);
		
		// cache transform
		myTransform = transform;
		
		// Spawn point
		myTransform.position = new Vector3(-3, -3, 1);
	
	}
	
	// Update is called once per frame
	void Update () {
	
		// move the player left and right
		myTransform.Translate(Vector3.right * playerSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
	
		// player wrap at the edges
		if(myTransform.position.x < -17) {
			myTransform.position = new Vector3(17, myTransform.position.y, myTransform.position.z);
		} else if (myTransform.position.x > 17) {
			myTransform.position = new Vector3(-17, myTransform.position.y, myTransform.position.z);
		}
		
		// press space bar to fire a laser
		if(Input.GetKeyDown(KeyCode.Space)) {
			Vector3 position = new Vector3(myTransform.position.x, myTransform.position.y +1, myTransform.position.z);		
			Debug.Log(position);
			Instantiate(ProjectileFab, position, Quaternion.identity);
		}
	}
}
