using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private float phase;
    private float amplitude;
    // Start is called before the first frame update
    void Start()
    {
        phase = Random.Range(0f, Mathf.PI * 2);
        amplitude = Random.Range(0.03f, 0.05f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(
            Mathf.Sin(Time.frameCount * 0.05f + phase) * amplitude,
            -2f * Time.deltaTime,
            0f
        );
    }
}
