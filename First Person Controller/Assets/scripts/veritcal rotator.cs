using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verticalrotator : MonoBehaviour
{
    float sens = 150;
    float xRotation = 0;

    Transform tf;

    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        xRotation = xRotation + Input.GetAxis("Mouse Y") * -sens * Time.deltaTime;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
     
        tf.localRotation = Quaternion.Euler(new Vector3(xRotation, 0));
    }
}
