using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    public GameObject enemy;

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            Instantiate(
                enemy,
                new Vector3(Random.Range(-8f, 8f), transform.position.y, 0f),
                transform.rotation
            );

            yield return new WaitForSeconds(0.5f);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnEnemy");    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
