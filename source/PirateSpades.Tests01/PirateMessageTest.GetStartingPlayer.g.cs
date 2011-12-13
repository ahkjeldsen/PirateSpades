// <copyright file="PirateMessageTest.GetStartingPlayer.g.cs">Copyright �  2011</copyright>
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
public void GetStartingPlayer6001()
{
    PirateMessage pirateMessage;
    string s;
    pirateMessage = new PirateMessage(PirateMessageHead.Fail, "starting_player: 00");
    s = this.GetStartingPlayer(pirateMessage);
    Assert.AreEqual<string>("00", s);
}
[TestMethod]
[PexGeneratedBy(typeof(PirateMessageTest))]
public void GetStartingPlayer60()
{
    PirateMessage pirateMessage;
    string s;
    pirateMessage = new PirateMessage(PirateMessageHead.Fail, "starting_player: 0");
    s = this.GetStartingPlayer(pirateMessage);
    Assert.AreEqual<string>("0", s);
}
[TestMethod]
[PexGeneratedBy(typeof(PirateMessageTest))]
[PexRaisedContractException(PexExceptionState.Expected)]
public void GetStartingPlayerThrowsContractException176()
{
    try
    {
      PirateMessage pirateMessage;
      string s;
      pirateMessage = new PirateMessage(PirateMessageHead.Fail, "");
      s = this.GetStartingPlayer(pirateMessage);
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
public void GetStartingPlayerThrowsContractException319()
{
    try
    {
      string s;
      s = this.GetStartingPlayer((PirateMessage)null);
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
