public class Solution {
    public bool IsValidSudoku(char[][] board) {
        int n = board.Length;

        for (int i = 0; i < n; i++) {
            // Row check
            HashSet<int> rowSet = new();
            for (int j = 0; j < n; j++) {
                if (board[i][j] == '.')
                    continue;
                if (!rowSet.Add(board[i][j]))
                    return false;
            }
            // Column check
            HashSet<int> columnSet = new();
            for (int j = 0; j < n; j++) {
                if (board[j][i] == '.')
                    continue;
                if (!columnSet.Add(board[j][i]))
                    return false;
            }
        }

        for (int rowStart = 0; rowStart < n; rowStart += 3) {
            for (int colStart = 0; colStart < n; colStart += 3) {
                HashSet<int> squareSet = new();
                for (int i = rowStart; i < (rowStart + 3); i++) {
                    for (int j = colStart; j < (colStart + 3); j++) {
                        if (board[i][j] == '.')
                            continue;
                        if (!squareSet.Add(board[i][j]))
                            return false;
                    }
                }
            }
        }

        return true;
    }
}
