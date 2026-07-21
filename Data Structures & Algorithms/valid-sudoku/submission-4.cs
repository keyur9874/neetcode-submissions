public class Solution {
    public bool IsValidSudoku(char[][] board) {
        int n = board.Length;
        for (int i = 0; i < n; i++) {
            HashSet<char> rowSet = new();

            for (int j = 0; j < n; j++) {
                if (board[i][j] != '.' && !rowSet.Add(board[i][j])) {
                    return false;
                }
            }

            HashSet<char> colSet = new();

            for (int j = 0; j < n; j++) {
                if (board[j][i] != '.' && !colSet.Add(board[j][i])) {
                    return false;
                }
            }
        }

        for (int startRow = 0; startRow < n; startRow += 3) {
            for (int startCol = 0; startCol < n; startCol += 3) {
                HashSet<char> set = new();
                for (int i = startRow; i < startRow + 3; i++) {
                    for (int j = startCol; j < startCol + 3; j++) {
                        if (board[i][j] != '.' && !set.Add(board[i][j]))
                            return false;
                    }
                }
            }
        }

        return true;
    }
}
