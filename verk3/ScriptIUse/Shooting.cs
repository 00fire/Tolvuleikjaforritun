using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 100f;
    
    // Update is called once per frame+void
   
 /*   void Start()
{
    StartCoroutine(waiter());
}
    
    IEnumerator waiter()
{
    
    //Wait for 4 seconds
    yield return new WaitForSeconds(4);

   
}*/
    void Update()
    {// deggar er mus 1 er ytt a bir da til skot 
        if ((Input.GetMouseButtonDown(0)== true))//while
        {
            Debug.Log("skjOtttttttt");       
            //waiter();
            //GameObject instBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            GameObject instBullet = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
            Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
            instBulletRigidbody.AddForce(transform.forward * speed);
            Destroy(instBullet, 3.5f);//kúl eeytt eftir 0.5sek
           
        }
    }
}
