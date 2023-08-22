using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunfire : MonoBehaviour
{
    private AudioSource gunshot;
    private bool hasGunFired = false;
    [SerializeField] float gunFireDelay;


    void Start()
    {
        gunshot = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("fire1"))
        {
            if (hasGunFired == false)
            {
                StartCoroutine(FireGun());
            }
        }
    }
    IEnumerator FireGun()
    {
        hasGunFired = true;
        gunshot.Play();
        yield return new WaitForSeconds(gunFireDelay);
        hasGunFired = false;
    }
}
