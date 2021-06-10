using System.Collections.Generic;

namespace Project2.DataSource
{
    public static class BoardDataSource
    {
        public static Board Board;


        static BoardDataSource()
        {
            Board = InitializeBoard();
        }

        static Board InitializeBoard()
        {
            return new Board()
            {
                BoardElements = new List<BoardElement>()
                {
                    new BoardElement()
                    {
                        Card = new Card("Başlık 1","İçerik 1", 1, SizeType.L),
                        Status = StatusType.DONE
                    },

                    new BoardElement()
                    {
                        Card = new Card("Başlık 2","İçerik 2", 2, SizeType.XL),
                        Status = StatusType.INPROGRESS
                    },

                    new BoardElement()
                    {
                        Card = new Card("Başlık 3","İçerik 3", 3, SizeType.XS),
                        Status = StatusType.TODO
                    }
                }
            };
        }
    }
}