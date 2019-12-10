using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required for the uGUI classes like Text

public class RoundResultUI : MonoBehaviour {
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
        if(Bartok.S.phase != TurnPhase.gameOver)
        {
            txt.text = "";
            return;
        }
        // We only get here if the game is over
        if (bartok.players[1].score == bartok.min)
        {
            txt.text = "Player " + "1" + " won";
        }
        if (bartok.players[2].score == bartok.min)
        {
            txt.text = "Player " + "2" + " won";
        }
        if (bartok.players[3].score == bartok.min)
        {
            txt.text = "Player " + "3" + " won";
        }
    }
}
