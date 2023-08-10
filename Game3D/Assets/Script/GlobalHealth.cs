using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GlobalHealth : MonoBehaviour
{
    public static int currentHealth = 20;
    public int internalHealth;
    public Slider healthBar;

    void Update()
    {
        healthBar.value = currentHealth;
        internalHealth = currentHealth;
        if (currentHealth <= 0) 
        {
            SceneManager.LoadScene(1);
        }
    }
}
