<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <!-- Problem 1 -->
    <?php 
        $intNumber=100;
        $strNumber="80";
    
        if($intNumber > $strNumber) 
            echo "<p>$intNumber is larger than $strNumber</p>";
        elseif($intNumber==$strNumber)
            echo"<p>$intNumber is equal to $strNumber</p>";
        else 
            echo"<p>$intNumber is small than $strNumber</p>";
    ?>

    <br>
    <br>

    <?php 
        $month = 10;
        
        switch($month):
            case 3: 
            case 4: 
            case 5: 
                echo "Сезона е пролет"; 
                break;
            case 6: 
            case 7: 
            case 8: 
                echo "Сезона е лято"; 
                break;
            case 9: 
            case 10: 
            case 11: 
                echo "Сезона е есен"; 
                break;
            case 12: 
            case 1: 
            case 2: 
                echo "Сезона е зима"; 
                break;
            default: 
                echo "$month е невалиден номер за месец"; 
        endswitch;
    ?> 

    <br>
    <br>

    <?php 
        $i=1;
        
        while($i<10):
            if($i % 2 == 0)
                print $i." ";$i++;
        endwhile;

        echo "<br>";

        $i=1;

        do{
            if($i%2==0)
                print $i." ";
                    $i++;
          }while($i<10);
          
          echo "<br>";

          for($i = 1; $i < 10; $i++) 
            if($i % 2 == 0){
                print $i." ";
            }
    ?>

    <br>
    <!-- Problem 1 -->
    <?php 
        include 'variables.php';
    
        if($intNumber > $strNumber) 
            echo "<p>$intNumber is larger than $strNumber</p>";
        elseif($intNumber==$strNumber)
            echo"<p>$intNumber is equal to $strNumber</p>";
        else 
            echo"<p>$intNumber is small than $strNumber</p>";
    ?>

    <!-- Problem - 2 -->
    <?php
        for($i = 1; $i < 10; $i++) 
        if($i % 2 == 0){
            print $i." ";
        } 
    ?>

    <br>

    <!-- Problem - 3 -->
    <?php
        for($i=1;$i<10;$i++) 
            if($i%2==0) 
                print$i." ";
        
            echo "<br>";

        for($i=1;;$i++) {
        if($i == 10) break;
        
        if($i % 2 == 0) print$i." ";
    }
    ?>
    <!-- Problem - 4 -->
    <?php 
        $num = 2;
        $counter = 1;

        while($counter <= 10):
            $result = $counter * $num;

            echo "<br>$counter x $num = $result";

            $counter++;
        endwhile
    ?>
</body>
</html>