using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BirdMove : MonoBehaviour 
{
    public float velocity = 1f;
    public Rigidbody2D rbr2D;
    public bool isDead = false;
    public GameManager managerGame;
    public GameObject DeathScreen;
    public AudioClip WingSound;
    public AudioClip ScoreSound;
    public AudioClip DieSound;
    public AudioClip dusmeSes;


    private void Start()
    {
        Time.timeScale = 1;
    }
    

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().PlayOneShot(WingSound);
            rbr2D.velocity = Vector2.up * velocity;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Count")
        {
            managerGame.UpdateScore();
            GetComponent<AudioSource>().PlayOneShot(ScoreSound);


        }
        if (collision.gameObject.name == "AttemptCount")
        {
            managerGame.UpdateAttempt();
           
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            GetComponent<AudioSource>().PlayOneShot(DieSound);
            Time.timeScale = 0;

            DeathScreen.SetActive(true);
        }
    }
    
}
