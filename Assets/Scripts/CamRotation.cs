using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotation : MonoBehaviour
{
    /// <summary>
    /// Rotation helper, attach to camera
    /// Coroutines should be more efficient
    /// </summary>

    public float turningRate = 30f; // Maximum turn rate in degrees per second.
    private Quaternion targetRotation; // Rotation to blend towards.

    private void Awake()
    {
        targetRotation = Quaternion.Euler(Vector3.up);
    }


    public void SetBlendedEulerAngles(Vector3 angles) // Call this to turn object smoothly.
    {
        targetRotation = Quaternion.Euler(angles);
    }

    public void CamLookUp()
    {
        targetRotation = Quaternion.Euler(Vector3.up);
    }

    public void CamLookDown()
    {
        targetRotation = Quaternion.Euler(Vector3.back);
    }

    private void Update()
    {
        // Turn towards our target rotation.
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, turningRate * Time.deltaTime);
    }

    


}






//public float rotSpeed = 0.1f;


//public Transform target;
//public float movementTime = 1;
//public float rotationSpeed = 0.1f;

//Vector3 refPos;
//Vector3 refRot;

//void Update()
//{
//    if (!target) return;
//    //Interpolate Rotation
//    transform.rotation = Quaternion.Slerp(transform.rotation, target.rotation, rotationSpeed * Time.deltaTime);
//}


//IEnumerator LookUpRotation()
//{
//    while (!target)
//    {
//        //transform.Rotate(Vector3.forward, 10);
//        //transform.rotation = Quaternion.Slerp(transform.rotation, transform.rotation, rotSpeed);
//        //Interpolate Position
//        transform.position = Vector3.SmoothDamp(transform.position, target.position, ref refPos, movementTime);
//        //Interpolate Rotation
//        transform.rotation = Quaternion.Slerp(transform.rotation, target.rotation, rotationSpeed * Time.deltaTime);

//        yield return new WaitForSeconds(0.01f);
//    }
//}

//IEnumerator LookDownRotation()
//{
//    while (true)
//    {
//        //transform.Rotate(Vector3.forward, 10);
//        yield return new WaitForSeconds(0.01f);
//    }
//}
