using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    public GameObject[] weapons;
    private Animator anim;
    private int current_weapon;

    private void Start()
    {       
        current_weapon = 1;
        mask_all_weapon();
    }

    private void FixedUpdate()
    {
            Change_weapon();
            Take_weapon(current_weapon);
    }

    public void mask_all_weapon()
    {
        foreach (GameObject weapon in weapons)
        {
            weapon.SetActive(false);
            Debug.Log("Нет оружия");
        }
    }

    private void Take_weapon(int index)
    {
        foreach (GameObject weapon in weapons)
        {
            weapons[index].SetActive(true);
        }
    }

    private void Change_weapon()
    {
        float mw = Input.GetAxis("Mouse ScrollWheel");
        if (mw > 0.001)
        {
            if (current_weapon < 3)
            {
                mask_all_weapon();
                current_weapon++;
            }
            else
            {
                current_weapon = 0;
                mask_all_weapon();
            }
        }
        else if (mw < -0.001)
        {
            if (current_weapon > 0)
            {
                mask_all_weapon();
                current_weapon--;
            }
            else
            {
                current_weapon = 3;
                mask_all_weapon();
            }
        }
    }

    public void Current_weapon()
    {
        foreach (GameObject weapon in weapons)
        {
            weapons[current_weapon].SetActive(true);
        }
    }
}
