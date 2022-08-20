using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healing : MonoBehaviour
{
    public int heal;
    public Health playerHealth;
    public GameObject player;
    public AudioClip clip;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerHealth.Healing(heal);
            transform.position = new Vector3(Random.Range(250, 400), Random.Range(-50, 80), transform.position.z);
            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
            player.transform.position += new Vector3(5,0,0);// = new Vector3(70, -5, -39);

        }
    }
}