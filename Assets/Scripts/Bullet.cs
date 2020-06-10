using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

public class Bullet : MonoBehaviour
{
    public Vector3 targetPos;
    public GameObject targetSphere;

    int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        targetPos = targetSphere.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, targetPos, 0.55f);
    }
}
