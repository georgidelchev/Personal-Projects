package task2;

import java.util.Scanner;

public class task2 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        System.out.print("Enter str: ");
        String str = input.nextLine();

        System.out.print("Enter char: ");
        char ch = input.next().charAt(0);

        int counter = 0;

        System.out.println(CountOfChar(str, ch, counter));
    }

    public static int CountOfChar(String str, char ch, int counter) {
        for (int i = 0; i < str.length(); i++) {
            if (str.charAt(i) == ch) {
                counter++;
            }
        }

        return counter;
    }
}
