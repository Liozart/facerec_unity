using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerLoader : MonoBehaviour {

    public GameObject gamemanager;

	// Use this for initialization
	void Awake () {
        if (GameManager.instance == null)
            Instantiate(gamemanager);
	}
}
