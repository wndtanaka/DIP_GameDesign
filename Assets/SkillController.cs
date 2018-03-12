using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillController : MonoBehaviour
{
    public Button qSkill;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Q SKill Triggered");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W SKill Triggered");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E SKill Triggered");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("R SKill Triggered");
        }

    }

    public void QSkill()
    {

    }
}
