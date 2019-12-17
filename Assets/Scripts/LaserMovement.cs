using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMovement : MonoBehaviour
{
    public float kecepatan;

    void Start()
    {
        //Invoke("nama method", method dijalankan setelah x detik);
        Invoke("DestroyLaser", 3f);
    }

    void Update()
    {
        transform.Translate(kecepatan * Time.deltaTime, 0f, 0f);
    }

    void DestroyLaser()
    {
        //menghancurkan objek yg mengandung script ini
        Destroy(this.gameObject);
    }

    void OnCollisionEnter2D(Collision2D benda)
    {
        if(benda.gameObject.tag == "Enemy")
        {
            Destroy(benda.gameObject);
            Destroy(this.gameObject);
        }
       
    }
}
