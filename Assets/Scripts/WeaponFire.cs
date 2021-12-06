using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFire : MonoBehaviour
{
    public float damageAmount = 1f;
    public float range = 150;
    public Camera PlayerCamera;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(PlayerCamera.transform.position, PlayerCamera.transform.forward, out hit, range)) 
        {
            Debug.Log(hit.transform.name);
            
            HuntingTarget target = hit.transform.GetComponent<HuntingTarget>();
            if (target != null)
            {
                target.DamageReceived(damageAmount);
            }
        }
    }
}
