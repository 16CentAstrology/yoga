/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

// @generated by gentest/gentest.rb from gentest/fixtures/YGBorderTest.html

package com.facebook.yoga;

import static org.junit.Assert.assertEquals;

import org.junit.Test;
import org.junit.runner.RunWith;
import org.junit.runners.Parameterized;

@RunWith(Parameterized.class)
public class YGBorderTest {
  @Parameterized.Parameters(name = "{0}")
  public static Iterable<TestParametrization.NodeFactory> nodeFactories() {
    return TestParametrization.nodeFactories();
  }

  @Parameterized.Parameter public TestParametrization.NodeFactory mNodeFactory;

  @Test
  public void test_border_no_size() {
    YogaConfig config = YogaConfigFactory.create();

    final YogaNode root = createNode(config);
    root.setBorder(YogaEdge.LEFT, 10f);
    root.setBorder(YogaEdge.TOP, 10f);
    root.setBorder(YogaEdge.RIGHT, 10f);
    root.setBorder(YogaEdge.BOTTOM, 10f);
    root.setDirection(YogaDirection.LTR);
    root.calculateLayout(YogaConstants.UNDEFINED, YogaConstants.UNDEFINED);

    assertEquals(0f, root.getLayoutX(), 0.0f);
    assertEquals(0f, root.getLayoutY(), 0.0f);
    assertEquals(20f, root.getLayoutWidth(), 0.0f);
    assertEquals(20f, root.getLayoutHeight(), 0.0f);

    root.setDirection(YogaDirection.RTL);
    root.calculateLayout(YogaConstants.UNDEFINED, YogaConstants.UNDEFINED);

    assertEquals(0f, root.getLayoutX(), 0.0f);
    assertEquals(0f, root.getLayoutY(), 0.0f);
    assertEquals(20f, root.getLayoutWidth(), 0.0f);
    assertEquals(20f, root.getLayoutHeight(), 0.0f);
  }

  @Test
  public void test_border_container_match_child() {
    YogaConfig config = YogaConfigFactory.create();

    final YogaNode root = createNode(config);
    root.setBorder(YogaEdge.LEFT, 10f);
    root.setBorder(YogaEdge.TOP, 10f);
    root.setBorder(YogaEdge.RIGHT, 10f);
    root.setBorder(YogaEdge.BOTTOM, 10f);

    final YogaNode root_child0 = createNode(config);
    root_child0.setWidth(10f);
    root_child0.setHeight(10f);
    root.addChildAt(root_child0, 0);
    root.setDirection(YogaDirection.LTR);
    root.calculateLayout(YogaConstants.UNDEFINED, YogaConstants.UNDEFINED);

    assertEquals(0f, root.getLayoutX(), 0.0f);
    assertEquals(0f, root.getLayoutY(), 0.0f);
    assertEquals(30f, root.getLayoutWidth(), 0.0f);
    assertEquals(30f, root.getLayoutHeight(), 0.0f);

    assertEquals(10f, root_child0.getLayoutX(), 0.0f);
    assertEquals(10f, root_child0.getLayoutY(), 0.0f);
    assertEquals(10f, root_child0.getLayoutWidth(), 0.0f);
    assertEquals(10f, root_child0.getLayoutHeight(), 0.0f);

    root.setDirection(YogaDirection.RTL);
    root.calculateLayout(YogaConstants.UNDEFINED, YogaConstants.UNDEFINED);

    assertEquals(0f, root.getLayoutX(), 0.0f);
    assertEquals(0f, root.getLayoutY(), 0.0f);
    assertEquals(30f, root.getLayoutWidth(), 0.0f);
    assertEquals(30f, root.getLayoutHeight(), 0.0f);

    assertEquals(10f, root_child0.getLayoutX(), 0.0f);
    assertEquals(10f, root_child0.getLayoutY(), 0.0f);
    assertEquals(10f, root_child0.getLayoutWidth(), 0.0f);
    assertEquals(10f, root_child0.getLayoutHeight(), 0.0f);
  }

  @Test
  public void test_border_flex_child() {
    YogaConfig config = YogaConfigFactory.create();

    final YogaNode root = createNode(config);
    root.setBorder(YogaEdge.LEFT, 10f);
    root.setBorder(YogaEdge.TOP, 10f);
    root.setBorder(YogaEdge.RIGHT, 10f);
    root.setBorder(YogaEdge.BOTTOM, 10f);
    root.setWidth(100f);
    root.setHeight(100f);

    final YogaNode root_child0 = createNode(config);
    root_child0.setFlexGrow(1f);
    root_child0.setWidth(10f);
    root.addChildAt(root_child0, 0);
    root.setDirection(YogaDirection.LTR);
    root.calculateLayout(YogaConstants.UNDEFINED, YogaConstants.UNDEFINED);

    assertEquals(0f, root.getLayoutX(), 0.0f);
    assertEquals(0f, root.getLayoutY(), 0.0f);
    assertEquals(100f, root.getLayoutWidth(), 0.0f);
    assertEquals(100f, root.getLayoutHeight(), 0.0f);

    assertEquals(10f, root_child0.getLayoutX(), 0.0f);
    assertEquals(10f, root_child0.getLayoutY(), 0.0f);
    assertEquals(10f, root_child0.getLayoutWidth(), 0.0f);
    assertEquals(80f, root_child0.getLayoutHeight(), 0.0f);

    root.setDirection(YogaDirection.RTL);
    root.calculateLayout(YogaConstants.UNDEFINED, YogaConstants.UNDEFINED);

    assertEquals(0f, root.getLayoutX(), 0.0f);
    assertEquals(0f, root.getLayoutY(), 0.0f);
    assertEquals(100f, root.getLayoutWidth(), 0.0f);
    assertEquals(100f, root.getLayoutHeight(), 0.0f);

    assertEquals(80f, root_child0.getLayoutX(), 0.0f);
    assertEquals(10f, root_child0.getLayoutY(), 0.0f);
    assertEquals(10f, root_child0.getLayoutWidth(), 0.0f);
    assertEquals(80f, root_child0.getLayoutHeight(), 0.0f);
  }

  @Test
  public void test_border_stretch_child() {
    YogaConfig config = YogaConfigFactory.create();

    final YogaNode root = createNode(config);
    root.setBorder(YogaEdge.LEFT, 10f);
    root.setBorder(YogaEdge.TOP, 10f);
    root.setBorder(YogaEdge.RIGHT, 10f);
    root.setBorder(YogaEdge.BOTTOM, 10f);
    root.setWidth(100f);
    root.setHeight(100f);

    final YogaNode root_child0 = createNode(config);
    root_child0.setHeight(10f);
    root.addChildAt(root_child0, 0);
    root.setDirection(YogaDirection.LTR);
    root.calculateLayout(YogaConstants.UNDEFINED, YogaConstants.UNDEFINED);

    assertEquals(0f, root.getLayoutX(), 0.0f);
    assertEquals(0f, root.getLayoutY(), 0.0f);
    assertEquals(100f, root.getLayoutWidth(), 0.0f);
    assertEquals(100f, root.getLayoutHeight(), 0.0f);

    assertEquals(10f, root_child0.getLayoutX(), 0.0f);
    assertEquals(10f, root_child0.getLayoutY(), 0.0f);
    assertEquals(80f, root_child0.getLayoutWidth(), 0.0f);
    assertEquals(10f, root_child0.getLayoutHeight(), 0.0f);

    root.setDirection(YogaDirection.RTL);
    root.calculateLayout(YogaConstants.UNDEFINED, YogaConstants.UNDEFINED);

    assertEquals(0f, root.getLayoutX(), 0.0f);
    assertEquals(0f, root.getLayoutY(), 0.0f);
    assertEquals(100f, root.getLayoutWidth(), 0.0f);
    assertEquals(100f, root.getLayoutHeight(), 0.0f);

    assertEquals(10f, root_child0.getLayoutX(), 0.0f);
    assertEquals(10f, root_child0.getLayoutY(), 0.0f);
    assertEquals(80f, root_child0.getLayoutWidth(), 0.0f);
    assertEquals(10f, root_child0.getLayoutHeight(), 0.0f);
  }

  @Test
  public void test_border_center_child() {
    YogaConfig config = YogaConfigFactory.create();

    final YogaNode root = createNode(config);
    root.setJustifyContent(YogaJustify.CENTER);
    root.setAlignItems(YogaAlign.CENTER);
    root.setBorder(YogaEdge.START, 10f);
    root.setBorder(YogaEdge.END, 20f);
    root.setBorder(YogaEdge.BOTTOM, 20f);
    root.setWidth(100f);
    root.setHeight(100f);

    final YogaNode root_child0 = createNode(config);
    root_child0.setWidth(10f);
    root_child0.setHeight(10f);
    root.addChildAt(root_child0, 0);
    root.setDirection(YogaDirection.LTR);
    root.calculateLayout(YogaConstants.UNDEFINED, YogaConstants.UNDEFINED);

    assertEquals(0f, root.getLayoutX(), 0.0f);
    assertEquals(0f, root.getLayoutY(), 0.0f);
    assertEquals(100f, root.getLayoutWidth(), 0.0f);
    assertEquals(100f, root.getLayoutHeight(), 0.0f);

    assertEquals(40f, root_child0.getLayoutX(), 0.0f);
    assertEquals(35f, root_child0.getLayoutY(), 0.0f);
    assertEquals(10f, root_child0.getLayoutWidth(), 0.0f);
    assertEquals(10f, root_child0.getLayoutHeight(), 0.0f);

    root.setDirection(YogaDirection.RTL);
    root.calculateLayout(YogaConstants.UNDEFINED, YogaConstants.UNDEFINED);

    assertEquals(0f, root.getLayoutX(), 0.0f);
    assertEquals(0f, root.getLayoutY(), 0.0f);
    assertEquals(100f, root.getLayoutWidth(), 0.0f);
    assertEquals(100f, root.getLayoutHeight(), 0.0f);

    assertEquals(50f, root_child0.getLayoutX(), 0.0f);
    assertEquals(35f, root_child0.getLayoutY(), 0.0f);
    assertEquals(10f, root_child0.getLayoutWidth(), 0.0f);
    assertEquals(10f, root_child0.getLayoutHeight(), 0.0f);
  }

  private YogaNode createNode(YogaConfig config) {
    return mNodeFactory.create(config);
  }
}
