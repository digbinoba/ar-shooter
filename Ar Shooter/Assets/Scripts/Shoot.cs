using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject projectile;
    public float shootForce = 10.0f;
    public AudioClip audioClip;
    public AudioSource audioSource;
    public void ShootProjectile()
    {
        RaycastHit hit;
        //Hacky way of shooting. A ray will be shot but only shoots if it detects something
        //More often than not, the else statement will be triggered
        //audioSource.Play();

        if(Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            GameObject bullet = Instantiate(projectile, arCamera.transform.position, arCamera.transform.rotation);
            bullet.GetComponent<Rigidbody>().velocity = arCamera.transform.forward * shootForce;
            Destroy(bullet, 3.5f);
        }
        else{
            GameObject bullet = Instantiate(projectile, arCamera.transform.position, arCamera.transform.rotation);
            bullet.GetComponent<Rigidbody>().velocity = arCamera.transform.forward * shootForce;
            Destroy(bullet, 3.5f);
        }
    }
    // void Awake() {
    //     audioSource.clip = audioClip;
    // }
}
