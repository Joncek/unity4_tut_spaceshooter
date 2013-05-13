using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	
	private Transform myTransform;
	
	public int projectileSpeed = 0;
	
	// Use this for initialization
	void Start () {
	
		// cache transform object
		myTransform = transform;		
		myTransform.position = new Vector3(-3, -3, 1);
		
		renderer.enabled = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		// make the laser shoot out and go up
		// game object = laser = shoot up
		
		if(myTransform.position.y > 9) {
			DestroyObject(gameObject);			
			return;
		}
		
		if(Input.GetKey(KeyCode.Space)) {		
			renderer.enabled = true;
			projectileSpeed = 5;
		}	
		
		myTransform.Translate(Vector3.up * projectileSpeed * Time.deltaTime);	
	
	}
}
