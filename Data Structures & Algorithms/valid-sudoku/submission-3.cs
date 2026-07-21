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

        for(int i=0; i<n; i+=3){
            HashSet<char> set = new();
            for(int j=0; j<n; j++){
                if(j%3==0){
                    set.Clear();
                }

                for(int r=i; r<i+3; r++){
                    if(board[j][r] != '.' && !set.Add(board[j][r]))
                        return false;
                }
            }
        }

        return true;
    }
}
