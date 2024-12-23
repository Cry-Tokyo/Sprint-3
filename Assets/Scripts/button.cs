using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button : MonoBehaviour
{
    public pref pref;
    public Button Button1; // Reference to the Button
    public Button Button2; // Reference to the Button
    public Button Button3; // Reference to the Button
    public Button Button4; // Reference to the Button
    public Button Button5; // Reference to the Button
    public Button Button6; // Reference to the Button
    // Start is called before the first frame update
    public void OnButtonClick1()
    {
        Debug.Log("Button was pressed!");
        pref.apawn = true;
        Button1.interactable = false;
        Button1.image.color = Color.gray;
    }

    public void OnButtonClick2()
    {
        Debug.Log("Button was pressed!");
        pref.aknight = true;
        Button2.interactable = false;
        Button2.image.color = Color.gray;
    }

    public void OnButtonClick3()
    {
        Debug.Log("Button was pressed!");
        pref.abishop = true;
        Button3.interactable = false;
        Button3.image.color = Color.gray;
    }
    public void OnButtonClick4()
    {
        Debug.Log("Button was pressed!");
        pref.arook = true;
        Button4.interactable = false;
        Button4.image.color = Color.gray;
    }
    public void OnButtonClick5()
    {
        Debug.Log("Button was pressed!");
        pref.aking = true;
        Button5.interactable = false;
        Button5.image.color = Color.gray;
    }
    public void OnButtonClick6()
    {
        Debug.Log("Button was pressed!");
        pref.aqueen = true;
        Button6.interactable = false;
        Button6.image.color = Color.gray;

    }
}
