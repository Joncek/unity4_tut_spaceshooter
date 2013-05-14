using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	
	private Transform myTransform;
	
	public int projectileSpeed = 7;
	
	// Use this for initialization
	void Start () {
		// cache transform object
		myTransform = transform;		
	}
	
	// Update is called once per frame
	void Update () {
		
		// make the laser shoot out and go up
		// game object = laser = shoot up
		
		myTransform.Translate(Vector3.up * projectileSpeed * Time.deltaTime);	
		
		if(myTransform.position.y > 9) {
			DestroyObject(gameObject);			
			return;
		}
		
		
	}
}
