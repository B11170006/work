public class MathUtil
{
    // Cube 計算 int 參數的立方
    public static int Cube(int n)
    {
        return n * n * n;
    }

    // Cube 計算 double 參數的立方
    public static double Cube(double n)
    {
        return n * n * n;
    }

    // MinElement，傳入 3 個 int 參數，回傳最小值
    public static int MinElement(int a, int b, int c)
    {
        int min = a;
        if (b < min) min = b;
        if (c < min) min = c;
        return min;
    }

    // MinElement，傳入 4 個 int 參數，回傳最小值
    public static int MinElement(int a, int b, int c, int d)
    {
        int min = a;
        if (b < min) min = b;
        if (c < min) min = c;
        if (d < min) min = d;
        return min;
    }
}