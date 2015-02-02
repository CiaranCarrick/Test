using UnityEngine;
using System.Collections;

public class fizz1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	void swap(){
		int a = 132;
		int b = 1223;

		a = a - a;
		a = b+a;
		print (a);
	}

	void fizz(){
		for (int i = 1; i <= 100; i++)
		{
			if(i % 3 == 0 && i % 5 == 0){
				Debug.Log("FizzBuzz");
			}
			else if(i % 3 == 0){
				Debug.Log("Fizz");
			}
			else if(i % 5 == 0){
				Debug.Log("Buzz");
			}
			else
				Debug.Log(i);
		}

	}
	
	// Update is called once per frame
	void Update () {

		
	}
}
