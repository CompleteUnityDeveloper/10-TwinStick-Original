using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

	public bool tryingToGrab = false;
	public bool isGrabbing = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (CrossPlatformInputManager.GetButton ("Fire3")) {
			tryingToGrab = true;
		} else {
			tryingToGrab = false;
			isGrabbing = false;
		}
	}

	void OnCollisionEnter (Collision collision) {
		print (collision.gameObject.tag);
		if (tryingToGrab && collision.gameObject.tag == "Grabbable") {
			isGrabbing = true;
		}
	}

}
