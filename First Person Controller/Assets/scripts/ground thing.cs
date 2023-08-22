using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        bean.isGrounded = true;
    }

    private void OnTriggerExit(Collider other)
    {
      bean.isGrounded = false;
    }
}
