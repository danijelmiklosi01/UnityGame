using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class preprekeDamage : MonoBehaviour
{
    public int damage;
    public Health playerHealth;
    public AudioClip clip;




    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(damage);
            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
            
        }
    }
}
