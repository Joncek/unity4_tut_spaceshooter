using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	
	private Transform myTransform;
	
	private int minSpeed = 2;
	private int maxSpeed = 5;
	private int currentSpeed;
	
	
	// Use this for initialization
	void Start () {
		
		// cache transform
		myTransform = transform;
	
		// random speed
		currentSpeed = Random.Range(minSpeed, maxSpeed);
		
		// position
		int xPos = Random.Range (-17, 17);
		myTransform.position = new Vector3(xPos, 9, -1);
	}
	
	// Update is called once per frame
	void Update () {
	
		myTransform.Translate(Vector3.down * currentSpeed * Time.deltaTime);
		
		if(myTransform.position.y < -5) {
			currentSpeed = Random.Range(minSpeed, maxSpeed);
			int xPos = Random.Range (-17, 17);
			myTransform.position = new Vector3(xPos, 9, -1);
		}
	}
}
