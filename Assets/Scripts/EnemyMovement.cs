using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float kecepatan;

    private void Start()
    {
        Invoke("DestroyEnemy", 10f);
    }

    void Update()
    {
        transform.Translate(kecepatan * Time.deltaTime * -1, 0f, 0f);
    }

    void DestroyEnemy()
    {
        Destroy(this.gameObject);
    }
}
