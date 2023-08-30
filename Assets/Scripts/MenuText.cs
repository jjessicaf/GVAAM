using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuText : MonoBehaviour
{

    //controls the name of the folio displayed in the control panel

    //takes in list of names from inspector
    [SerializeField] private List<string> stateList = new List<string>();
    [SerializeField] private BookManager bookManager;
    private int stateNum = 0;


    private void Start()
    {
        if (stateList.Count >= 0)
        {
            GetComponent<TextMeshPro>().text = stateList[0]; // always start at the first page
        }

    }

    // update based on code in PagesideTextManager that recognizes if the page has been turned
    public void updateState()
    {
        stateNum = bookManager.getLeftPageNum(); // get the left page number
        GetComponent<TextMeshPro>().text = stateList[stateNum];
    }


    public void ResetExperienceMT()
    {
        stateNum = 0;
        GetComponent<TextMeshPro>().text = stateList[stateNum];
    }

}
