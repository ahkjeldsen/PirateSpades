// <copyright file="GameTest.ActiveGet.g.cs">Copyright �  2011</copyright>
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
    public partial class GameTest {
[TestMethod]
[PexGeneratedBy(typeof(GameTest))]
[PexRaisedContractException(PexExceptionState.Expected)]
public void ActiveGetThrowsContractException416()
{
    try
    {
      Game game;
      bool b;
      game = new Game();
      b = this.ActiveGet(game);
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