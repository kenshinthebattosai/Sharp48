﻿using System.Linq;
using Sharp48.Core.Moves;
using Sharp48.Core.PlayArea;
using Sharp48.Solvers.Extensions;
using Xunit;

namespace Sharp48.Solvers.Tests.Extensions
{
    public class RowMoveExtensionsTests
    {

        [Theory]
        [InlineData("2,,,", true)]
        [InlineData("2,2,,", true)]
        [InlineData("2,,,2", true)]
        [InlineData("2,2,,2", true)]
        [InlineData(",,,2", false)]
        [InlineData(",,4,2", false)]
        public void RightMoveExists(string row, bool exists)
        {
            // Arrange
            var squares = Row.Parse(row);

            // Act
            var actual = squares.GetPossibleMoves().Contains(Move.Right);

            // Assert
            Assert.Equal(exists, actual);
        }

        [Theory]
        [InlineData("2,,,", false)]
        [InlineData("2,2,,", true)]
        [InlineData("2,,,2", true)]
        [InlineData("2,2,,2", true)]
        [InlineData(",,,2", true)]
        [InlineData(",,4,2", true)]
        public void LeftMoveExists(string row, bool exists)
        {
            // Arrange
            var squares = Row.Parse(row);

            // Act
            var actual = squares.GetPossibleMoves().Contains(Move.Left);

            // Assert
            Assert.Equal(exists, actual);
        }
    }
}