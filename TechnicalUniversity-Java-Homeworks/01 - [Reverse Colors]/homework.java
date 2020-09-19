package homework;

import java.util.Arrays;
import java.util.Collections;
import java.util.List;

public class homework {
    public static void main(String[] args){
        List<String> colors = Arrays.asList("Black","Brown","White","Blue","Yellow","Green","Cyan");

        Collections.reverse(colors);

        for (String color : colors){
            System.out.println(color);
        }
    }
}
