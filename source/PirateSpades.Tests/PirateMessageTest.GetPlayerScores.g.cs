// <copyright file="PirateMessageTest.GetPlayerScores.g.cs">Copyright �  2011</copyright>
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
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;
using Microsoft.Pex.Engine.Exceptions;

namespace PirateSpades.Network
{
    public partial class PirateMessageTest {
[TestMethod]
[PexGeneratedBy(typeof(PirateMessageTest))]
public void GetPlayerScores82()
{
    PirateMessage pirateMessage;
    Dictionary<string, int> dictionary;
    pirateMessage =
      new PirateMessage(PirateMessageHead.Fail, "player_score: \u0100;0\0");
    dictionary = this.GetPlayerScores(pirateMessage);
    Assert.IsNotNull((object)dictionary);
    Assert.IsNotNull(dictionary.Comparer);
    Assert.AreEqual<int>(0, dictionary.Count);
}
[TestMethod]
[PexGeneratedBy(typeof(PirateMessageTest))]
public void GetPlayerScores487()
{
    PirateMessage pirateMessage;
    Dictionary<string, int> dictionary;
    pirateMessage =
      new PirateMessage(PirateMessageHead.Fail, "player_score: \u0100;0");
    dictionary = this.GetPlayerScores(pirateMessage);
    Assert.IsNotNull((object)dictionary);
    Assert.IsNotNull(dictionary.Comparer);
    Assert.AreEqual<int>(1, dictionary.Count);
}
[TestMethod]
[PexGeneratedBy(typeof(PirateMessageTest))]
public void GetPlayerScores329()
{
    PirateMessage pirateMessage;
    Dictionary<string, int> dictionary;
    pirateMessage =
      new PirateMessage(PirateMessageHead.Fail, "player_score: \u00e2;-");
    dictionary = this.GetPlayerScores(pirateMessage);
    Assert.IsNotNull((object)dictionary);
    Assert.IsNotNull(dictionary.Comparer);
    Assert.AreEqual<int>(0, dictionary.Count);
}
[TestMethod]
[PexGeneratedBy(typeof(PirateMessageTest))]
public void GetPlayerScores772()
{
    PirateMessage pirateMessage;
    Dictionary<string, int> dictionary;
    pirateMessage =
      new PirateMessage(PirateMessageHead.Fail, "player_score: \u00e2\0");
    dictionary = this.GetPlayerScores(pirateMessage);
    Assert.IsNotNull((object)dictionary);
    Assert.IsNotNull(dictionary.Comparer);
    Assert.AreEqual<int>(0, dictionary.Count);
}
[TestMethod]
[PexGeneratedBy(typeof(PirateMessageTest))]
public void GetPlayerScores306()
{
    PirateMessage pirateMessage;
    Dictionary<string, int> dictionary;
    pirateMessage = new PirateMessage(PirateMessageHead.Fail, "player_score: x");
    dictionary = this.GetPlayerScores(pirateMessage);
    Assert.IsNotNull((object)dictionary);
    Assert.IsNotNull(dictionary.Comparer);
    Assert.AreEqual<int>(0, dictionary.Count);
}
[TestMethod]
[PexGeneratedBy(typeof(PirateMessageTest))]
public void GetPlayerScores409()
{
    PirateMessage pirateMessage;
    Dictionary<string, int> dictionary;
    pirateMessage = new PirateMessage(PirateMessageHead.Fail, "player_score: \0");
    dictionary = this.GetPlayerScores(pirateMessage);
    Assert.IsNotNull((object)dictionary);
    Assert.IsNotNull(dictionary.Comparer);
    Assert.AreEqual<int>(0, dictionary.Count);
}
[TestMethod]
[PexGeneratedBy(typeof(PirateMessageTest))]
public void GetPlayerScores630()
{
    PirateMessage pirateMessage;
    Dictionary<string, int> dictionary;
    pirateMessage = new PirateMessage(PirateMessageHead.Fail, "player_score: ");
    dictionary = this.GetPlayerScores(pirateMessage);
    Assert.IsNotNull((object)dictionary);
    Assert.IsNotNull(dictionary.Comparer);
    Assert.AreEqual<int>(0, dictionary.Count);
}
[TestMethod]
[PexGeneratedBy(typeof(PirateMessageTest))]
public void GetPlayerScores544()
{
    PirateMessage pirateMessage;
    Dictionary<string, int> dictionary;
    pirateMessage = new PirateMessage(PirateMessageHead.Fail, new string('\0', 14));
    dictionary = this.GetPlayerScores(pirateMessage);
    Assert.IsNotNull((object)dictionary);
    Assert.IsNotNull(dictionary.Comparer);
    Assert.AreEqual<int>(0, dictionary.Count);
}
[TestMethod]
[PexGeneratedBy(typeof(PirateMessageTest))]
public void GetPlayerScores828()
{
    PirateMessage pirateMessage;
    Dictionary<string, int> dictionary;
    pirateMessage = new PirateMessage(PirateMessageHead.Fail, "");
    dictionary = this.GetPlayerScores(pirateMessage);
    Assert.IsNotNull((object)dictionary);
    Assert.IsNotNull(dictionary.Comparer);
    Assert.AreEqual<int>(0, dictionary.Count);
}
[TestMethod]
[PexGeneratedBy(typeof(PirateMessageTest))]
[PexRaisedContractException(PexExceptionState.Expected)]
public void GetPlayerScoresThrowsContractException799()
{
    try
    {
      Dictionary<string, int> dictionary;
      dictionary = this.GetPlayerScores((PirateMessage)null);
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
