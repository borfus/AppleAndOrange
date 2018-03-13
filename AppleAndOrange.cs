static void Main(String[] args) {
    string[] tokens_s = Console.ReadLine().Split(' ');
    int s = Convert.ToInt32(tokens_s[0]);
    int t = Convert.ToInt32(tokens_s[1]);
    string[] tokens_a = Console.ReadLine().Split(' ');
    int a = Convert.ToInt32(tokens_a[0]);
    int b = Convert.ToInt32(tokens_a[1]);
    string[] tokens_m = Console.ReadLine().Split(' ');
    int m = Convert.ToInt32(tokens_m[0]);
    int n = Convert.ToInt32(tokens_m[1]);
    string[] apple_temp = Console.ReadLine().Split(' ');
    int[] apple = Array.ConvertAll(apple_temp,Int32.Parse);
    string[] orange_temp = Console.ReadLine().Split(' ');
    int[] orange = Array.ConvertAll(orange_temp,Int32.Parse);
        
    int aResult = 0;
    int oResult = 0;
        
    foreach (int i in apple) {
        if ((i + a) >= s && (i + a) <= t)
            aResult++;
    }
    foreach (int i in orange) {
        if ((i + b) >= s && (i + b) <= t)
            oResult++;
    }
        
    Console.WriteLine("{0}\n{1}", aResult, oResult);
}