// <copyright file="PirateMessageTest.GetHostIp.g.cs">Copyright �  2011</copyright>
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
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;
using Microsoft.Pex.Engine.Exceptions;

namespace PirateSpades.Network
{
    public partial class PirateMessageTest {
[TestMethod]
[PexGeneratedBy(typeof(PirateMessageTest))]
[PexRaisedContractException(PexExceptionState.Expected)]
public void GetHostIpThrowsContractException656()
{
    try
    {
      PirateMessage pirateMessage;
      IPAddress iPAddress;
      pirateMessage = new PirateMessage(PirateMessageHead.Fail, "host_ip: 00.0.0.");
      iPAddress = this.GetHostIp(pirateMessage);
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
public void GetHostIpThrowsContractException761()
{
    try
    {
      PirateMessage pirateMessage;
      IPAddress iPAddress;
      pirateMessage = new PirateMessage(PirateMessageHead.Fail, "host_ip: 00.0.0..");
      iPAddress = this.GetHostIp(pirateMessage);
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
public void GetHostIpThrowsContractException240()
{
    try
    {
      PirateMessage pirateMessage;
      IPAddress iPAddress;
      pirateMessage = new PirateMessage(PirateMessageHead.Fail, "host_ip: .");
      iPAddress = this.GetHostIp(pirateMessage);
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
public void GetHostIpThrowsContractException713()
{
    try
    {
      PirateMessage pirateMessage;
      IPAddress iPAddress;
      pirateMessage = new PirateMessage(PirateMessageHead.Fail, "host_ip: 0");
      iPAddress = this.GetHostIp(pirateMessage);
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
public void GetHostIpThrowsContractException179()
{
    try
    {
      PirateMessage pirateMessage;
      IPAddress iPAddress;
      pirateMessage = new PirateMessage(PirateMessageHead.Fail, "");
      iPAddress = this.GetHostIp(pirateMessage);
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
public void GetHostIpThrowsContractException250()
{
    try
    {
      IPAddress iPAddress;
      iPAddress = this.GetHostIp((PirateMessage)null);
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