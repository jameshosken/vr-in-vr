using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HMDSwitcherController : MonoBehaviour
{
    public Collider headsetCollider;
    Collider headCollider;

    public Transform HMDHeadpoint;

    bool isLocked = false;
    // Start is called before the first frame update
    void Start()
    {
        headCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {


        if (isLocked)
        {
            LockHeadset();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        bool leftRelease = OVRInput.GetUp(OVRInput.Button.PrimaryHandTrigger) && !OVRInput.Get(OVRInput.Button.SecondaryHandTrigger);
        bool rightRelease = OVRInput.GetUp(OVRInput.Button.SecondaryHandTrigger) && !OVRInput.Get(OVRInput.Button.PrimaryHandTrigger);


        bool leftGrab = OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger) ;
        bool rightGrab = OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger);

        if (rightRelease || leftRelease)
        {
            isLocked = true;
        }

        if (leftGrab || rightGrab)
        {
            isLocked = false;
        }


    }

    private void LockHeadset()
    {
        HMDHeadpoint.position = transform.position + transform.forward * 0.025f;
        HMDHeadpoint.rotation = transform.rotation;

    }
}
