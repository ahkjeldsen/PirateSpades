// <copyright file="CollectionFncTest.PickRandom03.g.cs">Copyright �  2011</copyright>
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

namespace PirateSpades.Misc
{
    public partial class CollectionFncTest {
[TestMethod]
[PexGeneratedBy(typeof(CollectionFncTest))]
public void PickRandom03208()
{
    int i;
    i = this.PickRandom03(1, 1);
    Assert.AreEqual<int>(1, i);
}
[TestMethod]
[PexGeneratedBy(typeof(CollectionFncTest))]
public void PickRandom03381()
{
    int i;
    i = this.PickRandom03(0, 0);
    Assert.AreEqual<int>(0, i);
}
    }
}
