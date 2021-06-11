using Chess.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chess;
using System;

namespace ChessProject
{
    [TestClass]
    public class ChessTest
    {

        public ChessTest()
        {
        }

        [TestMethod]
        public void ValidPhoneNumberMustHave7Digits()
        {
            var chess = new Chess(Piece.Rook);
            var isValid = chess.ValidPhoneNumber("123456");
            Assert.AreEqual(isValid, false);
        }

        [TestMethod]
        public void ValidPhoneNumberMustHaveValidPiece()
        {
            var chess = new Chess(Piece.Queen);
            Assert.ThrowsException<InvalidOperationException>(() => chess.ValidPhoneNumber("1234567"));
        }

        [TestMethod]
        public void ValidPhoneNumberStartWithZero()
        {
            var chess = new Chess(Piece.Rook);
            var isValid = chess.ValidPhoneNumber("0123456");
            Assert.AreEqual(isValid, false);
        }

        [TestMethod]
        public void ValidPhoneNumberNotStartWithZero()
        {
            var chess = new Chess(Piece.Rook);
            var isValid = chess.ValidPhoneNumber("4780236");
            Assert.AreEqual(isValid, false);
        }

        [TestMethod]
        public void ValidPhoneNumberTestDigit2()
        {
            var chess = new Chess(Piece.Rook);
            var isValid = chess.ValidPhoneNumber("2368974");
            Assert.AreEqual(isValid, false);
        }

        [TestMethod]
        public void ValidPhoneNumberTestDigit3()
        {
            var chess = new Chess(Piece.Rook);
            var isValid = chess.ValidPhoneNumber("3145289");
            Assert.AreEqual(isValid, false);
        }

        [TestMethod]
        public void ValidPhoneNumberTestValidDigit8()
        {
            var chess = new Chess(Piece.Rook);
            var isValid = chess.ValidPhoneNumber("8796541");
            Assert.AreEqual(isValid, true);
        }

        [TestMethod]
        public void ValidPhoneNumberTestValidDigit7()
        {
            var chess = new Chess(Piece.Rook);
            var isValid = chess.ValidPhoneNumber("7896321");
            Assert.AreEqual(isValid, true);
        }

        [TestMethod]
        public void ValidPhoneNumberTestValidDigit2()
        {
            var chess = new Chess(Piece.Rook);
            var isValid = chess.ValidPhoneNumber("2314789");
            Assert.AreEqual(isValid, true);
        }

    }
}
