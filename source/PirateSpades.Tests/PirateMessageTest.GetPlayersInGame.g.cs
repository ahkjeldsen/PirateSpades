// <copyright file="PirateMessageTest.GetPlayersInGame.g.cs">Copyright �  2011</copyright>
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

namespace PirateSpades.Network
{
    public partial class PirateMessageTest {
[TestMethod]
[PexGeneratedBy(typeof(PirateMessageTest))]
public void GetPlayersInGame777()
{
    PirateMessage pirateMessage;
    int i;
    pirateMessage = new PirateMessage(PirateMessageHead.Fail, "players_ingame: 0");
    i = this.GetPlayersInGame(pirateMessage);
    Assert.AreEqual<int>(0, i);
}
[TestMethod]
[PexGeneratedBy(typeof(PirateMessageTest))]
[PexRaisedContractException(PexExceptionState.Expected)]
public void GetPlayersInGameThrowsContractException457()
{
    try
    {
      PirateMessage pirateMessage;
      int i;
      pirateMessage = new PirateMessage(PirateMessageHead.Fail, "");
      i = this.GetPlayersInGame(pirateMessage);
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
[PexGeneratedBy(typeof(PirateMessageTest))]
[PexRaisedContractException(PexExceptionState.Expected)]
public void GetPlayersInGameThrowsContractException673()
{
    try
    {
      int i;
      i = this.GetPlayersInGame((PirateMessage)null);
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
