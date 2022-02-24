using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
    public float speed = 0.1f;

    public int bulletDamage = 1;

    private GameObject Player;
    Vector3 TempTranform;

    public Rigidbody2D rb;
    bool dsd = false;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        TempTranform = Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (TempTranform != transform.position && dsd == false)
        {
            rb.velocity = (TempTranform - transform.position).normalized * speed;
            dsd = true;
        }
        else
        {
            rb.AddForce(transform.forward);
        }
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log("collision name = " + hitInfo.gameObject.name);
        if (hitInfo.gameObject.name == "Tilemap_SolidBlock")
        {
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.name == "Block")
        {
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.name == "Block (1)")
        {
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.name == "Block (2)")
        {
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.name == "Block (3)")
        {
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.name == "Block (4)")
        {
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.name == "Block (5)")
        {
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.name == "Block (6)")
        {
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.name == "Block (7)")
        {
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.name == "Block (8)")
        {
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.name == "Block (9)")
        {
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.name == "Block (10)")
        {
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.name == "Block (11)")
        {
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.name == "Block (12)")
        {
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.name == "Block (13)")
        {
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.name == "Block (14)")
        {
            Destroy(gameObject);
        }
    }
}