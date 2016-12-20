using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

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
	
	}

	void SelectZombie(GameObject newZombie) {
		newZombie.transform.localScale = selectedSize;
	}
}

