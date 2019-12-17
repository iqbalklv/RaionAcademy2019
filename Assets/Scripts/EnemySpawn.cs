using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject musuh;

    public Transform spawnMusuh1;
    public Transform spawnMusuh2;

    public float interval1;
    public float interval2;


    void Start()
    {

        //InvokeRepeating("nama method", dijalankan stlh x detik, diulang setiap x detik);
        InvokeRepeating("SpawnEnemy1", 2f, interval1);
        InvokeRepeating("SpawnEnemy2", 2f, interval2);

    }

    void SpawnEnemy1()
    {
        Instantiate(musuh, spawnMusuh1.position, Quaternion.identity);
    }
    void SpawnEnemy2()
    {
        Instantiate(musuh, spawnMusuh2.position, Quaternion.identity);
    }
}
