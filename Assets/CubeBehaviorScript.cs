using UnityEngine;
using System.Collections;

public class CubeBehaviorScript : MonoBehaviour {

	public int x, y;
	public bool active;


	GameControllerScript aGameController;


	// Use this for initialization
	void Start () {
		aGameController = GameObject.Find("GameControllerObject").GetComponent<GameControllerScript>();

		}
	public void OnMouseDown () {
		aGameController.ProcessClickedCube (this.gameObject, x, y);
	}
		
	// Update is called once per frame
	void Update () {

	}
}
