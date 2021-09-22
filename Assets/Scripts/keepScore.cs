using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class keepScore : MonoBehaviour
{
    public TextMeshPro scoreText;
    private static int score;

    // Take static score and put on score board.
    void Update()
    {
        score = DestroyPlanet.score;
        scoreText.text = "Planets Destroyed: " + score.ToString("#");

    }
}
