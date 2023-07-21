using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform PBRCharacter;
    public Transform trans;
    //private Vector3 rotationMove;
   // private Vector3 offet = new Vector3(0,4f,-10f);
    // Start is called before the first frame update
    void Start()
    {
        trans = transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        ////Xác định hướng di chuyển của character
        //Vector3 moveDirection = PBRCharacter.forward;
        //moveDirection.y = 0f;// trục Y = 0, ko di chuyển
        //if (rotationMove != Vector3.zero)
        //{
        //    Quaternion tagetRotation = Quaternion.LookRotation(rotationMove);
        //    transform.rotation = Quaternion.Slerp(transform.rotation, tagetRotation, Time.deltaTime * 10f);
        //}
        trans.position = PBRCharacter.transform.position;
       // trans.position = this.PBRCharacter.transform.position + this.offet;
        //float horizontalInput = Input.GetAxis("Horizontal");
        //float verticalInput = Input.GetAxis("Vertical");
        ////Điều chỉnh góc quay
        //rotationMove.x += horizontalInput;
        //rotationMove.y += verticalInput;
        ////Áp dụng cho camera
        //transform.eulerAngles = rotationMove;
    }

}
                    