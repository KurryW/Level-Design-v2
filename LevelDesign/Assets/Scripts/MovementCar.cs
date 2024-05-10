using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCar : MonoBehaviour
{
    public WheelCollider frontLeftWheel, frontRightWheel;
    public WheelCollider rearLeftWheel, rearRightWheel;

    public float motorForce = 1000f;
    public float steeringAngle = 30f;

    void Update()
    {
        // Motor input
        float motorInput = Input.GetAxis("Vertical");
        frontLeftWheel.motorTorque = motorInput * motorForce;
        frontRightWheel.motorTorque = motorInput * motorForce;

        // Steering input
        float steeringInput = Input.GetAxis("Horizontal");
        frontLeftWheel.steerAngle = steeringInput * steeringAngle;
        frontRightWheel.steerAngle = steeringInput * steeringAngle;
    }
}
