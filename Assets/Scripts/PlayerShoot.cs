using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    //objek yang ditembakan
    public GameObject laser;

    //tempat keluar peluru
    public Transform lubangPeluru;

    //buat ngatur cooldown
    public float firerate;
    float cooldown;
    //---------------------


    void Update()
    {
        if (cooldown <= 0)
        {
            //kalo cooldownnya udh 0, masuk sini
            if (Input.GetKey(KeyCode.Space))
            {

                //Instantiate(apa yg dispawn, dimana, rotasinya gimana);
                Instantiate(laser, lubangPeluru.position, Quaternion.identity);

                //reset cooldown
                cooldown = firerate;
            }
        }
        else
        {
            //kalo cooldownnya blom 0, masuk sini

            //ngurangin cooldown
            cooldown -= Time.deltaTime;
            Debug.Log("Cooldown = " + cooldown);
        }

    }
}
