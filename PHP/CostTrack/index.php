<?php
$pageTitle = 'Списък';

include 'Header.php';
$groups = array (1=>'Всички',2=>'Храна',3=>'Транспорт',4=>'Дрехи',5=>'Други');
?>
<?php
    if (isset($_GET['del']) && (int) $_GET['del'] > 0) {
        $fileData = file('data.txt');
        $newData = "";
        for ($i = 0; $i < count($fileData); $i++) {
            if (strpos($fileData[$i], $_GET['del'])) {
                continue;
            }
            $newData = $newData . $fileData[$i];
        }
        if (file_put_contents('data.txt', $newData)) {
            $successDel = true;
        }
    }
    ?>
<div><a href="Form.php">Добави нов разход</a>
    <form method ="POST">             
        <select name="group">
            <?php
            foreach ($groups as $key=>$value) {
                $selected='';
                if (isset($_POST['group']) && $key == $_POST['group']) {
                    $selected = 'selected="selected"';
                }
                echo '<option value="'.$key.'" '.$selected.'>' . $value . '</option>';
            }
            ?>
        </select>     
        <input type="submit" value="Филтрирай"/>
    </form>
</div>
    
            <table border ="1">
                <tr>
                    <td>Дата</td>
                    <td>Име</td>
                    <td>Сума</td>
                    <td>Вид</td>         
                    <td>Премахване</td>         
                </tr>
                <?php
                if (file_exists('data.txt')) {
                    $sum = 0.00;
                    $result = file('data.txt');
                    $date = date('Y.m.d');
                    if ($_POST == null || $_POST['group'] == 1) {                       
                    
                       foreach ($result as $key=>$value) {
                        $columns = explode('%',$value);
                            $sum+= (float)$columns[1];                        
                        echo '<tr>
                            <td>'.$date.'</td>
                            <td>'.$columns[0].'</td>
                            <td>'.$columns[1].'</td>
                            <td>'.$groups[(int)$columns[2]+1].'</td>
                            <td><a href="index.php?del='.$columns[3].'">Изтрий</a></td>
                            </tr>';
                        }
                 
                    }
                    else {
                        $sum = 0.00;
                        foreach ($result as $value) {
                        $columns= explode('%',$value);
                        if ((int)$columns[2]+1 == $_POST['group']) {    
                            $sum+= (float)$columns[1];
                        echo '<tr>
                            <td>'.$date.'</td>
                            <td>'.$columns[0].'</td>
                            <td>'.$columns[1].'</td>
                            <td>'.$groups[(int)$columns[2]+1].'</td>
                            <td><a href="index.php?del='.$columns[3].'">del</a></td>
                            </td>';
                        }
                    }
                    }
                    echo '<tr>
                            <td>'.'----'.'</td>
                            <td>'.'----'.'</td>
                            <td>'.number_format((float)$sum, 2,".","").'</td>
                            <td>'.'----'.'</td>
                            <td>'.'----'.'</td>
                            </tr>';
                }
                
                ?>
            </table>
<?php
include 'Footer.php';
?>
