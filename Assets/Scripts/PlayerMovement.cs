using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Vector2 arah;
   // isinya (x,y)

    public float kecepatan;

    void Update()
    {
        //Vertikal atau sumbu Y
        if (Input.GetKey(KeyCode.W))
        {
            arah.y = +1;

        }
        if (Input.GetKey(KeyCode.S))
        {
            arah.y = -1;
        }

        //Horizontal atau sumbu X
        if (Input.GetKey(KeyCode.D))
        {
            arah.x = +1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            arah.x = -1;
        }


        //transform.Translate(x brp, y brp, z brp);
        transform.Translate(kecepatan * arah.x * Time.deltaTime, 
                            kecepatan * arah.y * Time.deltaTime,
                            0f);


        //buat gak gerak sendiri
        arah.x = 0;
        arah.y = 0;
    }

    private void OnCollisionEnter2D(Collision2D benda)
    {
        if(benda.gameObject.tag == "Enemy")
        {
            Destroy(benda.gameObject);
            Destroy(this.gameObject);
        }
    }
}
