public class Solution {
    public bool IsValidSudoku(char[][] board) {
        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                if (board[i][j] == '.')
                    continue;
                if (!(IsValidRow(board, i, j) && IsValidColumn(board, i, j) &&
                      IsValidSquare(board, i, j))) {
                    return false;
                }
            }
        }

        return true;
    }

    private bool IsValidRow(char[][] board, int row, int col) {
        char c = board[row][col];
        for (int i = 0; i < 9; i++) {
            if (i == col || board[row][i] == '.')
                continue;
            if (board[row][i] == c) {
                return false;
            }
        }
        return true;
    }

    private bool IsValidColumn(char[][] board, int row, int col) {
        char c = board[row][col];
        for (int i = 0; i < 9; i++) {
            if (i == row || board[i][col] == '.')
                continue;
            if (board[i][col] == c) {
                return false;
            }
        }
        return true;
    }

    private bool IsValidSquare(char[][] board, int row, int col) {
        int squareX = row - (row % 3);
        int squareY = col - (col % 3);
        char c = board[row][col];
        for (int i = squareX; i < squareX + 3; i++) {
            for (int j = squareY; j < squareY + 3; j++) {
                if ((i == row && j == col) || board[i][j] == '.')
                    continue;

                if (board[i][j] == c) {
                    return false;
                }
            }
        }
        return true;
    }
}
