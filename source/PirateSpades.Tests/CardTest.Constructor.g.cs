// <copyright file="CardTest.Constructor.g.cs">Copyright �  2011</copyright>
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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;
using Microsoft.Pex.Engine.Exceptions;

namespace PirateSpades.GameLogicV2
{
    public partial class CardTest {
[TestMethod]
[PexGeneratedBy(typeof(CardTest))]
public void Constructor692()
{
    Card card;
    card = this.Constructor(Suit.Diamonds, CardValue.Two);
    Assert.IsNotNull((object)card);
    Assert.AreEqual<CardValue>(CardValue.Two, card.Value);
    Assert.AreEqual<Suit>(Suit.Diamonds, card.Suit);
}
[TestMethod]
[PexGeneratedBy(typeof(CardTest))]
[PexRaisedContractException(PexExceptionState.Expected)]
public void ConstructorThrowsContractException633()
{
    try
    {
      Card card;
      card = this.Constructor(Suit.Diamonds, (CardValue)0);
      throw 
        new AssertFailedException("expected an exception of type ContractException");
    }
    catch(Exception ex)
    {
      if (!PexContract.IsContractException(ex))
        throw ex;
    }
}
[TestMethod]
[PexGeneratedBy(typeof(CardTest))]
[PexRaisedContractException(PexExceptionState.Expected)]
public void ConstructorThrowsContractException212()
{
    try
    {
      Card card;
      card = this.Constructor((Suit)0, (CardValue)0);
      throw 
        new AssertFailedException("expected an exception of type ContractException");
    }
    catch(Exception ex)
    {
      if (!PexContract.IsContractException(ex))
        throw ex;
    }
}
    }
}
