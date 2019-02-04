﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public List<Mole> listMolesObjects;

    void Start()
    {
        PointingSystem.onPressTrigger += MoleWhackDetection;
        PointingSystem.isPointingAtMole += IsPointingAtMole;
        PointingSystem.isExitingMole += IsExitingMole;
    }

    void Update()
    {

    }

    // This function will be called when the user is pressing the trigger on a mole only
    void MoleWhackDetection(Collider mole)
    {
        Mole moleCollided = mole.gameObject.GetComponent<Mole>();
        if (moleCollided)
        {
            moleCollided.isActive = false;
            moleCollided.makeItNormal();
        }
    }

    // This functiom is called when the user is pointing at a mole
    void IsPointingAtMole(Collider mole)
    {
        Mole moleCollided = mole.gameObject.GetComponent<Mole>();
        if (moleCollided)
        {
            moleCollided.glow();
        }
    }

    // This function is called when the user is  exiting the  mole with the controller pointer
    void IsExitingMole(Collider mole)
    {
        print(mole);
    }
}
