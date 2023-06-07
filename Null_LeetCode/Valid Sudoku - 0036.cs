using System;
using System.Collections.Generic;
using System.Linq;

namespace Null_LeetCode
{
    public class ValidSudoku0036
    {
        public bool IsValidSudoku(char[][] board)
        {
            for (var x = 0; x < 9; x++)
            {
                var row = board[x];
                var column = board.Select(cArr => cArr[x]);
                if (!(IsValidArrSudoku(row) && IsValidArrSudoku(column)))
                    return false;
            }

            for (var y = 0; y < 9; y += 3)
                for (var x = 0; x < 9; x += 3)
                {
                    var square = new []
                    {
                        board[y][x],     board[y][x + 1],     board[y][x + 2],
                        board[y + 1][x], board[y + 1][x + 1], board[y + 1][x + 2],
                        board[y + 2][x], board[y + 2][x + 1], board[y + 2][x + 2]
                    };
                    if (!IsValidArrSudoku(square))
                        return false;
                }

            return true;
        }

        private static bool IsValidArrSudoku(IEnumerable<char> arr)
        {
            var boolArr = new HashSet<char>();
            return arr.Where(num => num != '.').All(num => boolArr.Add(num));
        }

        public bool IsValidSudokuOptimized(char[][] board)
        {
            var row = new HashSet<char>[9];
            var column = new HashSet<char>[9];
            var box = new HashSet<char>[9];

            for (var x = 0; x < 9; x++)
            {
                row[x] = new HashSet<char>();
                column[x] = new HashSet<char>();
                box[x] = new HashSet<char>();
            }

            for (var x = 0; x < 9; x++)
            {
                for (var y = 0; y < 9; y++)
                {
                    var element = board[x][y];
                    if (element == '.') continue;

                    if (!row[x].Add(element)) return false;
                    if (!column[y].Add(element)) return false;

                    var z = (3 * (x / 3)) + (y / 3);
                    if (!box[z].Add(element)) return false;
                }
            }

            return true;
        }
    }
    
    
    // var board = new []
    // {
    //     new [] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
    //     new [] { '6', '.', '.', '1', '9', '5', '.', '.', '.' }, 
    //     new [] { '.', '9', '8', '.', '.', '.', '.', '6', '.' }, 
    //     new [] { '8', '.', '.', '.', '6', '.', '.', '.', '3' }, 
    //     new [] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
    //     new [] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
    //     new [] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
    //     new [] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
    //     new [] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
    // };
    //
    // Console.WriteLine(new ValidSudoku0036().IsValidSudoku(board));
    
    // Test Case
    
}