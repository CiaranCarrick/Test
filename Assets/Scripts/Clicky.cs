using UnityEngine;
using System.Collections;

public class Clicky : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) 
		{
			Ray ray= Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit whatihit;
			if(Physics.Raycast(ray, out whatihit))
			{
				Debug.Log("My name is "+ whatihit.collider.gameObject.name);
				Debug.Log(whatihit.point); //prints vector position
				GameObject ball=GameObject.CreatePrimitive(PrimitiveType.Sphere); //store sphere in ball
				Vector3 spawn = whatihit.point+Vector3.up; //spawn where we click
				GameObject ballclone = (GameObject) Instantiate(ball, spawn, transform.rotation);//create clone
				ballclone.AddComponent<Rigidbody>();//add component
				ballclone.rigidbody.AddForce(Vector3.up*100);//add force to spawned ball

			}
		}
	
	}
}
