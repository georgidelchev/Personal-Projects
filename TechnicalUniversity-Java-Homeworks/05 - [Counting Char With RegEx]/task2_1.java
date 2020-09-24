package task2;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class task2_1 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        System.out.print("Enter str: ");
        String str = input.nextLine();

        Pattern pattern = Pattern.compile("[z]");
        Matcher matcher = pattern.matcher(str);

        System.out.println(CountingChar(matcher));
    }

    public static int CountingChar(Matcher matcher) {
        int counter = 0;

        while (matcher.find()) {
            counter++;
        }

        return counter;
    }
}
