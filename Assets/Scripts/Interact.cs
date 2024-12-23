using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour
{
    public Transform InteractorSource;
    public float InteractRange;
    public GameObject lady;
    public GameObject closet;
    public GameObject objectToMove;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {


            closet.SetActive(false);
            lady.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray r = new Ray(InteractorSource.position, InteractorSource.forward);
            if (Physics.Raycast(r, out RaycastHit hitInfo, InteractRange))
            {
                if (hitInfo.collider.gameObject.CompareTag("Battle"))
                {

                    PlayerPrefs.SetInt("Scene", 2);
                    SceneManager.LoadScene(1);
                    SceneManager.MoveGameObjectToScene(objectToMove, SceneManager.GetSceneAt(1));

                }
                if (hitInfo.collider.gameObject.CompareTag("Colset"))
                {
                    closet.SetActive(true);
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                }
                if (hitInfo.collider.gameObject.CompareTag("Lady"))
                {
                    lady.SetActive(true);
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;

                }
            }
        }
    }
}
