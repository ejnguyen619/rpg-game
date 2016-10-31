using UnityEngine;
using System.Collections;

public class Raycast : MonoBehaviour {

	//variables
	private Vector3 targetPosition;
	private Vector3 mousePosition;
	private bool overCharacter;
	private GameObject cTile;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//sets up raycast
		Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		worldPoint.z = Camera.main.transform.position.z;
		Ray ray = new Ray(worldPoint, new Vector3(0,0,1));
		RaycastHit2D hit = Physics2D.GetRayIntersection(ray);

		//returns if raycast hits collider
		if(hit){
			//if raycast hits player
			if(hit.transform.gameObject.tag == "Player"){
				overCharacter = true;
				Ray ray2 = new Ray(hit.transform.position, new Vector3(0,0,1));
				RaycastHit2D hit2 = Physics2D.GetRayIntersection(ray2);
				if(hit2){
					cTile = hit2.transform.parent.gameObject;
				}
			}
			//if raycast hits tile
			else{
				overCharacter = false;
				cTile = hit.transform.parent.gameObject;
			}
		}

		//
	}

	public bool overChara(){
		return overCharacter;
	}

	public GameObject currentTile(){
		return cTile;
	}
}
