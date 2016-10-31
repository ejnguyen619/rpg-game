using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PathFinder : MonoBehaviour {

	List <GameObject> Tiles = new List<GameObject> ();
		
	//finds all walkable tiles
	public void walkableTiles(GameObject startTile, int x){
		Queue visited = new Queue(20);
		visited.Enqueue (startTile);
		startTile.GetComponent<TileClass> ().walk = true;
		startTile.GetComponent<TileClass> ().walkDirection = "start";
		Tiles.Add (startTile);
		while (visited.Count != 0) {
			GameObject currentTile = (GameObject) visited.Dequeue ();
			int count = currentTile.GetComponent<TileClass> ().walkSteps;
			if (count < x) {
				//right
				if (currentTile.GetComponent<TileClass> ().right != null) {
					GameObject right = currentTile.GetComponent<TileClass> ().right;
					if (right.GetComponent<TileClass> ().walk != true) {
						right.GetComponent<TileClass> ().walk = true;
						right.GetComponent<TileClass> ().walkSteps = count + 1;
						right.GetComponent<TileClass> ().ancestor = currentTile;
						right.GetComponent<TileClass> ().walkDirection = "right";
						Tiles.Add (right);
						visited.Enqueue (right);
					}
				}
				//left
				if (currentTile.GetComponent<TileClass> ().left != null) {
					GameObject left = currentTile.GetComponent<TileClass> ().left;
					if (left.GetComponent<TileClass> ().walk != true) {
						left.GetComponent<TileClass> ().walk = true;
						left.GetComponent<TileClass> ().walkSteps = count + 1;
						left.GetComponent<TileClass> ().ancestor = currentTile;
						left.GetComponent<TileClass> ().walkDirection = "left";
						Tiles.Add (left);
						visited.Enqueue (left);
					}
				}
				//down
				if (currentTile.GetComponent<TileClass> ().down != null) {
					GameObject down = currentTile.GetComponent<TileClass> ().down;
					if (down.GetComponent<TileClass> ().walk != true) {
						down.GetComponent<TileClass> ().walk = true;
						down.GetComponent<TileClass> ().walkSteps = count + 1;
						down.GetComponent<TileClass> ().ancestor = currentTile;
						down.GetComponent<TileClass> ().walkDirection = "down";
						Tiles.Add (down);
						visited.Enqueue (down);
					}
				}
				//up
				if (currentTile.GetComponent<TileClass> ().up != null) {
					GameObject up = currentTile.GetComponent<TileClass> ().up;
					if (up.GetComponent<TileClass> ().walk != true) {
						up.GetComponent<TileClass> ().walk = true;
						up.GetComponent<TileClass> ().walkSteps = count + 1;
						up.GetComponent<TileClass> ().ancestor = currentTile;
						up.GetComponent<TileClass> ().walkDirection = "up";
						Tiles.Add (up);
						visited.Enqueue (up);
					}
				}
			} 
		}
	}

	//resets tiles to original status
	public void deletePaths(){
		foreach(GameObject n in Tiles){
			n.GetComponent<TileClass>().walk = false;
			n.GetComponent<TileClass> ().walkSteps = 0;
			n.GetComponent<TileClass> ().ancestor = null;
			n.GetComponent<TileClass> ().walkDirection = "";
		}
		Tiles.Clear ();
	}
}
