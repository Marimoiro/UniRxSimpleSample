using UnityEngine;
using System.Collections;

public class Base : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void Move (float dx,float dy) {
        gameObject.transform.position += new Vector3(dx, dy, 0);
	}
}
