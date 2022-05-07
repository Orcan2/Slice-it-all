using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject[] Levels = new GameObject[5];
    public int currentLevelNumber = 0;
    public GameObject currentlevel;
   // public GameObject NextLevelButton;


    public void Start()
    {
        currentlevel = Instantiate(Levels[0]);
    }
    //public void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("knife"))
    //    {
    //        NextLevelButton.SetActive(true);
    //    }
    //}
    public void Nextlvl()
    {
        Destroy(currentlevel);
        currentLevelNumber++;
        currentlevel = Instantiate(Levels[currentLevelNumber]);
       // NextLevelButton.SetActive(false);
    }
}
