using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalEnter : MonoBehaviour
{
    public int scene_number = 0;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("LOLOLOLOLO!");
        
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(scene_number);
        }
    }
}
