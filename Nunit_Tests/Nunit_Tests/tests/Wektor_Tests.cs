﻿using NUnit.Framework;
using Nunit_Tests.main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit_Tests.test
{
    [TestFixture]
    public class Wektor_Tests
    {
        Wektor W, W2, W3;

        [SetUp]
        public void Init()
        {
            W = new Wektor(1, 2, 3);
            W2 = new Wektor(5, 5, 5);
            W3 = new Wektor(3, 2);
        }

        [Test]
        public void Add_Wektors_Test()
        {
            W = W + W;
            Assert.AreEqual(W, new Wektor(2, 4, 6));
        }

        [Test]
        public void Sub_Wektors_Test()
        {
            W2 = W2 - W;
            Assert.AreEqual(W2, new Wektor(4, 3, 2));
        }

        [Test]
        public void Mul_Wektors_Test()
        {
            W = W * W2;
            Assert.AreEqual(W, new Wektor(5, 10, 15));
            W = W * W3;
            Assert.AreEqual(W, new Wektor(15,20));
        }

        [Test]
        public void Add_All_Test()
        {
            W.Add_all(4);
            Assert.AreEqual(W, new Wektor(5, 6, 7));
        }

        [Test]
        public void Sub_All_Test()
        {
            W.Sub_all(4);
            Assert.AreEqual(W, new Wektor(-3, -2, -1));
        }

        [Test]
        public void Mul_All_Test()
        {
            W.Mul_all(4);
            Assert.AreEqual(W, new Wektor(4, 8, 12));
        }

        [Test]
        public void Change_All_Test()
        {
            W.Change_all(0, -8, 15);
            Assert.AreEqual(W, new Wektor(1, -6, 18));
        }




    }
}
