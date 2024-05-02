<div class="clear"></div>
<div class="main">
    <?php
    if (isset($_GET['action'])) {
        $tam = $_GET['action'];
    } else {
        $tam = '';
    }
    if ($tam == "danhmucsanpham") {
        include("moden/danhmucsanpham/them.php");
    }

    ?>
</div>