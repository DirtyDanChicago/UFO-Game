using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float speed;

    private int count;

    public Text countText;
    public Text winText;

    private bool isRed;

    public string pickupName = "";


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        count = 0;

        winText.text = "";

        SetCountText();

        isRed = false;

    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;

            pickupName = "PickUp";
        }

        if (Input.GetKey(KeyCode.E))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;

            pickupName = "BluePickup";

            isRed = false;
        }
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rb2d.AddForce(movement * speed);
    }

  
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag(pickupName))
        {
            other.gameObject.SetActive(false);

            count = count + 1;

            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        if(count >= 12)
        {
            winText.text = "You win!";
        }
    }

}
