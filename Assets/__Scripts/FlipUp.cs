using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipUp : MonoBehaviour
{
    public Player player;

    public void FlipUpCards()
    {
        player.hand[0].faceUp = true;
        player.hand[3].faceUp = true;
    }
}