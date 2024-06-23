/*
	Note:
		int 是 2 的 31 次方在減 1
		long 是 2 的 63 次方在減 1
		所以計算平方需要考慮到溢位問題

	Summary:
		先算中間值的平方
		第一個迴圈
		若平方等於輸入時，結果為中間值
		若平方大於輸入時，代表 binary search 的 right 會往中間靠
		若平方小於輸入時，代表 binary search 的 left 會往中間靠
		若沒有回傳會 middle 最後會相等
		第二個迴圈
		計算 middle 平方是否為我們需要的結果
		沒有的話會減1
		最後再回傳正確答案
*/

public class Solution
{
    public int MySqrt(int x)
    {
        long left = 0;
        long right = x;

        while (left < right)
        {
            long middle = (left + right) / 2;
            long middleXmiddle = middle * middle;

            if (middleXmiddle == x)
            {
                return (int)middle;
            }
            else if (middleXmiddle > x)
            {
                right = middle;
            }
            else
            {
                left = middle + 1;
            }
        }

        while (left * left > x)
        {
            left -= 1;
        }

        return (int)left;
    }
}