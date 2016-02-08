using UnityEngine;
using System.Collections;

[System.Serializable]
public class GameObjectReferenceHolder : System.Object {

	private GameObject[] obstacles;

	public void AddObstacle(GameObject obs){
	
		obstacles [obstacles.Length] = obs;

	}

	public GameObject GetGameobject(int index){
		return obstacles [index];
	}

	public void DeleteGameObject(int index){
		obstacles [index] = null;
	}

}
