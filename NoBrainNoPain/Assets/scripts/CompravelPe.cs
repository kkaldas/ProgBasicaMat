﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompravelPe : Compravel
{
    protected void Start()
    {
        if (Comprou.pes >= qtdLimite)
        {
            gameObject.SetActive(false);
        }
    }
    protected override void Efeito()
    {
        Comprou.pes = Comprou.pes + 1;
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        PlayerWalk playerWalk = player.GetComponent<PlayerWalk>();
        int pesQtdd = Comprou.pes;
        while (pesQtdd > 0)
        {
            playerWalk.IncreaseSpeed(1);
            pesQtdd -= 1;
        }
    }
}

