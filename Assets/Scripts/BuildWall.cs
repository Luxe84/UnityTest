using UnityEngine;
using System.Collections;


public class BuildWall : MonoBehaviour {
	public Transform brick;

	public int width=5;
	public int height=5;

	// Use this for initialization
	void Start () {
		for (int j = 0; j < height; j++)
			for (int i = 0; i < width; i++) 
			{
				Transform newBrick;
				newBrick =  (Transform)Instantiate(brick, 
				                                   new Vector3((-width/2 + i)*brick.transform.localScale.x, 
				                             				   (    0.5f + j)*brick.transform.localScale.y, 
				                                 	           transform.position.z),
			                                       Quaternion.identity);
				newBrick.parent = transform;
			}
				                              
	}
	
	// Update is called once per frame
	void Update () {
        

	}
}
