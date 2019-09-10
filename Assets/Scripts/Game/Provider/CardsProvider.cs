﻿using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.Experimental.AI;

/// <summary>
/// 	Manages Card data
/// </summary>
public class CardsProvider : JsonProvider<Card> {
    
    protected override string GetJsonDataFileName() => "card";

    public Card[] CloneCardsFromDeck(Deck deck)
    {
        var cards = new List<Card>();

        foreach (var card in deck.CardList)
        for (var i = 0; i < card.Value; i++)
        {
            cards.Add(Store[card.Key]);
        }

        var createdCards = Clone(cards.ToArray());
        return createdCards;
    }
}