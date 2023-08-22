using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizontalrotator : MonoBehaviour
{
    float sens = 150;

    Transform tf;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        tf.Rotate(new Vector3(0, Input.GetAxis("Mouse X") * sens, 0) * Time.deltaTime);
    }
}
