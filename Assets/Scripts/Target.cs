using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

    public AudioClip destroySound;
    public float volume = 1;

    int counter = 0;

    private void Update()
    {
        var move = new Vector3(0f, 0f, Mathf.Sin(counter / 10) /10);
        gameObject.transform.position += move;
        counter++;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
