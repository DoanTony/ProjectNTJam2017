using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleScreenManager : MonoBehaviour
{

    public string annee;
    public string mois;
    public string jour;
    public Text dateText;

    // Use this for initialization
    void Start()
    {
        #region Date
        jour = System.DateTime.Now.Date.Day.ToString();
        annee = System.DateTime.Now.Date.Year.ToString();
        switch (System.DateTime.Now.Date.Month)
        {
            case 1:
                mois = "January";
                break;
            case 2:
                mois = "February";
                break;
            case 3:
                mois = "March";
                break;
            case 4:
                mois = "April";
                break;
            case 5:
                mois = "May";
                break;
            case 6:
                mois = "June";
                break;
            case 7:
                mois = "July";
                break;
            case 8:
                mois = "August";
                break;
            case 9:
                mois = "September ";
                break;
            case 10:
                mois = "October";
                break;
            case 11:
                mois = "November";
                break;
            case 12:
                mois = "December";
                break;

        }
        #endregion
        dateText.text = (jour + " " + mois + " " + annee);
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.anyKey)
        {
            //PlaySound when player press button
            Application.LoadLevel("MenuScreen");
        }

    }

}

