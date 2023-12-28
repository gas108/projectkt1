using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public string GameScene;
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            SceneManager.LoadScene(GameScene);
        }
    }
}
