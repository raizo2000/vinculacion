using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class over : MonoBehaviour {
    public Text game;
    public GameObject ever;


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "End")
        {
            game.text = "GameOver";
            SceneManager.LoadScene("gameOver");
        }
    }

    public void GAME()
    {
        SceneManager.LoadScene("Game");
    }
    public void GAME1()
    {
        SceneManager.LoadScene("inicio");
        PlayerPrefs.DeleteAll();
    }
}
