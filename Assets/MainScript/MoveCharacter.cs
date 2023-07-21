using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveCharacter : MonoBehaviour
{
    public float speed = 2f ;
    public Transform trans ;
    public Animator animator ;
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogError(" speed: " + speed);
        
    }

    // Update is called once per frame
    void Update()
    {   
        
        float x = Input.GetAxis("Horizontal");// GetAxis : lấy giá trị từ 0 -> 1 or -1 ( có 0.1,...)
        float z = Input.GetAxis("Vertical");
        Vector3 pos_new = new Vector3(x, 0, z);
        float length = pos_new.magnitude; //tạo 1 độ dài
        if ( length > 0 )
        {
            trans.forward = pos_new;
            trans.position = trans.position + (pos_new * speed * Time.deltaTime);
            animator.SetFloat("speed", 1);
        }
        else
        {
            animator.SetFloat("speed", 0);
        }
        //trans.position = new Vector3( trans.position.x + x*speed, trans.position.y, trans.position.z + z* speed );
    }
}
