using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Player : MonoBehaviour {

    public float speed;
    public Text InventoryText;

    private Rigidbody2D rb;
    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        count = 0;
        SetCountText();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);

        //transform.Translate(moveHorizontal, moveVertical, 0);
        rb.AddForce(movement * speed);
    }
    v
        
        oid OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collided!");
        if (other.gameObject.CompareTag("Potion"))
        {
            other.gameObject.SetActive(false);
            count += 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        InventoryText.text = "Inventory: " + count.ToString();
    }

}
