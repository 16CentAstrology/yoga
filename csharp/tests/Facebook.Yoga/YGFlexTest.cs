/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

// @generated by gentest/gentest.rb from gentest/fixtures/YGFlexTest.html

using System;
using NUnit.Framework;

namespace Facebook.Yoga
{
    [TestFixture]
    public class YGFlexTest
    {
        [Test]
        public void Test_flex_basis_flex_grow_column()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.FlexGrow = 1;
            root_child0.FlexBasis = 50;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode(config);
            root_child1.FlexGrow = 1;
            root.Insert(1, root_child1);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(100f, root_child0.LayoutWidth);
            Assert.AreEqual(75f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(75f, root_child1.LayoutY);
            Assert.AreEqual(100f, root_child1.LayoutWidth);
            Assert.AreEqual(25f, root_child1.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(100f, root_child0.LayoutWidth);
            Assert.AreEqual(75f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(75f, root_child1.LayoutY);
            Assert.AreEqual(100f, root_child1.LayoutWidth);
            Assert.AreEqual(25f, root_child1.LayoutHeight);
        }

        [Test]
        public void Test_flex_shrink_flex_grow_row()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.FlexDirection = YogaFlexDirection.Row;
            root.Width = 500;
            root.Height = 500;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.FlexShrink = 1;
            root_child0.Width = 500;
            root_child0.Height = 100;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode(config);
            root_child1.FlexShrink = 1;
            root_child1.Width = 500;
            root_child1.Height = 100;
            root.Insert(1, root_child1);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(500f, root.LayoutWidth);
            Assert.AreEqual(500f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(250f, root_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0.LayoutHeight);

            Assert.AreEqual(250f, root_child1.LayoutX);
            Assert.AreEqual(0f, root_child1.LayoutY);
            Assert.AreEqual(250f, root_child1.LayoutWidth);
            Assert.AreEqual(100f, root_child1.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(500f, root.LayoutWidth);
            Assert.AreEqual(500f, root.LayoutHeight);

            Assert.AreEqual(250f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(250f, root_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(0f, root_child1.LayoutY);
            Assert.AreEqual(250f, root_child1.LayoutWidth);
            Assert.AreEqual(100f, root_child1.LayoutHeight);
        }

        [Test]
        public void Test_flex_shrink_flex_grow_child_flex_shrink_other_child()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.FlexDirection = YogaFlexDirection.Row;
            root.Width = 500;
            root.Height = 500;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.FlexShrink = 1;
            root_child0.Width = 500;
            root_child0.Height = 100;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode(config);
            root_child1.FlexGrow = 1;
            root_child1.FlexShrink = 1;
            root_child1.Width = 500;
            root_child1.Height = 100;
            root.Insert(1, root_child1);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(500f, root.LayoutWidth);
            Assert.AreEqual(500f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(250f, root_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0.LayoutHeight);

            Assert.AreEqual(250f, root_child1.LayoutX);
            Assert.AreEqual(0f, root_child1.LayoutY);
            Assert.AreEqual(250f, root_child1.LayoutWidth);
            Assert.AreEqual(100f, root_child1.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(500f, root.LayoutWidth);
            Assert.AreEqual(500f, root.LayoutHeight);

            Assert.AreEqual(250f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(250f, root_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(0f, root_child1.LayoutY);
            Assert.AreEqual(250f, root_child1.LayoutWidth);
            Assert.AreEqual(100f, root_child1.LayoutHeight);
        }

        [Test]
        public void Test_flex_basis_flex_grow_row()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.FlexDirection = YogaFlexDirection.Row;
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.FlexGrow = 1;
            root_child0.FlexBasis = 50;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode(config);
            root_child1.FlexGrow = 1;
            root.Insert(1, root_child1);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(75f, root_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0.LayoutHeight);

            Assert.AreEqual(75f, root_child1.LayoutX);
            Assert.AreEqual(0f, root_child1.LayoutY);
            Assert.AreEqual(25f, root_child1.LayoutWidth);
            Assert.AreEqual(100f, root_child1.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(25f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(75f, root_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(0f, root_child1.LayoutY);
            Assert.AreEqual(25f, root_child1.LayoutWidth);
            Assert.AreEqual(100f, root_child1.LayoutHeight);
        }

        [Test]
        public void Test_flex_basis_flex_shrink_column()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.FlexShrink = 1;
            root_child0.FlexBasis = 100;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode(config);
            root_child1.FlexBasis = 50;
            root.Insert(1, root_child1);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(100f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(50f, root_child1.LayoutY);
            Assert.AreEqual(100f, root_child1.LayoutWidth);
            Assert.AreEqual(50f, root_child1.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(100f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(50f, root_child1.LayoutY);
            Assert.AreEqual(100f, root_child1.LayoutWidth);
            Assert.AreEqual(50f, root_child1.LayoutHeight);
        }

        [Test]
        public void Test_flex_basis_flex_shrink_row()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.FlexDirection = YogaFlexDirection.Row;
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.FlexShrink = 1;
            root_child0.FlexBasis = 100;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode(config);
            root_child1.FlexBasis = 50;
            root.Insert(1, root_child1);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0.LayoutHeight);

            Assert.AreEqual(50f, root_child1.LayoutX);
            Assert.AreEqual(0f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(100f, root_child1.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(50f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(0f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(100f, root_child1.LayoutHeight);
        }

        [Test]
        public void Test_flex_shrink_to_zero()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.Height = 75;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.Width = 50;
            root_child0.Height = 50;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode(config);
            root_child1.FlexShrink = 1;
            root_child1.Width = 50;
            root_child1.Height = 50;
            root.Insert(1, root_child1);

            YogaNode root_child2 = new YogaNode(config);
            root_child2.Width = 50;
            root_child2.Height = 50;
            root.Insert(2, root_child2);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(50f, root.LayoutWidth);
            Assert.AreEqual(75f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(50f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(0f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child2.LayoutX);
            Assert.AreEqual(50f, root_child2.LayoutY);
            Assert.AreEqual(50f, root_child2.LayoutWidth);
            Assert.AreEqual(50f, root_child2.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(50f, root.LayoutWidth);
            Assert.AreEqual(75f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(50f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(0f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child2.LayoutX);
            Assert.AreEqual(50f, root_child2.LayoutY);
            Assert.AreEqual(50f, root_child2.LayoutWidth);
            Assert.AreEqual(50f, root_child2.LayoutHeight);
        }

        [Test]
        public void Test_flex_basis_overrides_main_size()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.FlexGrow = 1;
            root_child0.FlexBasis = 50;
            root_child0.Height = 20;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode(config);
            root_child1.FlexGrow = 1;
            root_child1.Height = 10;
            root.Insert(1, root_child1);

            YogaNode root_child2 = new YogaNode(config);
            root_child2.FlexGrow = 1;
            root_child2.Height = 10;
            root.Insert(2, root_child2);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(100f, root_child0.LayoutWidth);
            Assert.AreEqual(60f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(60f, root_child1.LayoutY);
            Assert.AreEqual(100f, root_child1.LayoutWidth);
            Assert.AreEqual(20f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child2.LayoutX);
            Assert.AreEqual(80f, root_child2.LayoutY);
            Assert.AreEqual(100f, root_child2.LayoutWidth);
            Assert.AreEqual(20f, root_child2.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(100f, root_child0.LayoutWidth);
            Assert.AreEqual(60f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(60f, root_child1.LayoutY);
            Assert.AreEqual(100f, root_child1.LayoutWidth);
            Assert.AreEqual(20f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child2.LayoutX);
            Assert.AreEqual(80f, root_child2.LayoutY);
            Assert.AreEqual(100f, root_child2.LayoutWidth);
            Assert.AreEqual(20f, root_child2.LayoutHeight);
        }

        [Test]
        public void Test_flex_grow_shrink_at_most()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root.Insert(0, root_child0);

            YogaNode root_child0_child0 = new YogaNode(config);
            root_child0_child0.FlexGrow = 1;
            root_child0_child0.FlexShrink = 1;
            root_child0.Insert(0, root_child0_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(100f, root_child0.LayoutWidth);
            Assert.AreEqual(0f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child0.LayoutX);
            Assert.AreEqual(0f, root_child0_child0.LayoutY);
            Assert.AreEqual(100f, root_child0_child0.LayoutWidth);
            Assert.AreEqual(0f, root_child0_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(100f, root_child0.LayoutWidth);
            Assert.AreEqual(0f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child0.LayoutX);
            Assert.AreEqual(0f, root_child0_child0.LayoutY);
            Assert.AreEqual(100f, root_child0_child0.LayoutWidth);
            Assert.AreEqual(0f, root_child0_child0.LayoutHeight);
        }

        [Test]
        public void Test_flex_grow_less_than_factor_one()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.Width = 200;
            root.Height = 500;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.FlexGrow = 0.2f;
            root_child0.FlexBasis = 40;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode(config);
            root_child1.FlexGrow = 0.2f;
            root.Insert(1, root_child1);

            YogaNode root_child2 = new YogaNode(config);
            root_child2.FlexGrow = 0.4f;
            root.Insert(2, root_child2);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(200f, root.LayoutWidth);
            Assert.AreEqual(500f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(200f, root_child0.LayoutWidth);
            Assert.AreEqual(132f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(132f, root_child1.LayoutY);
            Assert.AreEqual(200f, root_child1.LayoutWidth);
            Assert.AreEqual(92f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child2.LayoutX);
            Assert.AreEqual(224f, root_child2.LayoutY);
            Assert.AreEqual(200f, root_child2.LayoutWidth);
            Assert.AreEqual(184f, root_child2.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(200f, root.LayoutWidth);
            Assert.AreEqual(500f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(200f, root_child0.LayoutWidth);
            Assert.AreEqual(132f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(132f, root_child1.LayoutY);
            Assert.AreEqual(200f, root_child1.LayoutWidth);
            Assert.AreEqual(92f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child2.LayoutX);
            Assert.AreEqual(224f, root_child2.LayoutY);
            Assert.AreEqual(200f, root_child2.LayoutWidth);
            Assert.AreEqual(184f, root_child2.LayoutHeight);
        }

    }
}
