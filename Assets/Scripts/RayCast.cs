using UnityEngine;
using System.Collections;

public class RayCast : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		// Shoot viewing ray into the scene
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		Debug.DrawRay(Camera.main.transform.position, ray.direction*100, Color.red, 0, true);

		// Detect collision
		RaycastHit hit;
		GameObject hitObject;

		if(Physics.Raycast(ray, out hit))
		{
			hitObject = hit.collider.gameObject;
			Debug.Log ("Hit gameObject " +hitObject.name + " at " + hit.point.ToString("F2") + ".");

			// Compute vertices of AABB (Axis Aligned Bounding Box)
			Vector3 bboxCenter = hit.collider.bounds.center;
			Vector3 bboxExtents = hit.collider.bounds.extents;

			Vector3 bboxFTL = new Vector3(bboxCenter.x - bboxExtents.x, // Front top left
			                              bboxCenter.y + bboxExtents.y, 
			                              bboxCenter.z - bboxExtents.z);
			Vector3 bboxFTR = new Vector3(bboxCenter.x + bboxExtents.x, // Front top right
			                              bboxCenter.y + bboxExtents.y, 
			                              bboxCenter.z - bboxExtents.z);
			Vector3 bboxFBL = new Vector3(bboxCenter.x - bboxExtents.x, // Front bottom left
			                              bboxCenter.y - bboxExtents.y, 
			                              bboxCenter.z - bboxExtents.z);
			Vector3 bboxFBR = new Vector3(bboxCenter.x + bboxExtents.x, // Front bottom right
			                              bboxCenter.y - bboxExtents.y, 
			                              bboxCenter.z - bboxExtents.z);
			Vector3 bboxBTL = new Vector3(bboxCenter.x - bboxExtents.x, // Back top left
			                              bboxCenter.y + bboxExtents.y, 
			                              bboxCenter.z + bboxExtents.z);
			Vector3 bboxBTR = new Vector3(bboxCenter.x + bboxExtents.x, // Back top right
			                              bboxCenter.y + bboxExtents.y, 
			                              bboxCenter.z + bboxExtents.z);
			Vector3 bboxBBL = new Vector3(bboxCenter.x - bboxExtents.x, // Back bottom left
			                              bboxCenter.y - bboxExtents.y, 
			                              bboxCenter.z + bboxExtents.z);
			Vector3 bboxBBR = new Vector3(bboxCenter.x + bboxExtents.x, // Back bottom right
			                              bboxCenter.y - bboxExtents.y, 
			                              bboxCenter.z + bboxExtents.z);

			// Display AABB 
			Debug.DrawLine(bboxFTL, bboxFTR, Color.green);
			Debug.DrawLine(bboxFTR, bboxFBR, Color.green);
			Debug.DrawLine(bboxFBR, bboxFBL, Color.green);
			Debug.DrawLine(bboxFBL, bboxFTL, Color.green);

			Debug.DrawLine(bboxBTL, bboxBTR, Color.green);
			Debug.DrawLine(bboxBTR, bboxBBR, Color.green);
			Debug.DrawLine(bboxBBR, bboxBBL, Color.green);
			Debug.DrawLine(bboxBBL, bboxBTL, Color.green);

			Debug.DrawLine(bboxFTL, bboxBTL, Color.green);
			Debug.DrawLine(bboxFTR, bboxBTR, Color.green);
			Debug.DrawLine(bboxFBL, bboxBBL, Color.green);
			Debug.DrawLine(bboxFBR, bboxBBR, Color.green);
		
		}

	}
}
