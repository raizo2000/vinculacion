﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PPText : MonoBehaviour {
    public string name;
	// Update is called once per frame
	void Update () {
        GetComponent<Text>().text = PlayerPrefs.GetInt(name)+"";
	}
}
