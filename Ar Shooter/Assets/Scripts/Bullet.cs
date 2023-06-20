using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject explosion;
    public AudioSource audioSource;
    public AudioClip launchClip, onHitClip;
    private void OnTriggerEnter(Collider colliderInfo) {
        if(colliderInfo.tag == "Enemy")
        {
            //Change audio clip to SSBU impact effect
            audioSource.clip = onHitClip;
            audioSource.Play();
            
            //Destroys the enemy upon impact and then make an explosion effect
            Destroy(colliderInfo.transform.gameObject);
            Instantiate(explosion, colliderInfo.transform.position, colliderInfo.transform.rotation);
            Debug.Log("Enemy was hit!");
        }
    }
    void Awake() {
        audioSource.clip = launchClip;
        audioSource.Play();
    }
}
