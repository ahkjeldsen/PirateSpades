// <copyright file="CardTest.Equals01.g.cs">Copyright �  2011</copyright>
// <auto-generated>
// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
// </auto-generated>
using System;
using Microsoft.Pex.Framework.Explorable;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

namespace PirateSpades.GameLogicV2
{
    public partial class CardTest {
[TestMethod]
[PexGeneratedBy(typeof(CardTest))]
public void Equals0183()
{
    Card card;
    Card card1;
    bool b;
    card = PexInvariant.CreateInstance<Card>();
    PexInvariant.SetField<CardValue>
        ((object)card, "<Value>k__BackingField", CardValue.Three);
    PexInvariant.SetField<Suit>((object)card, "<Suit>k__BackingField", Suit.Clubs);
    PexInvariant.CheckInvariant((object)card);
    card1 = PexInvariant.CreateInstance<Card>();
    PexInvariant.SetField<CardValue>
        ((object)card1, "<Value>k__BackingField", CardValue.Jack);
    PexInvariant.SetField<Suit>
        ((object)card1, "<Suit>k__BackingField", Suit.Diamonds);
    PexInvariant.CheckInvariant((object)card1);
    b = this.Equals01(card1, (object)card);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)card1);
    Assert.AreEqual<CardValue>(CardValue.Jack, card1.Value);
    Assert.AreEqual<Suit>(Suit.Diamonds, card1.Suit);
}
[TestMethod]
[PexGeneratedBy(typeof(CardTest))]
public void Equals01686()
{
    Card card;
    bool b;
    card = PexInvariant.CreateInstance<Card>();
    PexInvariant.SetField<CardValue>
        ((object)card, "<Value>k__BackingField", CardValue.Two);
    PexInvariant.SetField<Suit>((object)card, "<Suit>k__BackingField", Suit.Spades);
    PexInvariant.CheckInvariant((object)card);
    b = this.Equals01(card, (object)card);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)card);
    Assert.AreEqual<CardValue>(CardValue.Two, card.Value);
    Assert.AreEqual<Suit>(Suit.Spades, card.Suit);
}
[TestMethod]
[PexGeneratedBy(typeof(CardTest))]
public void Equals01278()
{
    Card card;
    bool b;
    card = PexInvariant.CreateInstance<Card>();
    PexInvariant.SetField<CardValue>
        ((object)card, "<Value>k__BackingField", CardValue.Two);
    PexInvariant.SetField<Suit>
        ((object)card, "<Suit>k__BackingField", Suit.Diamonds);
    PexInvariant.CheckInvariant((object)card);
    b = this.Equals01(card, (object)null);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)card);
    Assert.AreEqual<CardValue>(CardValue.Two, card.Value);
    Assert.AreEqual<Suit>(Suit.Diamonds, card.Suit);
}
    }
}