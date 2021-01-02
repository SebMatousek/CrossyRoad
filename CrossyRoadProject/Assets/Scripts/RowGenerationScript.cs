using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RowGenerationScript : MonoBehaviour
{
    [SerializeField] private int numberOfRowsToGenerate;
    [SerializeField] private GameObject[] rowPrefabs;
    private GameObject _rowToGenerate;

    private void Start()
    {
        for (var i = 0; i < numberOfRowsToGenerate; i++)
        {
            var index = Random.Range (0, rowPrefabs.Length);
            _rowToGenerate = rowPrefabs[index];
            Instantiate(_rowToGenerate, new Vector3(i, 0, 0), Quaternion.identity);
        }
    }

}
