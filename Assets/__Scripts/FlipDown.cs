using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipDown : MonoBehaviour
{
    public Player player;

    public void FlipDownCards()
    {
        player.hand[0].faceUp = false;
        player.hand[3].faceUp = false;
    }
}
