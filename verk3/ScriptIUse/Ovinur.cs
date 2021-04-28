using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Ovinur : MonoBehaviour
{
    public static int kills = 0;
    public Transform player;
    private Rigidbody rb;
    private Vector3 movement;
    public float hradi = 5f;
    Text texti;
    // Start is called before the first frame update
    void Start()//codi sem telur hvad marga ovinn du drepur
    {
        texti= GameObject.Find("KS").GetComponent<Text>();///etta
        rb = this.GetComponent<Rigidbody>();
        texti.text = "Kill Streak " + kills.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 stefna = player.position - transform.position;
        stefna.Normalize();
        movement = stefna;
    }
    private void FixedUpdate()
    {
        Hreyfing(movement);
    }
    void Hreyfing(Vector3 stefna)
    {
        rb.MovePosition(transform.position + (stefna * hradi * Time.deltaTime));
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag=="Bullet")//ef bullet hittir ovinn fae eg +1 i kills 
        {
            kills += 1;
            texti.text = "Kill Streak " + kills.ToString();
        }
    }
        
}
