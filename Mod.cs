using HarmonyLib;
using System;
using System.Collections;
using UnityEngine;

namespace myCardsNS
{
    public class myCards : Mod
    {
        public override void Ready()
        {
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "examplemod_blueprint_golden_berry", 1);
            Logger.Log("Ready!");
        }
    }
}