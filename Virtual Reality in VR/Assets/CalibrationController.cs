using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CalibrationController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform calibrationCenter;
    public Transform leftController;
    public Transform rightController;
    public Transform playerController;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool button_B = OVRInput.Get(OVRInput.RawButton.B);
        bool button_Y = OVRInput.Get(OVRInput.RawButton.Y);

        if(button_B && button_Y)
        {
            //Calibrate();
        }
    }

    //void Calibrate()
    // TODO fix
    //{
    //    Debug.Log(calibrationCenter.position);
    //    Vector3 leftHandLocalOffset = (leftController.localPosition + Vector3.up*2)*-1;

    //    calibrationCenter.position = leftController.position;

    //    Debug.Log(calibrationCenter.position);

    //    playerController.localPosition = leftHandLocalOffset;
    //    playerController.localRotation = Quaternion.identity;

    //    Debug.Log("...................");
    //    //Debug.Log("...................");

    //}
}
