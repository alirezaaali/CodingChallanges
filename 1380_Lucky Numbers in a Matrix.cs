public class Solution {
    public IList<int> LuckyNumbers (int[][] matrix) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        List<int> result = new List<int>();

        // Find the minimum elements in each row
        int[] rowMins = new int[m];
        int[] rowMinColumns = new int[m];
        
        for (int i = 0; i < m; i++) {
            int minVal = matrix[i][0];
            int minCol = 0;
            for (int j = 1; j < n; j++) {
                if (matrix[i][j] < minVal) {
                    minVal = matrix[i][j];
                    minCol = j;
                }
            }
            rowMins[i] = minVal;
            rowMinColumns[i] = minCol;
        }
        
        // Check if the row minimums are column maximums
        for (int i = 0; i < m; i++) {
            int candidate = rowMins[i];
            int col = rowMinColumns[i];
            bool isMaxInColumn = true;

            for (int k = 0; k < m; k++) {
                if (matrix[k][col] > candidate) {
                    isMaxInColumn = false;
                    break;
                }
            }

            if (isMaxInColumn) {
                result.Add(candidate);
            }
        }

        return result;
    }
}