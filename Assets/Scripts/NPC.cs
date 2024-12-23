using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    public pref prefs;


    public GameObject epawn;
    public GameObject eking;
    public GameObject erook;
    public GameObject eknight;
    public GameObject ebishop;
    public GameObject equeen;
    public GameObject apawn;
    public GameObject aking;
    public GameObject arook;
    public GameObject aknight;
    public GameObject abishop;
    public GameObject aqueen;

    void Start()
    {
        live_ncps();
    }

    public void live_ncps()
    {

        if (prefs.eking == true)
        {
            eking.SetActive(true);
        }
        if (prefs.equeen == true)
        {
            equeen.SetActive(true);
        }
        if (prefs.epawn == true)
        {
            epawn.SetActive(true);

        }
        if (prefs.ebishop == true)
        {
            ebishop.SetActive(true);

        }
        if (prefs.erook == true)
        {
            erook.SetActive(true);

        }
        if (prefs.eknight == true)
        {
            eknight.SetActive(true);

        }
        if (prefs.apawn == true)
        {
            apawn.SetActive(true);

        }
        if (prefs.abishop == true)
        {

            abishop.SetActive(true);
        }
        if (prefs.arook == true)
        {

            arook.SetActive(true);
        }
        if (prefs.aknight == true)
        {

            aknight.SetActive(true);
        }
        if (prefs.aking == true)
        {

            aking.SetActive(true);
        }
        if (prefs.aqueen == true)
        {

            aqueen.SetActive(true);
        }
    }
}
