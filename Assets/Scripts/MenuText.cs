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
    private int vStart = 0;
    private int rStart = 1;
    private int vCurrent = 6;
    private int rCurrent = 7;
    private int leftPageNum = 0;


    private void Start()
    {
        if (stateList.Count >= 0)
        {
            //ex: FOLS. 6v-7r, FOLS. 8v-9r
            vCurrent = vStart;
            rCurrent = rStart;
            leftPageNum = 0;
            GetComponent<TextMeshPro>().text = "FOLS. " + vCurrent + "v-" + rCurrent + "r"; // always start at the first page
        }

    }

    // update based on bookmanager increment or decrement 
    public void updateState()
    {
        stateNum = bookManager.getLeftPageNum(); // get the left page number

        if (stateNum > leftPageNum) // turn right 
        {
            leftPageNum = stateNum;
            vCurrent++;
            rCurrent++;
        }
        else if (stateNum < leftPageNum) // turn left 
        {
            leftPageNum = stateNum;
            vCurrent--;
            rCurrent--;
        }
        GetComponent<TextMeshPro>().text = "FOLS. " + vCurrent + "v-" + rCurrent + "r";
    }


    public void ResetExperienceMT()
    {
        stateNum = 0;
        vCurrent = vStart;
        rCurrent = rStart;
        leftPageNum = 0;
        GetComponent<TextMeshPro>().text = stateList[stateNum];
    }

}
