using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required for the uGUI classes like Text

public class GameOverUI : MonoBehaviour {
    private Text txt;
    private Bartok bartok;

    private void Awake()
    {
        txt = GetComponent<Text>();
        bartok = GetComponent<Bartok>();
        txt.text = "";
    }

    private void Update()
    {
        if (Bartok.S.phase != TurnPhase.gameOver)
        {
            txt.text = "";
            return;
        }
        // We only get here if the game is over
        if (bartok.players[0].score == bartok.min )
        {
            txt.text = "You won!";
        }
        else
        {
            txt.text = "Game Over";
        }
    }
}
