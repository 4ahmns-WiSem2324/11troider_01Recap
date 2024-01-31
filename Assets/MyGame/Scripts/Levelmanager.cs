using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelmanager : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            SceneManager.LoadScene(1);
        }
    }
}
