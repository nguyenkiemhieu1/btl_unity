using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door1 : MonoBehaviour
{
    public int Levelload1 = 3;
    public gamemaster1 gm1;

    // Use this for initialization
    void Start()
    {
        gm1 = GameObject.FindGameObjectWithTag("gamemaster1").GetComponent<gamemaster1>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            //savescore();
            gm1.Inputtext.text = ("Press E to enter");
        }
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                //savescore();
                SceneManager.LoadScene(Levelload1);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            gm1.Inputtext.text = ("");
        }
    }

    //void savescore()
    //{
    //    PlayerPrefs.SetInt("points", gm.points);
    //}
}