// <copyright file="PirateClientCommandsTest.PlayCard.g.cs">Copyright �  2011</copyright>
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
using PirateSpades.GameLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;
using Microsoft.Pex.Engine.Exceptions;

namespace PirateSpades.Network
{
    public partial class PirateClientCommandsTest {
[TestMethod]
[PexGeneratedBy(typeof(PirateClientCommandsTest))]
[PexRaisedContractException(PexExceptionState.Expected)]
public void PlayCardThrowsContractException752()
{
    try
    {
      this.PlayCard((PirateClient)null, (Card)null);
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
