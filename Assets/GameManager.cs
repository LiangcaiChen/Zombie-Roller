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
			GetZombieRight ();
		}

		if (Input.GetKeyDown ("up")) {
			PushUp ();
		}

	}

	void GetZombieLeft() {
		if (selectedZombiePosotion == 0) {
			selectedZombiePosotion = 3;
			SelectZombie (zombies [3]);
		} else {
			selectedZombiePosotion = selectedZombiePosotion - 1;
			GameObject newZombie = zombies[selectedZombiePosotion];
			SelectZombie (newZombie);
		}
	}

	void GetZombieRight() {
		if (selectedZombiePosotion == 3) {
			selectedZombiePosotion = 0;
			SelectZombie (zombies [0]);
		} else {
			selectedZombiePosotion = selectedZombiePosotion + 1;
			GameObject newZombie = zombies[selectedZombiePosotion];
			SelectZombie (newZombie);
		}
	}

	void SelectZombie(GameObject newZombie) {
		selectedZombie.transform.localScale = defaultSize;
		selectedZombie = newZombie;
		newZombie.transform.localScale = selectedSize;
	}

	void PushUp() {
		Rigidbody rb = selectedZombie.GetComponent<Rigidbody> ();
		rb.AddForce (0, 0, 10, ForceMode.Impulse);
	}
}
