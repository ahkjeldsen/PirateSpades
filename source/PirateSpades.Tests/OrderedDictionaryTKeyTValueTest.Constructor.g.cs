// <copyright file="OrderedDictionaryTKeyTValueTest.Constructor.g.cs">Copyright �  2011</copyright>
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
using System.Collections.Specialized;
using Microsoft.Pex.Framework.Generated;

namespace PirateSpades.Misc
{
    public partial class OrderedDictionaryTKeyTValueTest {
[TestMethod]
[PexGeneratedBy(typeof(OrderedDictionaryTKeyTValueTest))]
public void Constructor207()
{
    OrderedDictionary<int, int> orderedDictionary;
    orderedDictionary = this.Constructor<int, int>();
    Assert.IsNotNull((object)orderedDictionary);
    Assert.AreEqual<bool>(false, ((OrderedDictionary)orderedDictionary).IsReadOnly);
}
    }
}