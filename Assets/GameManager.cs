using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;

    public int numberOfPersons;
    public List<string> personsNames;

	// Use this for initialization
	void Awake () {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

        numberOfPersons = 0;
        personsNames = new List<string>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
