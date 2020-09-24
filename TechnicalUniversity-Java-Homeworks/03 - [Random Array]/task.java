package task;

import java.util.InputMismatchException;
import java.util.Scanner;

public class task {
    public static void main(String[] args) {
        int n = 0;
        boolean status;

        String warning = String.format("N must be valid");

        try {
            Scanner input = new Scanner(System.in);

            do {
                status = false;
                System.out.println("Enter size");

                try {
                    n = input.nextInt();

                    if (n < 1 || n % 2 == 1) {
                        System.out.println(warning);
                    } else {
                        status = true;
                    }
                } catch (InputMismatchException ime) {
                    input.next();
                    System.out.println(warning);
                }

            } while (!status);

            input.close();
        } finally {
            System.out.println("Size entered successfully :).");
        }

        int arr[] = new int[n];

        for (int i = 0; i < n; i++) {
            int value = (int) (Math.random() * n);

            arr[i] = value;
        }

        int m = n / 2;

        for (int i = 0; i < n; i++) {
            int digit = arr[i];

            if (digit == m) {
                String info = String.format("Arr[%d] = %d", i, m);
                System.out.println(info);
            }
        }
    }
}
