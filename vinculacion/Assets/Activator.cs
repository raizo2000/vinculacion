﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour {

    SpriteRenderer sr;
    public KeyCode key;
    bool active = false;
    GameObject note;
    Color old;
    public bool createMOde;
    public GameObject n;

    // Use this for initialization

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    void Start () {
        old = sr.color;
	}
   

    // Update is called once per frame
    void Update () {
        
        if (createMOde)
        {
            if (Input.GetKeyDown(key))
            {
                
                Instantiate(n, transform.position, Quaternion.identity);
            }
        }
        else
        {
            if (Input.GetKeyDown(key))
            {
                StartCoroutine(Pressed());
            }
            if (Input.GetKeyDown(key) && active)
            {
                Destroy(note);
                AddScore();
                active = false;
            }
        }
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        active = true;
        if (col.gameObject.tag == "Note")
        {
            note = col.gameObject;
        }
    }


    void OnTriggerExit2D(Collider2D col)
    {
        active = false;  
    }

    void AddScore()
    {
        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 100);
    }

    IEnumerator Pressed()
    {
        Color old = GetComponent<SpriteRenderer>().color;
        sr.color = new Color(0, 0, 0);
        yield return new WaitForSeconds(0.05f);
        sr.color = old;
    }

}
