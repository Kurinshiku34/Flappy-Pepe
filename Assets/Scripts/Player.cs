using TreeEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocity = 1f;
    public float zSpeed = 0f;
    private Rigidbody2D rb;
    public AudioSource scoreSound;
    public AudioSource hitSound;
    private SpriteRenderer rend;
    public Sprite fallingPepe;
    public Sprite flyingPepe;
    public GameObject wing;

    void Start()
    {
        wing = GameObject.Find("Wing");
        rb = GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
        rend.sprite = flyingPepe;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { rb.velocity = Vector2.up * velocity; }
        if( this.rb.velocity.y < -0.5 ) { rend.sprite = fallingPepe; wing.SetActive(false); }
        if (this.rb.velocity.y > 0) { rend.sprite = flyingPepe; wing.SetActive(true); }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Obstacle") { FindObjectOfType<GameManager>().GameOver(); hitSound.Play(); }
        else if (col.gameObject.tag == "Score") { FindObjectOfType<GameManager>().IncreaseScore(); scoreSound.Play(); }
    }
}
