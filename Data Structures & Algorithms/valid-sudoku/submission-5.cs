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

        for (int startRow = 0; startRow < n; startRow += 3) {
            for (int startCol = 0; startCol < n; startCol += 3) {
                HashSet<int> subBoxSet = new();
                for (int i = startRow; i < startRow + 3; i++) {
                    for (int j = startCol; j < startCol + 3; j++) {
                        if (board[i][j] == '.')
                            continue;
                        if (!subBoxSet.Add(board[i][j]))
                            return false;
                    }
                }
            }
        }

        return true;
    }
}
