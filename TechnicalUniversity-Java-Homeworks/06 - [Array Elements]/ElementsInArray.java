package homework2;

import java.util.Arrays;

public class ElementsInArray {
    public static void main(String[] args) {
        int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 60, 80, 200, 120, 15, 16, 6737, 21, 73, 15, 74, 1223, 125, 87, 90, 99, 98, 111};

        arr = Arrays.stream(arr)
                .filter(x -> x % 2 == 1)
                .filter(x -> x >= 99 && x <= 125)
                .toArray();

        for (Integer item : arr) {
            System.out.print(item + " ");
        }
    }
}
