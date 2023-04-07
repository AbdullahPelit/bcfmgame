using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject objectPrefab; // obje prefab�m�z
    public float spawnRate = 0.5f; // objelerin do�ma h�z�
    public float speed = 3f; // objelerin hareket h�z�
    public float minY = -3.5f; // objelerin minimum y�ksekli�i
    public float maxY = 3.5f; // objelerin maksimum y�ksekli�i


    private float nextSpawnTime = 0f;

    void Update()
    {
        // Yeni objeler do�ma h�z�na g�re olu�turuluyor
        if (Time.time >= nextSpawnTime)
        {
            nextSpawnTime = Time.time + 1f / spawnRate;
            SpawnObjectLeft();
            //SpawnObjectRigt();
        }
    }

    void SpawnObjectLeft()
    {
        // Random y�kseklik de�eri belirleniyor
        float randomY = Random.Range(minY, maxY);

        Direction randomDirection = Random.Range(0f, 1f) < 0.5f ? Direction.left : Direction.right;
        if (randomDirection == Direction.right)
        {
            GameObject obj = Instantiate(objectPrefab, new Vector3(-3f, randomY, 0f), Quaternion.identity);
            obj.GetComponent<Rigidbody>().velocity = Vector2.right * speed;
        }
        if (randomDirection == Direction.left)
        {
            GameObject obj = Instantiate(objectPrefab, new Vector3(3f, randomY, 0f), Quaternion.identity);
            obj.GetComponent<Rigidbody>().velocity = Vector2.left * speed;
        }


    }


    public enum Direction
    {
        left,
        right
    }

    
}
