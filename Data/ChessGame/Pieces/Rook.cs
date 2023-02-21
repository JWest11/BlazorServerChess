﻿namespace BlazorServerChess.Data.ChessGame.Pieces
{
	public class Rook : Piece
	{
		public Rook(Game game, ColorEnum color, int tileIndex) : base(game, color, tileIndex)
		{
			PieceType = PieceEnum.Rook;
		}

		public override List<int> GetControlledSquares()
		{
			List<int> result = new List<int>();
			int i = TileId - 8;
			while (i >= 0)
			{
				if (_game.Board[i] == null)
				{
					result.Add(i);
				}
				else
				{
					result.Add(i);
					break;
				}
				i -= 8;
			}
			i = TileId + 8;
			while (i <= 64)
			{
				if (_game.Board[i] == null)
				{
					result.Add(i);
				}
				else
				{
					result.Add(i);
					break;
				}
				i += 8;
			}
			i = TileId % 8 - 1;
			while (TileId % 8 - i >= 0)
			{
				if (_game.Board[i] == null)
				{
					result.Add(TileId - i);
				}
				else
				{
					result.Add(i);
					break;
				}
				i -= 1;
			}
			i = TileId % 8 + 1;
			while (TileId % 8 + i <= 7)
			{
				if (_game.Board[i] == null)
				{
					result.Add(TileId + i);
				}
				else
				{
					result.Add(i);
					break;
				}
			}
			return result;
		}

		public override List<int> GetMoves()
		{
			List<int> result = new List<int>();
			int i = TileId - 8;
			while (i >= 0)
			{
				if (_game.Board[i] == null)
				{
					result.Add(i);
				}
				else
				{
					if (_game.Board[i].Color != Color)
					{
						result.Add(i);
					}
					break;
				}
				i -= 8;
			}
			i = TileId + 8;
			while (i <= 64)
			{
				if (_game.Board[i] == null)
				{
					result.Add(i);
				}
				else
				{
					if (_game.Board[i].Color != Color)
					{
						result.Add(i);
					}
					break;
				}
				i += 8;
			}
			i = TileId % 8 - 1;
			while (TileId % 8 - i >= 0)
			{
				if (_game.Board[i] == null)
				{
					result.Add(TileId - i);
				}
				else
				{
					if (_game.Board[TileId - i].Color != Color)
					{
						result.Add(i);
					}
					break;
				}
				i -= 1;
			}
			i = TileId % 8 + 1;
			while (TileId % 8 + i <= 7)
			{
				if (_game.Board[i] == null)
				{
					result.Add(TileId + i);
				}
				else
				{
					if (_game.Board[TileId + i].Color != Color)
					{
						result.Add(i);
					}
					break;
				}
			}

			return result;
		}
	}
}
