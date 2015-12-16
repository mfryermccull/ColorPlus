using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GameControllerScript : MonoBehaviour {

	public GameObject cubePrefab;
	private GameObject[,] allCubes;
	public GameObject aCube;
	public GameObject NewCube;
	public NewCube NewCubeScript;
	void MakePlusBlack (int x, int y){
		//make all plus cubes black
	}

	public int NewCubeX = 7;
	public int NewCubeY = 0;

	int activeX = 0;
	int activeY = 0;
	int gridWidth = 8;
	int gridHeight = 5;
	int samePlusPoints = 10;
	int Score;


	//timing
	public Text timerUI;
	float timerLength = 60.0f;
	float gameLength = 60.0f;
	float turnLength = 2.0f;
	float timeToAct = 0;

	//public float speed = ;

	public Text ScoreUI;


	public void ProcessClickedCube (GameObject clickedCube, int x, int y) {
	}


	// Use this for initialization
	void Start () {

		timeToAct += turnLength;

		allCubes = new GameObject[gridWidth, gridHeight];

		for (int x = 0; x < gridWidth; x++) {
			for (int y = 0; y < gridHeight; y++) {
				allCubes[x,y] = (GameObject) Instantiate(aCube,new Vector3(x*2 - 14, y*2 - 8, 10), Quaternion.identity);
				allCubes[x,y].GetComponent<CubeBehaviorScript>().x = x;
				allCubes[x,y].GetComponent<CubeBehaviorScript>().y = y;
			}
		}

		allCubes [0, 4].GetComponent<Renderer> ().material.color = Color.red;


		ScoreUI.text = "Score:" + Score;
		ScoreUI.color = new Color (141f/255f, 61/255, 156/255);

	}

	bool CheckForSamePlus(int x, int y) {
		Color targetColor = allCubes [x, y].GetComponent<Renderer> ().material.color;

		if (targetColor == Color.white || targetColor == Color.black) {
			return false;
		}

		if (targetColor == allCubes [x, y + 1].GetComponent<Renderer> ().material.color &&
		    targetColor == allCubes [x, y - 1].GetComponent<Renderer> ().material.color &&
		    targetColor == allCubes [x + 1, y].GetComponent<Renderer> ().material.color &&
		    targetColor == allCubes [x - 1, y].GetComponent<Renderer> ().material.color)
			return true;
		else
			return false;
	}

	bool CheckForDifferentPlus(int x, int y) {
		return false;
	}

	void ScoreCheck() {
		for (int x = 1; x < gridWidth - 1; x++) {
			for (int y = 1; y < gridHeight - 1; y++) {
				if (CheckForSamePlus(x,y)) {	
							
					Score += samePlusPoints;

					MakePlusBlack(x, y);
			}

	}
		}
	}



	// Update is called once per frame
	void Update () {
		
			if (Time.time > timeToAct) {
				

			//transform.translate (speed, * Time.time 0,0);
	}
}
}
