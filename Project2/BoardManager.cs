using Project2.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2
{
    public class BoardManager
    {
        public List<BoardElement> ListBoard()
        {
            return BoardDataSource.Board.BoardElements.ToList();
        }

        public bool AddCardToBoard(Card card)
        {
            try
            {
                /*YENİ EKLENEN KART tTODO STATÜSÜNDE EKLENİYOR */
                BoardDataSource.Board.BoardElements.Add(new BoardElement(card, StatusType.TODO));
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public BoardElement FindBoardElementByCard(string cardTitle)
        {
            return BoardDataSource.Board.BoardElements.FirstOrDefault(x => x.Card.Title.ToLower() == cardTitle.ToLower());
        }

        public bool RemoveBoardElement(BoardElement boardElement)
        {
            try
            {
                BoardDataSource.Board.BoardElements.Remove(boardElement);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool CarryCard(BoardElement boardElement)
        {
            try
            {
                foreach (var element in BoardDataSource.Board.BoardElements)
                {
                    //REFERANSLAR EŞİT İSE, GÜNCELLE
                    if (element == boardElement)
                    {
                        element.Status = boardElement.Status;
                        break;
                    }
                }

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}