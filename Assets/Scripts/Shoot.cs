using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject bullet;
    public GameObject pointer;

    public Gesturedetector rightGestures;
    public OVRSkeleton skeleton;
    private List<OVRBone> fingerBones;

    [SerializeField]
    float yOffset = 0.1f;

    [SerializeField]
    float zOffset = 0f;

    [SerializeField]
    float xOffset = 0.1f;

    int counter = 0;
    bool loaded = false;


    void trackPointer()
    {
        var fingerBones = new List<OVRBone>(skeleton.Bones);
        OVRBone fingerTip = fingerBones[8];
        OVRBone fingerBase = fingerBones[0];
        Vector3 spawnPos = fingerTip.Transform.position + ((fingerTip.Transform.position - fingerBase.Transform.position) * 100);

        pointer.transform.position = spawnPos;
    }


    // Update is called once per frame
    void Update()
    {
        trackPointer();

        string gestureName = rightGestures.getCurrentGesture();

        if (gestureName == "GunShoot" && counter == 50 && loaded == true)
        {
            var fingerBones = new List<OVRBone>(skeleton.Bones);
            OVRBone fingerTip = fingerBones[8];

            var offset = new Vector3(xOffset, yOffset, zOffset);

            Vector3 spawnPos = fingerTip.Transform.position;
            spawnPos += offset;
            Quaternion rotatation = new Quaternion(0f, 0f, 0f, 0f);

            Instantiate(bullet, spawnPos, rotatation);
            counter = 0;
            loaded = false;
        }
        else if (gestureName == "GunCock")
        {
            loaded = true;
        }


        if (counter < 50)
        {
            counter++;
        }
    }

}
