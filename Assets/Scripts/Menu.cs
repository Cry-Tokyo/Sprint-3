using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{

    void Start()
    {

    }
    public void startButton()
    {
        Debug.Log("Start");
        SceneManager.LoadScene(2);
    }

    void Update()
    {

    }
}
