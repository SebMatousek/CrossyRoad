using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RowGenerationScript : MonoBehaviour
{
    [SerializeField] private int numberOfRowsToGenerate;
    [SerializeField] private GameObject[] rowPrefabs;
    [SerializeField] private GameObject[] grassObjectPrefabs;
    [SerializeField] private GameObject[] roadObjectPrefabs;
    [SerializeField] private GameObject[] waterObjectPrefabs;

    [Range(0, 100)]
    public int grassObjectGenerationChance;
    [Range(0, 100)]
    public int carGenerationChance;
    [Range(0, 100)]
    public int waterObjectGenerationChance;


    private GameObject _rowToGenerate;

    char terrainType;
    int dice;

    private void Start()
    {
        for (var i = -3; i < numberOfRowsToGenerate; i++)
        {

            if (i > -3 && i < 3)
            {
                Instantiate(rowPrefabs[0], new Vector3(i, 0, 0), Quaternion.identity);
                terrainType = 'g';
            }
            else
            {
                generateRow(i);
            }
        }
    }

    private void FixedUpdate()
    {
        var Object = GameObject.FindGameObjectsWithTag("Object");

        for (int i = 0; i < Object.Length; i++)
        {
            if (Object[i].transform.position.x < GameObject.Find("Chicken").transform.position.x - 5)
            {
                Destroy(Object[i]);
            }
        }

        if (Object[Object.Length - 1].transform.position.x < GameObject.Find("Chicken").transform.position.x + 15.0f)
        {
            generateRow(Object[Object.Length - 1].transform.position.x + 1.0f);
        }

        //Check if it is water or road and spawn cars and logs
        /*
        for (int i = 0; i < Object.Length; i++)
        {
            if (Object[i] == 0)
            {
                
            }
        }*/
        


    }

    private void generateRow(float x)
    {
        dice = Random.Range(0, 100);

        
        if(dice < 30)//Grass
        {
            _rowToGenerate = rowPrefabs[0];
            Instantiate(_rowToGenerate, new Vector3(x, 0, 0), Quaternion.identity);
            terrainType = 'g';
        }
        else if(dice < 80)//Road
        {
            _rowToGenerate = rowPrefabs[1];
            Instantiate(_rowToGenerate, new Vector3(x, 0, 0), Quaternion.identity);
            terrainType = 's';
        }
        else//Water
        {
            dice = Random.Range(0, 100);

            if (dice < 33)
            {
                Instantiate(rowPrefabs[2], new Vector3(x, 0, 0), Quaternion.Euler(0, 180, 0));
                terrainType = 'w';
            }
            else if (dice < 66)
            {
                Instantiate(rowPrefabs[3], new Vector3(x, 0, 0), Quaternion.Euler(0, 180, 0));
                terrainType = 'w';
            }
            else
            {
                Instantiate(rowPrefabs[4], new Vector3(x, 0, 0), Quaternion.Euler(0, 180, 0));
                terrainType = 'w';
            }
        }

        for (int j = -10; j < 10; j++)
        {
            if (terrainType == 'g')//terrain is grass
            {
                dice = Random.Range(0, 100);
                if (dice < grassObjectGenerationChance)
                {
                    dice = Random.Range(0, grassObjectPrefabs.Length);
                    var objectToGenerate = grassObjectPrefabs[dice];
                    Instantiate(objectToGenerate, new Vector3(x, 0.6f, j), Quaternion.identity);
                }
            }
        }
    }
}
