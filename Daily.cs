public class Solution {
    public long FlowerGame(int n, int m) {
        long res = 0;

        long numEvenM = m / 2;
        long numOddM = numEvenM;
        if (m % 2 == 1) numOddM++;

        long numEvenN = n / 2;
        long numOddN = numEvenN;
        if (n % 2 == 1) numOddN++;
       
       res = (numEvenN * numOddM) + (numOddN * numEvenM);

       return res;
    }
}
