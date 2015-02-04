using UnityEngine;
using System.Collections;

public class Parachute : MonoBehaviour {
	public LayerMask ground;
	public GameObject parachute;
	public int mydrag;
	Animator myAnimator;
	bool chuteopened;
	// Use this for initialization
	void Start () {
		myAnimator = GetComponent<Animator> ();
		mydrag = 6;
		parachute = GameObject.Find("Parachute/Sphere");
	}


	
	// Update is called once per frame
	void Update ()
	{
		Debug.DrawRay (this.transform.position, -transform.up * 4f, Color.green);
		if (!chuteopened)
		{
			if (Physics.Raycast (this.transform.position, -transform.up, 4f, ground)) {
				Openchute ();
			}
		}
	}

	void Openchute(){
		chuteopened = true;
		this.rigidbody.drag = mydrag;
		myAnimator.SetTrigger("Open");
	}

	void OnCollisionEnter(){
		myAnimator.SetTrigger ("Close");
	}
}
