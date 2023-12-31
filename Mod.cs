﻿using HarmonyLib;
using System;
using System.Collections;
using UnityEngine;

namespace InfernityTestingModNS
{
    public class InfernityTestingMod : Mod
    {
        public override void Ready()
        {
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "infernitytestingmod_blueprint_golden_berry", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.BasicBuildingIdea, "infernitytestingmod_blueprint_generator", 1);
            Logger.Log("Ready!");
        }
    }

    public class Generator : CardData
    
    {
        protected override bool CanHaveCard(CardData otherCard)
        {
            if (otherCard.Id is "wood" or "stick" or "plank" or "charcoal")
            {
                return true;
            }
            return base.CanHaveCard(otherCard);
        }

        public override bool CanHaveCardsWhileHasStatus()
        {
            return true;
        }
        public override bool DetermineCanHaveCardsWhenIsRoot => true;
    }

}