using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyPlanet : MonoBehaviour
{
    public static int score;

    //Destory the planet and add 1 to score.
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Planet")
        {
            Debug.Log("Planet Hit!");
            Destroy(collision.gameObject);
            Destroy(this);
            score = score + 1;
        }
    }
}
