using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public GameObject characterInfo;
    public GameObject inventoryUI;
    GameObject miniMap;
    GameObject charInfo;

    // Use this for initialization
    void Start()
    {
        miniMap = GameObject.Find("MinimapPanel");
        charInfo = GameObject.Find("CharInfo");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            characterInfo.SetActive(!characterInfo.activeSelf);
            if (!characterInfo.activeSelf || !inventoryUI.activeSelf)
            {
                miniMap.SetActive(true);
                charInfo.SetActive(true);
            }
            else
            {
                miniMap.SetActive(false);
                charInfo.SetActive(false);

            }
        }
    }
}
