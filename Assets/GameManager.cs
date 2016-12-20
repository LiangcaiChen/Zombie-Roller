using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	private int selectedZombiePosotion = 0;
	public GameObject selectedZombie;
	public List<GameObject> zombies;
	public Vector3 selectedSize;
	public Vector3 defaultSize;

	// Use this for initialization
	void Start () {
		SelectZombie (selectedZombie);

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("left")) {
			GetZombieLeft ();
		}

		if (Input.GetKeyDown ("right")) {

		}

		if (Input.GetKeyDown ("up")) {

		}

	}

	void GetZombieLeft() {
		if (selectedZombiePosotion == 0) {
			SelectZombie (zombies [3]);
		} else {
			GameObject newZombie = zombies[selectedZombiePosotion - 1];
			SelectZombie (newZombie);
		}
	}

	void GetZombieRight() {
		if (selectedZombiePosotion == 3) {
			SelectZombie (zombies [0]);
		} else {
			GameObject newZombie = zombies[selectedZombiePosotion + 1];
			SelectZombie (newZombie);
		}
	}

	void SelectZombie(GameObject newZombie) {
		newZombie.transform.localScale = selectedSize;
	}
}

