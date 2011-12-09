// <copyright file="RoundTest.Constructor.g.cs">Copyright �  2011</copyright>
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
    using PirateSpades.GameLogic;

    public partial class RoundTest {
[TestMethod]
[PexGeneratedBy(typeof(RoundTest))]
[PexRaisedContractException(PexExceptionState.Expected)]
public void ConstructorThrowsContractException332()
{
    try
    {
      Game game;
      Round round;
      game = new Game();
      round = this.Constructor(game, int.MinValue);
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
[PexGeneratedBy(typeof(RoundTest))]
[PexRaisedContractException(PexExceptionState.Expected)]
public void ConstructorThrowsContractException66()
{
    try
    {
      Game game;
      Round round;
      game = new Game();
      round = this.Constructor(game, 0);
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
[PexGeneratedBy(typeof(RoundTest))]
[PexRaisedContractException(PexExceptionState.Expected)]
public void ConstructorThrowsContractException654()
{
    try
    {
      Round round;
      round = this.Constructor((Game)null, 0);
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
