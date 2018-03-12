using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillControl : MonoBehaviour
{
    public float mana;

    float maxMana = 100;
    float qSkillMana = 5;
    float wSkillMana = 10;
    float eSkillMana = 20;
    float rSkillMana = 50;

    public Image manaBar;
    public Text notification;

    // Use this for initialization
    void Start()
    {
        mana = maxMana;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (mana < qSkillMana)
                StartCoroutine(NotEnoughMana());
            else
                mana -= qSkillMana;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (mana < wSkillMana)
                StartCoroutine(NotEnoughMana());
            else
                mana -= wSkillMana;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (mana < eSkillMana)
                StartCoroutine(NotEnoughMana());
            else
                mana -= eSkillMana;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (mana < rSkillMana)
                StartCoroutine(NotEnoughMana());
            else
                mana -= rSkillMana;
        }

        manaBar.fillAmount = mana / maxMana;
    }

    IEnumerator NotEnoughMana()
    {
        notification.text = "Not enough mana";
        notification.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        notification.gameObject.SetActive(false);
    }
}
