using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class Bullet : MonoBehaviour
{
    

    public float speed=20f;
    public Rigidbody rb;
    public static int count;
    public Text countText;
    void Start()
    {
        rb.velocity = transform.forward  * speed;//hradin a skotinnu
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.name);
        Debug.Log("konni hér");
       // Ovinur ovinur = collision.collider.GetComponent<Ovinur>();
        if (collision.collider.tag=="ovinur")
        {
            Destroy(collision.gameObject);//"drepur ovinni"
            gameObject.SetActive(false);
            Debug.Log("hitti óvin");
           
           
        }
       
        else if (collision.collider.name != "Player")//
        {
          //  Destroy(gameObject);//eyða kúlunni
           // Debug.Log("kúlu líka eytt eytt");
        }
    }

}
    