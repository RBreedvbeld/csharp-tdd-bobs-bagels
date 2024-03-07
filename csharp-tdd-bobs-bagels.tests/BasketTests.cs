using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class BasketTests
{
    private Basket _basket;
    private List<string> _bagelsInBasket;

    [SetUp]
    public void Setup()
    {
        // for each test a new Basket() will be created
        _basket = new Basket();
        _bagelsInBasket = new List<string>();
        // bagel is added to each test.
        _basket.AddBagelToBasket("Spelt Bagel");
    }

    [Test]
    public void TestAddBagelToBasket()
    {
        // setup is done in global setup
        // execute the actual function to test
        bool addedBagel = _basket.AddBagelToBasket("Vegan Bagel");
        //int itemsInBasket = _bagelsInBasket.Count;  
        // Assert test, whether execution is successful ( -> check if results / outputs are ok)
        Assert.That(addedBagel, Is.True);
        Assert.That(_basket, Is.Not.Null);
        // try to see that basket contains 2 items now
       
    }

    [Test]  
    public void TestChangeOrder()
    {
        // setup is done in global setup
        // execute the actual function to test
        bool changeOrder = _basket.ChangeOrder("Spelt Bagel");
        // Assert test, whether execution is successful ( -> check if results / outputs are ok)
        Assert.That(changeOrder, Is.True);

    }
}