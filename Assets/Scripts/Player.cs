using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	private Transform myTransform;
	
	public int playerSpeed = 5;
	
	// Use this for initialization
	void Start () {
		
		myTransform = transform;
		
		// Spawn point
		myTransform.position = new Vector3(-3, -3, 1);
	
	}
	
	// Update is called once per frame
	void Update () {
	
		// move the player left and right
		myTransform.Translate(Vector3.right * playerSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
		
	}
}
