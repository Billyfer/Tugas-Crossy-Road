using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    [SerializeField] GameObject treePrefab;
    [SerializeField] GameObject treePrefab1;
    [SerializeField] TerrainBlock terrain;
    [SerializeField] int treeCount = 1;

    private void Start()
    {
        List<Vector3> emptyPos = new List<Vector3>();
        GameObject spawnRandom = Random.value > 0.5f ? treePrefab : treePrefab1;
        for (int x = -terrain.Extent; x < terrain.Extent; x++)
        {
            if (transform.position.z == 0 && x == 0)
            {
                continue;
            }
            emptyPos.Add(transform.position + Vector3.right * x);
        }


        for (int i = 0; i < treeCount; i++)
        {
            //var index = Random.Range(0, emptyPos.Count - 1);
            var index = Random.Range(0, emptyPos.Count);
            var spawnPos = emptyPos[index];
            Instantiate(
                spawnRandom,
                spawnPos,
                Quaternion.identity,
                this.transform);
            emptyPos.RemoveAt(index);
        }

        Instantiate(
            treePrefab,
            transform.position + Vector3.right * -(terrain.Extent + 1),
            Quaternion.identity,
            this.transform);

        Instantiate(
            treePrefab,
            transform.position + Vector3.right * (terrain.Extent + 1),
            Quaternion.identity,
            this.transform);
    }




}
