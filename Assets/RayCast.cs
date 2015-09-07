using UnityEngine;
using System.Collections;

public class RayCast : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward*10, Color.red, 0, true);

	}
}
