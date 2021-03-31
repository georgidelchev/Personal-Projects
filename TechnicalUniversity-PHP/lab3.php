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
        function &ref($par) {
            return $GLOBALS['name'];
        }
        
        $name = "Petter";
        $var = &ref($name);
        
        echo "<br>name is ".$name; 
        echo"<br>name is ".$var;
        
        $var = "Mimi";
        
        echo"<br>name is ".$name;
        echo "<br>name is ".$var;
    ?>

    <br>
    <br>

    <?php $arr = array("Article" => array(1 => "Kivi",5 => "Apple",3 => "Orange"),
                       "Price" => array(1 => 2.35,5 => 1.35,3 => 1.70));
                     
        echo $arr['Article'][1]."-".$arr['Price'][1];
        echo "<br>".$arr['Article'][5]."-".$arr['Price'][5];
        echo "<br>".$arr['Article'][3]."-".$arr['Price'][3];
    ?>

    <br>

    <?php
        $arrColors = array("R"=>"Red","G"=>"Green","B"=>"Blue");
            foreach($arrColors as$strKey=>$strColor)
                echo"<p>$strKey-$strColor";
    ?>
    
    <br>
    <br>

    <!-- Problem 2 -->
    <?php 
        function recArea($length, $width){
            $area = $length * $width;

            echo "<br>Правоъгълник с дължина $length и ширина $width има лице $area";
        }

        echo "<h3>Rectangle Area Function</h3>";

        recArea(2,4);
        recArea(4,4);
        recArea(5,4);
        recArea(6,4);
    ?>

    <br>
    <br>

    <!-- Problem 3 -->
    <?php 
        $array = array (
            "pavel1" => "strongPass",
            "dimitrichko" => "mente",
            "shturkel" => "menteParola1"
        );

        $inputUsername = "shturkel";
        $inputPassword = "menteParola1";

        $isValid = false;
        foreach($array as $username => $password)
                if($username == $inputUsername &&
                    $password == $inputPassword){
                        echo"<br><p>Successfully logged in: $username";
                        $isValid = true;
                }

                if(!$isValid){
                    echo "Invalid username or pass.";
                }
    ?>

<br>
<br>

    <!-- Problem 4 -->
    <!-- <?php $arr = array("CarBrand" => array("brand" => "Audi"),
                       "CarColor" => array("color" => "Blue"),
                       "InStock" => array("count"=> 50));
                     
        foreach($arr as $key){
            printf("%-10s %s\n",  $key['brand'], $key['color'],$key['count']);
        }
    ?> -->
</body>
</html>