using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombieDeath : MonoBehaviour
{
    public int EnemyHealth = 20;
    public GameObject TheEnemy;
    public int StatusCheck;
    public AudioSource JumpscareMusic;

    void DamageZombie(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }




    void Update()
    {
        if (EnemyHealth <= 0 && StatusCheck == 0)
        {
            this.GetComponent<ZombieAI>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            StatusCheck = 2;
            TheEnemy.GetComponent<Animation>().Stop("walk");
            TheEnemy.GetComponent<Animation>().Play("death2");
            JumpscareMusic.Stop();
            

        }
    }
}
