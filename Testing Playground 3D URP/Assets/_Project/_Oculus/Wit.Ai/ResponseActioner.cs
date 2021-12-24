using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class ResponseActioner : MonoBehaviour
{
    [SerializeField] private TMP_Text txt_IntentRecieved;

    public void LogyValues(string[] values)
    {
        for (int i = 0; i < values.Length; i++)
            Debug.Log(values[i] + " ");
    }

    public void DisplayIntent(string[] values)
    {
        txt_IntentRecieved.text = "Intent: " + values[0];
    }



    public void DescribeTheProblem()
    {
        Debug.Log("DescribeTheProblem");
        txt_IntentRecieved.text = "DescribeTheProblem";
    }    
    
    public void ProblemInMoreDetail()
    {
        Debug.Log("ProblemInMoreDetail");
        txt_IntentRecieved.text = "ProblemInMoreDetail";
    }


}
