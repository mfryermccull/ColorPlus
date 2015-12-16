using UnityEngine;
using System.Collections;

public class NewCube : MonoBehaviour {

	public int x, y;
	public bool active;

	public void RandomColor (){
		//choose random color for new cube

		GetComponent<Renderer> ().material.color = colors [Random.Range (0, 5)];
	}

	public void HideColor (){

		GetComponent<Renderer> ().material.color = Color.clear;
	}

	//color choices
	Color[] colors = {Color.yellow, Color.blue, Color.green, Color.red, Color.magenta};


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}











