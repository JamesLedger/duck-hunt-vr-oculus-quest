using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTarget : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

    public AudioClip destroySound;
    public float volume = 1;

    int counter = 0;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
