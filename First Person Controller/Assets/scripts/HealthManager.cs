using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Image healthbar;
    public static bool hit;
    public float healthamount = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (healthamount <= 0)
        {
            SceneManager.LoadScene("Menu");
        }

        if (hit) 
        {
            TakeDamage(20);
            hit = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            heal(5);
        }
    }

    public void TakeDamage(float damage)
    {
        healthamount -= damage;
        healthbar.fillAmount = healthamount / 100f;
    }

    public void heal(float healingamount)
    {
        healthamount += healingamount;
        healthamount = Mathf.Clamp(healthamount, 0, 100);

        healthbar.fillAmount = healthamount / 100f;
    }
}
