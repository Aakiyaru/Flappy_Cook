using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public int JumpForce = 1;
    Rigidbody2D Player;

    public GameObject Button;
    public GameObject ToMenuButton;
    public GameObject YouDied;
    public GameObject Record;
    public AudioSource BG_music;

    public int score;
    public Text score_text;
    private int record;
    private int frame;
    private bool dead;

    void Start()
    {
        Time.timeScale = 1;
        Player = GetComponent<Rigidbody2D>();
        frame = 0;
        Debug.Log($"Game started. Speed - {Time.timeScale}");
    }

    void Update()
    {
        frame++;

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            Player.velocity = Vector2.up * JumpForce;
        }

        score_text.text = score.ToString();
        record = PlayerPrefs.GetInt("savescore");

        if (score > record)
        {
            score_text.color = Color.red;
            PlayerPrefs.SetInt("savescore", score);
            PlayerPrefs.Save();
            Debug.Log("Best score saved");
        }

        if (frame % 5000 == 0 && !dead)
        {
            frame = 0;
            Time.timeScale += 0.1f;
            Debug.Log($"Speed rise {Time.timeScale}");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "enemy")
        {
            //Destroy(gameObject);
            Time.timeScale = 0;
            Button.SetActive(true);
            YouDied.SetActive(true);
            Record.SetActive(true);
            ToMenuButton.SetActive(true);
            BG_music.mute = true;
            dead = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "score")
        {
            score++;
        }
    }
}
