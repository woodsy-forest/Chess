using Chess.Enums;
using System;

namespace ChessProject
{
    public class Chess 
    {
        private Piece _piece { get; set; }
        public Chess(Piece piece)
        {
            _piece = piece;
        }

        public bool ValidPhoneNumber(string input)
        {

            if (input.Length != 7)
                return false;

            switch (_piece)
            {
                case Piece.Rook:
                    break;
                default:
                    throw new InvalidOperationException("Piece not found.");
            }

            var valid = true;

            for (var i=0; i<input.Length - 1;i++)
            {

                switch (input[i])
                {
                    case '*':
                        return false;

                    case '#':
                        return false;

                    case '0':
                        if (i==0)
                            return false;
                        switch (_piece)
                        {
                            case Piece.Rook:
                                if (input[i + 1] != '2' &&
                                    input[i + 1] != '5' &&
                                    input[i + 1] != '8')
                                    return false;
                                break;
                        }
                        break;

                    case '1':
                        if (i == 0)
                            return false;
                        switch (_piece)
                        {
                            case Piece.Rook:
                                if (input[i + 1] != '2' &&
                                    input[i + 1] != '3' &&
                                    input[i + 1] != '4' &&
                                    input[i + 1] != '7')
                                    return false;
                                break;
                        }
                        break;

                    case '2':
                        switch (_piece)
                        {
                            case Piece.Rook:
                                if (input[i + 1] != '1' &&
                                    input[i + 1] != '3' &&
                                    input[i + 1] != '5' &&
                                    input[i + 1] != '8' &&
                                    input[i + 1] != '0')
                                    return false;
                                break;
                        }
                        break;

                    case '3':
                        switch (_piece)
                        {
                            case Piece.Rook:
                                if (input[i + 1] != '1' &&
                                    input[i + 1] != '2' &&
                                    input[i + 1] != '6' &&
                                    input[i + 1] != '9')
                                    return false;
                                break;
                        }
                        break;

                    case '4':
                        switch (_piece)
                        {
                            case Piece.Rook:
                                if (input[i + 1] != '1' &&
                                    input[i + 1] != '7' &&
                                    input[i + 1] != '5' &&
                                    input[i + 1] != '6')
                                    return false;
                                break;
                        }
                        break;

                    case '5':
                        switch (_piece)
                        {
                            case Piece.Rook:
                                if (input[i + 1] != '4' &&
                                    input[i + 1] != '6' &&
                                    input[i + 1] != '2' &&
                                    input[i + 1] != '8' &&
                                    input[i + 1] != '0')
                                    return false;
                                break;
                        }
                        break;

                    case '6':
                        switch (_piece)
                        {
                            case Piece.Rook:
                                if (input[i + 1] != '4' &&
                                    input[i + 1] != '5' &&
                                    input[i + 1] != '3' &&
                                    input[i + 1] != '9')
                                    return false;
                                break;
                        }
                        break;

                    case '7':
                        switch (_piece)
                        {
                            case Piece.Rook:
                                if (input[i + 1] != '1' &&
                                    input[i + 1] != '4' &&
                                    input[i + 1] != '8' &&
                                    input[i + 1] != '9')
                                    return false;
                                break;
                        }
                        break;

                    case '8':
                        switch (_piece)
                        {
                            case Piece.Rook:
                                if (input[i + 1] != '2' &&
                                    input[i + 1] != '5' &&
                                    input[i + 1] != '0' &&
                                    input[i + 1] != '7' &&
                                    input[i + 1] != '9')
                                    return false;
                                break;
                        }
                        break;

                    case '9':
                        switch (_piece)
                        {
                            case Piece.Rook:
                                if (input[i + 1] != '3' &&
                                    input[i + 1] != '6' &&
                                    input[i + 1] != '7' &&
                                    input[i + 1] != '8')
                                    return false;
                                break;
                        }
                        break;
                }
            }

            return valid;
        }


    }

}
