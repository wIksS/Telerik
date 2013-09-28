<?php
mb_internal_encoding('UTF-8');

$pageTitle = 'Форма';
include 'Header.php';
$groups = array (1=>'Храна',2=>'Транспорт',3=>'Дрехи',4=>'Други');

if ($_POST) {
    $username=trim($_POST['username']);
    $username = str_replace('%', '', $username);
    $cost=trim($_POST['cost']);
    $cost = str_replace('%','',$cost);
    $selectedGroup=(int)$_POST['group'];
    //$date = ($_POST['date']);
    $error = true;
    
    if (mb_strlen($username) < 4) {
        echo '<p>Името е прекалено късо!</p>';
        $error = false;
    }
    if (!is_numeric($cost)) {
        echo '<p>Невалидна сума!</p>';
        $error = false;
    }
    if (!$groups[$selectedGroup]) {
        echo '<p>Невалиден вид!</p>';
        $error = false;
    }    
   // if (!is_numeric($date)) {
    //    echo '<p>Невалидна дата!</p>';
   //     $error = false;
   // }        
    
    if ($error) {
        $result = $username.'%'.$cost.'%'.$selectedGroup.'%'.time()."\n";
        if(file_put_contents('data.txt', $result,FILE_APPEND)){
        }
    }
    
}
?>
<a href="index.php">Списък</a>
<form method ="POST">                
    <div>Име:<input type="text" name ="username"/></div>
    <div>Сума:<input type="text" name ="cost"/></div>
    <!--div>Дата:<input type="text" name ="date"/></div-->    
    <div>
        <select name="group">
            <?php
            foreach ($groups as $key=>$value) {
                echo '<option value="'.$key.'">' . $value . '</option>';
            }
            ?>
        </select>                          
    </div>
    <div><input type="submit" value="Добави"/></div>
</form>
<?php
include 'Footer.php';
?>   