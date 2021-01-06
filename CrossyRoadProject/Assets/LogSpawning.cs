using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogSpawning : MonoBehaviour
{
    public Transform spawnPoint;
    [SerializeField] private GameObject logPrefab;
    [Range(0, 100)]
    public int spawnChance;
    [Range(0, 100)]
    public int cooldown;

    private int c = 0;

    void FixedUpdate()
    {
        var dice = Random.Range(0, 1000);

        if (dice < spawnChance && c == 0)
        {
            Spawn();
            c = cooldown;
        }
        else
        {
            if (c > 0)
                c--;
        }
    }

    void Spawn()
    {
        Instantiate(logPrefab, spawnPoint.position, spawnPoint.transform.rotation);
    }
}
