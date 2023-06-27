package homework2;

import java.util.Arrays;

public class ElementsInArray2 {
    public static void main(String[] args) {
        int[] arr = {1, 99, 2, 3, 4, 5, 6, 7, 8, 9, 10, 60, 80, 200, 120, 15, 16, 6737, 21, 73, 15, 74, 1223, 125, 87, 90, 99, 98, 111};

        for (int i = 0; i < arr.length; i++) {
            if (arr[i] % 2 == 1 && (arr[i] >= 99 && arr[i] <= 125)) {
                System.out.println("[" + i + "]" + " - " + arr[i]);
            }
        }
    }
}
