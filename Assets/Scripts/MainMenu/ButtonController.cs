﻿using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void loadTestLevel()
    {
        Debug.Log("Load Test Level Called!");

        SimpleLevelData level = new SimpleLevelData(10, 15f);
        GameSettings.instance.loadLevel(level);
    }
}
