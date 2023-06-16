namespace Null_LeetCode
{
    public class SearchATwoDMatrix0074
    {
        public bool SearchMatrixBruteLike(int[][] matrix, int target)
        {
            var rows = matrix.Length;
            var columns = matrix[0].Length;
            
            var length = columns * rows;

            var left = 0;
            var right = length - 1;

            while (left <= right)
            {
                var middle = (right - left) / 2 + left;
                var parsed = (row: middle / columns, column: middle % columns);
                var value = matrix[parsed.row][parsed.column];

                if (target == value)
                    return true;

                if (value > target)
                    right = middle - 1;
                else
                    left = middle + 1;
            }
            
            return false;
        }

        public bool SearchMatrix(int[][] matrix, int target)
        {
            var rows = matrix.Length;
            var columns = matrix[0].Length;

            int top = 0, bot = rows - 1;
            int row = 0;

            while (top <= bot)
            {
                row = (bot - top) / 2 + top;
                
                if (target > matrix[row][columns - 1])
                    top = row + 1;
                else if (target < matrix[row][0])
                    bot = row - 1;
                else
                    break;
            }

            if (top > bot)
                return false;
            
            int left = 0, right = columns - 1;

            while (left <= right)
            {
                var middle = (right - left) / 2 + left;

                if (target == matrix[row][middle])
                    return true;

                if (target > matrix[row][middle])
                    left = middle + 1;
                else
                    right = middle - 1;
            }

            return false;
        }
    }
}