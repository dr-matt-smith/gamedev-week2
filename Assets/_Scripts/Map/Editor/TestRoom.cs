using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using System.Threading;

public class TestRoom
{
    [Test]
    public void TestAddItem()
    {
        string item = "Key";
        Room room = new Room();
        room.AddItem(item);
        string actualResult = room.GetItem("Key");
        Assert.AreEqual(item, actualResult);
    }

    [Test]
    public void TestGetItemWhenItemNotInArray()
    {
        Room room = new Room();
        string expectedResult = "item not found";
        string item = room.GetItem("Axe");
        Assert.AreEqual(item, expectedResult);
    }
}
