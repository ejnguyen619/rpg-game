using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class CharacterMovement2 : MonoBehaviour {

	//variables
	bool stillMoving = false;
	bool charaSelect = false;
	bool turn = false;
	bool nextStep = false;
	int index = 0;
	int mSpeed = 0;
	float angle = 0;
	private Vector3 targetPosition;
	private Vector3 mousePosition;
	private GameObject startTile;
	private GameObject destTile;
	List <GameObject> walkPath = new List <GameObject>(); 
	private GameObject nBlock;

	// Use this for initialization
	void Start () {
		//runs character script
		GetComponent<AssaultClass> ().Assault ();

		//gets character speed
		mSpeed = GetComponent<AssaultClass>().MovementSpeed;

		targetPosition = transform.position;
		angle = 0;
	}
	
	// Update is called once per frame
	void Update () {
		//if Raycast on character, button clicked, charaSelect = false, charaSelect = true
		//else charaSelect = false;
		if (Input.GetMouseButtonDown (0)) {
			bool overCharacter = GetComponent<Raycast> ().overChara();
			if (overCharacter == true) {
				if (charaSelect == false) {
					charaSelect = true;
					startTile = GetComponent<Raycast> ().currentTile ();
					GetComponent<PathFinder> ().walkableTiles (startTile, mSpeed);
				} 
				else {
					charaSelect = false;
				}
			} 
			else {
				if(charaSelect == true && stillMoving == false){
					charaSelect = false;
					destTile = GetComponent<Raycast> ().currentTile ();
					if (destTile.GetComponent<TileClass> ().walk == true) {
						Path (startTile, destTile, walkPath);
						nextStep = true;
					} else {
						Debug.Log ("Unable to walk here");
					}
				}
			}
		}
		if (nextStep == true) {
			nBlock = nextBlock (walkPath, index);
			targetPosition.x = nBlock.GetComponent<TileClass> ().xCoordinate;
			targetPosition.y = nBlock.GetComponent<TileClass> ().yCoordinate - 19;
			targetPosition.z = transform.position.z;
			if (nBlock.GetComponent<TileClass>().walkDirection != "start") {
				angle = turnAngle (nBlock);
			}
			turn = true;
			stillMoving = true;
			nextStep = false;
		}
		if (stillMoving == true) {
			if (turn == true) {
				turnChara (angle);
			} else {
				if (Vector3.Distance (transform.position, targetPosition) > 0.1) {
					moveChara ();
				} else {
					if (nBlock != destTile) {
						nextStep = true;
					} else {
						stillMoving = false;
						index = 0;
						walkPath.Clear ();
						GetComponent<PathFinder> ().deletePaths ();
					}
				}
			}
		}

		//if Raycast not on character, button clicked, notMoving, charaSelect = true,
		//targetPosition = grid

		//else nothing
	}

	//finds which path to walk on and places in list
	private void Path(GameObject s, GameObject e, List<GameObject> x){
		GameObject start = s;
		GameObject end = e;

		if (start != end) {
			Path (start, end.GetComponent<TileClass> ().ancestor, x);
			x.Add (end);
		} else {
			x.Add (end);
		}
	}

	//finds next block to walk to
	private GameObject nextBlock(List<GameObject> x, int i){
		GameObject block = x [x.Count -1];
		int count = i;
		while (count < x.Count-1) {
			string cDirection = x[count].GetComponent<TileClass>().walkDirection;
			string pDirection = x[count+1].GetComponent<TileClass>().walkDirection;
			if (cDirection != pDirection) {
				block = x [count];
				break;
			}
			count++;
		}
		index = count+1;
		return block;
	}

	//determines angle to turn sprite
	private float turnAngle(GameObject n){
		string direction = n.GetComponent<TileClass> ().walkDirection;
		float x = transform.rotation.z;

		switch (direction) {
		case "right":
			x = 0;
			break;
		case "left":
			x = 180;
			break;
		case "down":
			x = 270;
			break;
		case "up":
			x = 90;
			break;
		}

		return x;
	}

	//turns sprite
	private void turnChara(float targetAngle){
		float turnSpeed = 2;
		if (Mathf.Abs(Quaternion.Angle(transform.rotation, Quaternion.Euler (0, 0, targetAngle))) > 1) {
			transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.Euler (0, 0, targetAngle), turnSpeed * Time.deltaTime);
		} else {
			turn = false;
		}
	}

	//moves sprite
	private void moveChara(){
		transform.position = Vector3.MoveTowards (transform.position, targetPosition, Time.deltaTime * 2);
	}

}
