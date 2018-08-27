using System;
using Shouldly;
using Xunit;
using BinarySearchTree;

namespace UnitTest
{

 // Question
    /*
    Binary search tree (BST) is a binary tree where the value of each node is larger or equal to the values in all the nodes in that node's left subtree and is smaller than the values in all the nodes in that node's right subtree.

    Write a function that checks if a given binary search tree contains a given value.

    For example, for the following tree:

    n1 (Value: 1, Left: null, Right: null)
    n2 (Value: 2, Left: n1, Right: n3)
    n3 (Value: 3, Left: null, Right: null)
    Call to Contains(n2, 3) should return true since a tree with root at n2 contains number 3.
                (2)
                / \
              (1) (3)
    */

    public class BinarySearchTest{
        
        private BinaryTree _cut;

        [Fact]
        public void VerifyContains()
        {
            var n1 = new Node(1, null,null);
            var n3 = new Node(3, null, null);
            var n2 = new Node(2, n1, n3);
            _cut = new BinaryTree();
            var found = _cut.Contains(n2, 3);

            found.ShouldBe(true);

        }
    }

}