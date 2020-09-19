package homework;

import java.util.Arrays;
import java.util.Collections;
import java.util.List;

public class homework {
    public static void main(String[] args) {
        List<String> colorsList = Arrays.asList("Black", "Brown", "White", "Blue", "Yellow", "Green", "Cyan");
        Collections.reverse(colorsList);

        for (String color : colorsList) {
            System.out.println(color);
        }
    }
}
