using UnityEngine;
using System.Collections;


public class BuildWall : MonoBehaviour {
	public Transform brick;

	int width=5;
	int height=5;

	// Use this for initialization
	void Start () {
		for (int j = 0; j < height; j++)
			for (int i = 0; i < width; i++)
				Instantiate (brick, new Vector3 ((-width/2 + i) * brick.transform.localScale.x, 
				                                 			 j  * brick.transform.localScale.x, 
				                                 			 transform.position.z),
				             Quaternion.identity);
				                              
	}
	
	// Update is called once per frame
	void Update () {
        

	}
}
