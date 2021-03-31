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
     <h2> Please enter your personal details:</h2>

    <form action='<?php echo $_SERVER["PHP_SELF"] ?>' method='post'>
        <p>
            <label for="strFirstName">Firstname</label>
            <input type="text" name="strFirstName" id="strFirstName" />
        </p>
        <p>
            <label for="strSurName">Surname</label>
            <input type="text" name="strSurName" id="strSurName" />
        </p>
        <p>
            <label for="strUserName">Username</label>
            <input type="text" name="strUserName" id="strUserName" />
        </p>
        <p><label for="strPassword">Password</label>
            <input type="password" name="strPassword" id="strPassword" />
        </p>
        <p>
            <label for="date">My Birthday is</label>
            <select id="date" name="day">
                <?php
                for ($i = 1; $i < 32; $i++) {
                ?><option value="<?php echo $i; ?>"><?php echo $i; ?></option>
                <?php } ?>
            </select>
            <select id="date" name="month">
                <?php
                for ($i = 1; $i < 13; $i++) { ?>
                    <option value="<?php echo $i; ?>"><?php echo $i; ?></option><?php } ?>
            </select>
            <select id="date" name="year">
            <?php for ($i = 2015; $i < 2100; $i++) { ?>
                <option value="<?php echo $i; ?>"><?php echo $i; ?></option><?php } ?>
            </select>
        </p>
        <p>
            <label for="gender">My gender is:</label>
            <input type="radio" name="gender" id="gender" value="male" />m
            <input type="radio" name="gender" id="gender" value="female" />f
        </p>
        <p>
            <label for="moreInfo">More info...</label>
        </p>
        <p>
            <textarea name="moreInfo" id="moreInfo" rows="5"></textarea>
        </p>
        <p>
            <input type="submit" name="Submit1" />
        </p>
    </form>

    <?php 
        if(isset($_POST['Submit1'])){
            $strFirstName=$_POST['strFirstName'];
            $strSurName=$_POST['strSurName'];
            $strUserName=$_POST['strUserName'];
            $strPassword=$_POST['strPassword'];
            $gender=$_POST['gender'];
            $birthDay=$_POST['day'];
            $birthMonth=$_POST['month'];
            $birthYear=$_POST['year'];
            $moreInformation=$_POST['moreInfo'];

            echo"<p>Greatings $strFirstName $strSurName</p>";
            echo"<p>Your username is $strUserName and your password is $strPassword</p>";
            echo"<p>Your gender is $gender</p>";
            echo"<p>Your birthday is $birthDay/$birthMonth/$birthYear</p>";
            echo"<p>More info: $moreInformation</p>";
        }
    ?> -->

    <!-- Problem 2 -->
    <h2> Parallelepiped Volume</h2>

    <form action='<?php echo $_SERVER["PHP_SELF"] ?>' method='post'>
        <p>
            <label for="aSide">A side</label>
            <input type="text" name="aSide" id="aSide" />
        </p>
        <p>
            <label for="bSide">B side</label>
            <input type="text" name="bSide" id="bSide" />
        </p>
        <p>
            <label for="cSide">C side</label>
            <input type="text" name="cSide" id="cSide" />
        </p>
        <p>
            <input type="submit" name="Submit2" />
        </p>
    </form>

    <?php 
        if(isset($_POST['Submit2'])){
            $a=$_POST['aSide'];
            $b=$_POST['bSide'];
            $c=$_POST['cSide'];

            $volume = $a * $b * $c;

            echo"<p>Result $volume</p>";
           
        }
    ?> -->

    <!-- Problem 3 -->
    <h2>Login</h2>

    <form action='<?php echo $_SERVER["PHP_SELF"] ?>' method='post'>
        <p>
            <label for="username">Username</label>
            <input type="text" name="username" id="username" />
        </p>
        <p>
            <label for="password">Password</label>
            <input type="password" name="password" id="password" />
        </p>
        <p>
            <input type="submit" name="Submit3" />
        </p>
    </form>

    <?php 
        if(isset($_POST['Submit3'])){
            $usernameInput = $_POST['username'];
            $passwordInput = $_POST['password'];

            $array = array (
                "username1" => "password1",
                "test1" => "test1",
                "shturkel" => "mnogoSlojnaParola",
                "test" => "test"
            );

            $isValid = false;

            foreach($array as $username => $password){
                if($username == $usernameInput &&
                    $password == $passwordInput){
                        echo"<p>Successfully logged in: $username";

                        $isValid = true;
                }
            }

            if(!$isValid){
                echo "Invalid username or pass.";
            }
        }
    ?>
</body>

</html>