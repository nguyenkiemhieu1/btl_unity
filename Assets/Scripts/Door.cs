using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Door : MonoBehaviour
{
    public int Levelload = 1;
    public gamemaster gm;

    // Use this for initialization
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("gamemaster").GetComponent<gamemaster>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            //savescore();
            gm.Inputtext.text = ("Press E to enter");
        }
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                
        //int currentLevel = SceneManager.GetActiveScene().buildIndex;

        //if (currentLevel >= PlayerPrefs.GetInt("levelIsUnlocked"))
        //{
        //    PlayerPrefs.SetInt("levelIsUnlocked", currentLevel + 1);
        //}

        //Debug.Log("LEVEL" + PlayerPrefs.GetInt("levelIsUnlocked") + " UNLOCKED");


                //savescore();
                SceneManager.LoadScene(Levelload);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            gm.Inputtext.text = ("");
        }
    }

    //void savescore()
    //{
    //    PlayerPrefs.SetInt("points", gm.points);
    //}
}