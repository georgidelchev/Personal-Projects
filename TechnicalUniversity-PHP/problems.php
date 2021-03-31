<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
        <?php 
            echo("Lab 1 - Problems")
        ?>

        <br>
        <br>

        Problem #2
        <br>
        <?php
            define("AUTHOR", "Simon Stibart");

            echo(AUTHOR)
        ?>

        <br>
        <br>

        Problem #3
        <?php 
            $num = 8;
            echo("<br>Value is now $num");
            $num += 2;
            echo("<br>Add 2. Values is now $num");
            $num -= 4;
            echo("<br>Subtract 4. Value is now $num");
            $num *= 5;
            echo("<br>Multiply by 5. Value is now $num");
            $num /= 3;
            echo("<br>Divide by 3. Value is now $num");
            $num++;
            echo("<br>Increment value by one. Value is now $num");
            $num--;
            echo("<br>Decrement value by one. Value is now $num");
        ?>
</body>
</html>