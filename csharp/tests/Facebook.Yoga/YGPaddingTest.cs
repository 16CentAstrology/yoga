/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

// @generated by gentest/gentest.rb from gentest/fixtures/YGPaddingTest.html

using System;
using NUnit.Framework;

namespace Facebook.Yoga
{
    [TestFixture]
    public class YGPaddingTest
    {
        [Test]
        public void Test_padding_no_size()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.PaddingLeft = 10;
            root.PaddingTop = 10;
            root.PaddingRight = 10;
            root.PaddingBottom = 10;
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(20f, root.LayoutWidth);
            Assert.AreEqual(20f, root.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(20f, root.LayoutWidth);
            Assert.AreEqual(20f, root.LayoutHeight);
        }

        [Test]
        public void Test_padding_container_match_child()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.PaddingLeft = 10;
            root.PaddingTop = 10;
            root.PaddingRight = 10;
            root.PaddingBottom = 10;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.Width = 10;
            root_child0.Height = 10;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(30f, root.LayoutWidth);
            Assert.AreEqual(30f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(30f, root.LayoutWidth);
            Assert.AreEqual(30f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_padding_flex_child()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.PaddingLeft = 10;
            root.PaddingTop = 10;
            root.PaddingRight = 10;
            root.PaddingBottom = 10;
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.FlexGrow = 1;
            root_child0.Width = 10;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(80f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(80f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(80f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_padding_stretch_child()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.PaddingLeft = 10;
            root.PaddingTop = 10;
            root.PaddingRight = 10;
            root.PaddingBottom = 10;
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.Height = 10;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(80f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(80f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_padding_center_child()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.JustifyContent = YogaJustify.Center;
            root.AlignItems = YogaAlign.Center;
            root.PaddingStart = 10;
            root.PaddingEnd = 20;
            root.PaddingBottom = 20;
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.Width = 10;
            root_child0.Height = 10;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(40f, root_child0.LayoutX);
            Assert.AreEqual(35f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(50f, root_child0.LayoutX);
            Assert.AreEqual(35f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_child_with_padding_align_end()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.JustifyContent = YogaJustify.FlexEnd;
            root.AlignItems = YogaAlign.FlexEnd;
            root.Width = 200;
            root.Height = 200;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.PaddingLeft = 20;
            root_child0.PaddingTop = 20;
            root_child0.PaddingRight = 20;
            root_child0.PaddingBottom = 20;
            root_child0.Width = 100;
            root_child0.Height = 100;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(200f, root.LayoutWidth);
            Assert.AreEqual(200f, root.LayoutHeight);

            Assert.AreEqual(100f, root_child0.LayoutX);
            Assert.AreEqual(100f, root_child0.LayoutY);
            Assert.AreEqual(100f, root_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(200f, root.LayoutWidth);
            Assert.AreEqual(200f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(100f, root_child0.LayoutY);
            Assert.AreEqual(100f, root_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0.LayoutHeight);
        }

    }
}
