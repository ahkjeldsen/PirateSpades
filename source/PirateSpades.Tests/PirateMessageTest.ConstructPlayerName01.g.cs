// <copyright file="PirateMessageTest.ConstructPlayerName01.g.cs">Copyright �  2011</copyright>
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
using PirateSpades.GameLogic;

namespace PirateSpades.Network
{
    public partial class PirateMessageTest {
[TestMethod]
[PexGeneratedBy(typeof(PirateMessageTest))]
public void ConstructPlayerName01605()
{
    string s;
    s = this.ConstructPlayerName01("");
    Assert.AreEqual<string>("player_name: ", s);
}
[TestMethod]
[PexGeneratedBy(typeof(PirateMessageTest))]
[PexRaisedContractException(PexExceptionState.Expected)]
public void ConstructPlayerName01ThrowsContractException39()
{
    try
    {
      string s;
      s = this.ConstructPlayerName01((string)null);
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
public void ConstructPlayerNameThrowsContractException621()
{
    try
    {
      string s;
      s = this.ConstructPlayerName((Player)null);
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