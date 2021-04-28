using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class PointColleter : MonoBehaviour
{
    public static int count = 5;
    public Text countText;

    void OnCollisionEnter(Collision collision)
    {
        // ef player keyrir á object sem heitir hlutur
        if (collision.collider.tag == "coin")
        {
            collision.collider.gameObject.SetActive(false);
            count = count + 1;
           // Debug.Log("Nú er ég komin með " + count);
            SetCountText();//kallar á fallið
        }
        if (collision.collider.tag == "megaPoint")
        {
            collision.collider.gameObject.SetActive(false);
            count = count + 5;
            //Debug.Log("Nú er ég komin með " + count);
            SetCountText();//kallar á fallið
        }
        if (collision.collider.tag == "ovinur")
        {
           
            count = count -1;
            Debug.Log("Nú er ég komin með " + count);
            SetCountText();//kallar á fallið
        }
        
    }
    void SetCountText()
    {
        countText.text = "Points: " + count.ToString();
       
        if (count < 0)
        {
            this.enabled = false;//kemur í veg fyrir að playerinn geti hreyfst áfram eftir dauðan
            countText.text = "Game Over " + count.ToString()+" Points";
            count=0;
            StartCoroutine(Bida());
            
        }
        
    }
    IEnumerator Bida()
    {
        yield return new WaitForSeconds(1);
        Endurræsa();
    }
   
    public void Byrja()
    {
        SceneManager.LoadScene(1);
    }
    public void Endurræsa()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//Level_1
        SceneManager.LoadScene(0);
    }

}
