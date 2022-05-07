using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nextlvl : MonoBehaviour
{
    public GameObject NextLevelButton;
    
    public void OnCollisionEnter(Collision collision)
    {
        
        
            NextLevelButton.SetActive(true);
        collision.rigidbody.isKinematic = true;       
    }
    
    public void ButtonSwitch()
    {
        NextLevelButton.SetActive(false);
    }
}
